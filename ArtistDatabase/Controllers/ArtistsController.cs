using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ArtistDatabase.Models;

namespace ArtistDatabase.Controllers
{
    public class ArtistsController : Controller
    {
        private ArtistDBContext db = new ArtistDBContext();

        // GET: Artists
        public ActionResult Index(string nationality, string name)
        {
            var nationalityList = new List<string>();

            var nationalityQuery = from n in db.Artists
                                   orderby n.Nationality
                                   select n.Nationality;

            nationalityList.AddRange(nationalityQuery.Distinct());
            ViewBag.nationality = new SelectList(nationalityList);

            var artists = from a in db.Artists
                          select a;

            if (!String.IsNullOrEmpty(name))
            {
                artists = artists.Where(s => s.Name.Contains(name));
            }

            if (!string.IsNullOrEmpty(nationality))
            {
                artists = artists.Where(x => x.Nationality.Contains(nationality));
            }
            return View(artists);
        }

        // GET: Artists/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Artist artist = db.Artists.Find(id);
            if (artist == null)
            {
                return HttpNotFound();
            }
            return View(artist);
        }

        // GET: Artists/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Artists/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ArtistID,Name,Picture,BirthDate,Nationality,ArtStyle,Info,Rating,Artwork1,Artwork2,Artwork3")] Artist artist)
        {
            if (ModelState.IsValid)
            {
                var table = db.Set<Artist>();
                table.Add(artist);
                //db.Artists.Add(artist);
                db.Entry(artist).State = EntityState.Added;
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(artist);
        }

        //get: /CreateArtwork
        public ActionResult CreateArtwork()
        {
            var artistIDList = new List<int>();
            var artistQuery = from n in db.Artists
                              orderby n.Name
                              select n.ArtistID;

            artistIDList.AddRange(artistQuery.Distinct());
            ViewBag.artistID = new SelectList(artistIDList);
        
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateArtwork([Bind(Include = "ArtworkID,ArtistID,Name,ArtistName,Picture")] Artwork artwork)
        {
            if (ModelState.IsValid)
            {
                db.Artworks.Add(artwork);
                db.SaveChanges();
                return RedirectToAction("Gallery");
            }

            return View(artwork);
        }

        // GET: Artists/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Artist artist = db.Artists.Find(id);
            if (artist == null)
            {
                return HttpNotFound();
            }
            return View(artist);
        }

        // POST: Artists/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ArtistID,Name,Picture,BirthDate,Nationality,ArtStyle,Info,Rating,Artwork1,Artwork2,Artwork3")] Artist artist)
        {
            if (ModelState.IsValid)
            {
                var table = db.Set<Artist>();
                table.Attach(artist);
                db.Entry(artist).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(artist);
        }

        //get
        public ActionResult EditArtwork(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Artwork artwork = db.Artworks.Find(id);
            if (artwork == null)
            {
                return HttpNotFound();
            }
            return View(artwork);
        }

        //set
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditArtwork([Bind(Include = "ArtworkID,ArtistID,Name,ArtistName,Picture")] Artwork artwork)
        {
            if (ModelState.IsValid)
            {
                db.Entry(artwork).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Gallery");
            }
            return View(artwork);
        }

        // GET: Artists/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Artist artist = db.Artists.Find(id);
            if (artist == null)
            {
                return HttpNotFound();
            }
            return View(artist);
        }

        // POST: Artists/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Artist artist = db.Artists.Find(id);
            db.Artists.Remove(artist);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult DeleteArtwork(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Artwork artwork = db.Artworks.Find(id);
            if (artwork == null)
            {
                return HttpNotFound();
            }
            return View(artwork);
        }

        [HttpPost, ActionName("DeleteArtwork")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteArtworkConfirmed(int id)
        {
            Artwork artwork = db.Artworks.Find(id);
            db.Artworks.Remove(artwork);
            db.SaveChanges();
            return RedirectToAction("Gallery");
        }


        //Artists/Gallery/2
        public ActionResult Gallery(string artist, string name)
        {
            var artistList = new List<string>();
            var artistQuery = from n in db.Artworks
                              orderby n.ArtistName
                              select n.ArtistName;

            artistList.AddRange(artistQuery.Distinct());
            ViewBag.artist = new SelectList(artistList);
            //int? id,
            //if (id == null)
            //{
            //    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            //}

            var artwork = from a in db.Artworks
                          .OrderBy(a => a.Name).ToList()
                          select a;
            //Artwork artwork = db.Artworks.Find(id);
            //if (artwork == null)
            //{
            //    return HttpNotFound();
            //}
            if (artwork == null)
            {
                return HttpNotFound();
            }
            if (!String.IsNullOrEmpty(name))
            {
                artwork = artwork.Where(s => s.Name.Contains(name));
            }
            if (!string.IsNullOrEmpty(artist))
            {
                artwork = artwork.Where(x => x.ArtistName.Contains(artist));
            }
            return View(artwork);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
