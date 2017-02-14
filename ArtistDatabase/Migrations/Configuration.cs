namespace ArtistDatabase.Migrations
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ArtistDatabase.Models.ArtistDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ArtistDatabase.Models.ArtistDBContext context)
        {
            context.Artists.AddOrUpdate(i => i.Name,
                new Artist
                {
                    ArtistID = 1,
                    Name = "Pablo Ruiz y Picasso",
                    Picture = "http://a5.files.biography.com/image/upload/c_fit,cs_srgb,dpr_1.0,h_1200,q_80,w_1200/MTE1ODA0OTcxNzU0MDk2MTQx.jpg",
                    BirthDate = DateTime.Parse("25-10-1881"),
                    Nationality = "Spanish",
                    ArtStyle = "Cubism, Surrealism",
                    Info = "Picasso was a Spanish painter, sculptor and ceramicist, among other things. He spent most of his adult life in France, " +
                    " and is regarding as one of the greatest and most influential artists of the 20th century. He is known as co-founding of the" +
                    " 'Cubist' movement; the invention of constructed sculpture, also being the co-inventor of collage, and for the wide variety" +
                    " of styles that he helped develop and explore. Picasso, Henri Matisse and Marcel Duchamp are regarded as the three artists" +
                    " who most defined the revolutionary developments in the plastic arts in the opening decades of the 20th century, responsible" +
                    " for significant developments in painting, sculpture, printmaking and ceramics. Picasso demonstrated extraordinary artistic" +
                    " talent in his early years, painting in a naturalistic manner through his childhood and adolescence.During the first decade" +
                    " of the 20th century, his style changed as he experimented with different theories, techniques, and ideas.His work is often" +
                    " categorized into periods.While the names of many of his later periods are debated, the most commonly accepted periods in his" +
                    " work are the Blue Period(1901–1904), the Rose Period(1904–1906), the African - influenced Period(1907–1909)," +
                    " Analytic Cubism(1909–1912),and Synthetic Cubism(1912–1919),also referred to as the Crystal period. Exceptionally prolific" +
                    " throughout the course of his long life, Picasso achieved universal renown and immense fortune for his revolutionary artistic" +
                    " accomplishments, and became one of the best - known figures in 20th - century art.",
                    Artwork1 = "https://s-media-cache-ak0.pinimg.com/originals/34/c4/8c/34c48c9178f215e2670feec774036803.jpg",
                    Artwork2 = "http://paintingandframe.com/uploadpic/pablo_picasso/big/les_demoiselles_d_avignon_c_1907.jpg",
                    Artwork3 = "http://www.pablopicasso.org/images/paintings/blue-nude.jpg"
                },

                new Artist
                {
                    ArtistID = 2,
                    Name = "Leonardo da Vinci",
                    Picture = "http://www.leonardodavinci.net/images/leonardo-da-vinci.jpg",
                    BirthDate = DateTime.Parse("15-04-1452"),
                    Nationality = "Italian",
                    ArtStyle = "High Renaissance",
                    Info = "Leonardo di ser Piero da Vinci was an Italian polymath whose areas of interest included invention, painting," +
                    " sculpting, architecture, science, music, mathematics, engineering, literature, anatomy, geology, astronomy, botany, writing, history," +
                    " and cartography. He has been variously called the father of palaeontology, ichnology, and architecture, and is widely considered one" +
                    " of the greatest painters of all time. Sometimes credited with the inventions of the parachute, helicopter and tank, he epitomised" +
                    " the Renaissance humanist ideal.Many historians and scholars regard Leonardo as the prime exemplar of the 'Universal Genius' or " +
                    "'Renaissance Man', an individual of 'unquenchable curiosity' and 'feverishly inventive imagination'. According to art historian Helen" +
                    " Gardner, the scope and depth of his interests were without precedent in recorded history, and 'his mind and personality seem to us" +
                    " superhuman, while the man himself mysterious and remote'. Marco Rosci notes that while there is much speculation regarding his life" +
                    " and personality, his view of the world was logical rather than mysterious, and that the empirical methods he employed were unorthodox" +
                    " for his time. Leonardo was, and is, renowned primarily as a painter. Among his works, the Mona Lisa is the most famous and most" +
                    " parodied portrait and The Last Supper the most reproduced religious painting of all time, their fame approached only by Michelangelo's" +
                    " The Creation of Adam. Leonardo's drawing of the Vitruvian Man is also regarded as a cultural icon, being reproduced on items as" +
                    " varied as the euro coin, textbooks, and T-shirts. Perhaps fifteen of his paintings have survived. Nevertheless, these few works," +
                    " together with his notebooks, which contain drawings, scientific diagrams, and his thoughts on the nature of painting, compose a" +
                    " contribution to later generations of artists rivalled only by that of his contemporary, Michelangelo.",
                    Artwork1 = "http://monalisa.org/wp-content/uploads/2013/10/The-%C3%94Earlier-Version%C3%95-as-the-portr-ait-of-Lisa-del-Giocondo_1021_html_m12df3fdd.jpg",
                    Artwork2 = "https://upload.wikimedia.org/wikipedia/commons/2/23/Leonardo_da_Vinci_-_Last_Supper_(copy)_-_WGA12732.jpg",
                    Artwork3 = "http://blog.world-mysteries.com/wp-content/uploads/2011/01/vitruvian_man_mixed.jpg"
                },

                new Artist
                {
                    ArtistID = 3,
                    Name = "Georgia O'Keeffe",
                    Picture = "http://1874.img.pp.sohu.com.cn/images/blog/2008/11/16/20/26/11e4d90ce26g213.jpg",
                    BirthDate = DateTime.Parse("15-11-1887"),
                    Nationality = "American",
                    ArtStyle = "American Modernism",
                    Info = "Georgia Totto O'Keeffe was an American artist. She is best known for her paintings of enlarged flowers, New York skyscrapers," +
                    " and New Mexico landscapes. O'Keeffe has been recognized as the 'Mother of American modernism'. O'Keeffe studied at the School of the" +
                    " Art Institute of Chicago from 1905 to 1906. In 1907, she attended the Art Students League in New York City, where she studied under" +
                    " William Merritt Chase. In 1908, she won the League's William Merritt Chase still-life prize for her oil painting Dead Rabbit with" +
                    " Copper Pot. Her prize was a scholarship to attend the League's outdoor summer school in Lake George, New York. While in the city" +
                    " in 1908, O'Keeffe attended an exhibition of Rodin's watercolors at the gallery 291, owned by her future husband, photographer Alfred" +
                    " Stieglitz. O'Keeffe abandoned the idea of pursuing a career as an artist in late 1908, claiming that she could never distinguish" +
                    " herself as an artist within the mimetic tradition which had formed the basis of her art training. She took a job in Chicago as" +
                    " a commercial artist. She did not paint for four years, and said that the smell of turpentine made her sick. She was inspired to" +
                    " paint again in 1912, when she attended a class at the University of Virginia Summer School, where she was introduced to the innovative" +
                    " ideas of Arthur Wesley Dow by Alon Bement. Dow encouraged artists to express themselves using line, color, and shading" +
                    " harmoniously. From 1912-14, she taught art in the public schools in Amarillo in the Texas Panhandle. She attended Teachers College" +
                    " of Columbia University from 1914–15, where she took classes from Dow, who greatly influenced O'Keeffe's thinking about the process of" +
                    " making art. She served as a teaching assistant to Bement during the summers from 1913–16 and taught at Columbia College, Columbia," +
                    " South Carolina in late 1915, where she completed a series of highly innovative charcoal abstractions. After further course work at" +
                    " Columbia in early 1916 and summer teaching for Bement, she took a job as head of the art department at West Texas State Normal College" +
                    " from late 1916 to February 1918, the fledgling West Texas A&M University in Canyon just south of Amarillo. While there, she often" +
                    " visited the Palo Duro Canyon, making its forms a subject in her work.",
                    Artwork1 = "http://www.georgiaokeeffe.net/images/paintings/rams-head.jpg",
                    Artwork2 = "https://learnodo-newtonic.com/wp-content/uploads/2015/09/Red-Canna-1924-Georgia-OKeeffe.jpg",
                    Artwork3 = "http://www.themasterpiececards.com/hs-fs/hub/40667/file-25876050-jpg/images/okeeffe_jack_2_from_nga-resized-600.jpg?t=1465250810631"
                },

                new Artist
                {
                    ArtistID = 4,
                    Name = "Vincent van Gogh",
                    Picture = "http://site.artsheaven.com/blog/wp-content/uploads/2015/10/vincent.jpg",
                    BirthDate = DateTime.Parse("30-03-1853"),
                    Nationality = "Dutch",
                    ArtStyle = "Post-Impressionism",
                    Info = "Vincent Willem van Gogh was a Dutch painter who is among the most famous and influential figures in the history of Western art." +
                    " In just over a decade he created about 2100 artworks, including around 860 oil paintings, most of them in the last two years of his" +
                    " life. They include landscapes, still lifes, portraits and self-portraits, and are characterised by bold, symbolic colours, and" +
                    " dramatic, impulsive and highly expressive brushwork that contributed to the foundations of modern art. He sold only one painting" +
                    " during his lifetime and became famous after his suicide at age 37, which followed years of poverty and mental illness. Van Gogh's" +
                    " early works, mostly still lifes and depictions of peasant labourers, contain few signs of the vivid colour that distinguished his" +
                    " later work. In 1886 he moved to Paris and discovered the French Impressionists. As his work developed he created a new approach to" +
                    " still lifes and local landscapes. His paintings grew brighter in colour as he developed a style that became fully realised during his" +
                    " stay in Arles in the south of France in 1888. He lived there in the Yellow House and, with the French artist Paul Gauguin, developed a" +
                    " concept of colour that symbolised inner emotion. During this period he broadened his subject matter to include olive trees, cypresses," +
                    " wheat fields and sunflowers. In Nuenen, Van Gogh focused on painting and drawing. Working outside and very quickly, he completed" +
                    " sketches and paintings of weavers and their cottages. In August 1884, Margot Begemann, a neighbour's daughter and ten years" +
                    " his senior, began joining him on his painting forays; she fell in love, and he reciprocated, though less enthusiastically. They" +
                    " decided to marry, but the idea was opposed by both families, following which Margot took an overdose of strychnine. She was saved" +
                    " when Van Gogh rushed her to a nearby hospital. On 26 March 1885, his father died of a heart attack. Van Gogh painted several" +
                    " groups of still lifes in 1885. During his two - year stay in Nuenen, he completed numerous drawings and watercolours, and nearly" +
                    " 200 oil paintings.His palette consisted mainly of sombre earth tones, particularly dark brown, and showed no sign of the vivid colours" +
                    " that distinguish his later work.Considered a madman and a failure in his lifetime,Van Gogh exists in the public imagination as the" +
                    " quintessential misunderstood genius, the artist 'where discourses on madness and creativity converge'.His reputation began to grow" +
                    " in the early 20th century as elements of his painting style came to be incorporated by the Fauves and German Expressionists.He attained" +
                    " widespread critical, commercial and popular success over the ensuing decades, and is remembered as an important but tragic painter," +
                    " whose troubled personality typifies the romantic ideal of the tortured artist.",
                    Artwork1 = "https://upload.wikimedia.org/wikipedia/commons/9/94/Starry_Night_Over_the_Rhone.jpg",
                    Artwork2 = "https://upload.wikimedia.org/wikipedia/commons/thumb/7/76/Vincent_van_Gogh_-_De_slaapkamer_-_Google_Art_Project.jpg/1280px-Vincent_van_Gogh_-_De_slaapkamer_-_Google_Art_Project.jpg",
                    Artwork3 = "https://upload.wikimedia.org/wikipedia/commons/thumb/b/b4/Vincent_Willem_van_Gogh_128.jpg/175px-Vincent_Willem_van_Gogh_128.jpg"
                },

                new Artist
                {
                    ArtistID = 5,
                    Name = "Salvador Dali",
                    Picture = "https://s-media-cache-ak0.pinimg.com/originals/4b/78/e7/4b78e72934aa5cdcb6a8bff7b23b4b51.jpg",
                    BirthDate = DateTime.Parse("11-05-1904"),
                    Nationality = "Spanish",
                    ArtStyle = "Cubism, Dada, Surrealism",
                    Info = "Salvador Domingo Felipe Jacinto Dalí i Domènech was born on 11 May 1904, at the 1st floor of Carrer Monturiol, 20 (presently 6)," +
                    " in the town of Figueres, in the Empordà region, close to the French border in Catalonia, Spain. In the Summer of 1912, the family moved to the top" +
                    " floor of Carrer Monturiol 24 (presently 10). Dalí's older brother, who had also been named Salvador (born 12 October 1901), had died of" +
                    " gastroenteritis nine months earlier, on 1 August 1903. His father, Salvador Dalí i Cusí, was a middle-class lawyer and notary whose strict disciplinary" +
                    " approach was tempered by his wife, Felipa Domenech Ferrés, who encouraged her son's artistic endeavors.When he was five, Dalí was taken to his" +
                    " brother's grave and told by his parents that he was his brother's reincarnation, a concept which he came to believe. Of his brother Dalí said," +
                    " 'we resembled each other like two drops of water, but we had different reflections.' He 'was probably a first version of myself but conceived too much" +
                    " in the absolute.' Images of his long - dead brother would reappear embedded in his later works, including Portrait of My Dead Brother(1963). Dalí also" +
                    " had a sister, Anna Maria, who was three years younger. In 1949,she published a book about her brother, Dalí As Seen By His Sister. His childhood" +
                    " friends included future FC Barcelona footballers Sagibarba and Josep Samitier.During holidays at the Catalan resort of Cadaqués, the trio played" +
                    " football(soccer) together. Dalí attended drawing school.In 1916,he also discovered modern painting on a summer vacation trip to Cadaqués with the" +
                    " family of Ramon Pichot, a local artist who made regular trips to Paris. The next year, Dalí's father organized an exhibition of his charcoal drawings" +
                    " in their family home. He had his first public exhibition at the Municipal Theatre in Figueres in 1919, a site he would return to decades later. In February" +
                    " 1921, Dalí's mother died of breast cancer. Dalí was 16 years old; he later said his mother's death 'was the greatest blow I had experienced in my life." +
                    " I worshipped her... I could not resign myself to the loss of a being on whom I counted to make invisible the unavoidable blemishes of my soul.' " +
                    " After her death, Dalí's father married his deceased wife's sister. Dalí did not resent this marriage, because he had a great love and respect for " +
                    " his aunt. ",
                    Artwork1 = "https://upload.wikimedia.org/wikipedia/en/4/43/Dali_Elephants.jpg",
                    Artwork2 = "http://www.dalipaintings.net/images/paintings/dream-caused-by-the-flight-of-a-bee.jpg",
                    Artwork3 = "http://www.dalipaintings.net/images/paintings/swans-reflecting-elephants.jpg",
                },

                new Artist
                {
                    ArtistID = 6,
                    Name = "Andy Warhol",
                    Picture = "https://upload.wikimedia.org/wikipedia/commons/2/2b/Andy_Warhol_by_Jack_Mitchell.jpg",
                    BirthDate = DateTime.Parse("06-08-1928"),
                    Nationality = "American",
                    ArtStyle = "Pop art",
                    Info = "Warhol was born on August 6, 1928 in Pittsburgh, Pennsylvania. He was the fourth child of Ondrej Warhola (Americanized as Andrew Warhola, Sr.," +
                    " 1889–1942) and Julia (née Zavacká, 1892–1972), whose first child was born in their homeland and died before their move to the U.S. His parents" +
                    " were working-class Lemko emigrants from Mikó(now called Miková), located in today's northeastern Slovakia, part of the former Austro-Hungarian" +
                    " Empire. Warhol's father emigrated to the United States in 1914, and his mother joined him in 1921, after the death of Warhol's grandparents. Warhol's" +
                    "father worked in a coal mine.The family lived at 55 Beelen Street and later at 3252 Dawson Street in the Oakland neighborhood of Pittsburgh. The family" +
                    " was Byzantine Catholic and attended St.John Chrysostom Byzantine Catholic Church.Andy Warhol had two older brothers—Pavol(Paul), the oldest, was born" +
                    " before the family emigrated; Ján was born in Pittsburgh.Pavol's son, James Warhola, became a successful children's book illustrator.In third grade, Warhol" +
                    " had Sydenham's chorea (also known as St. Vitus' Dance), the nervous system disease that causes involuntary movements of the extremities, which is believed" +
                    " to be a complication of scarlet fever which causes skin pigmentation blotchiness. He became a hypochondriac, developing a fear of hospitals and doctors. " +
                    " Often bedridden as a child, he became an outcast at school and bonded with his mother. At times when he was confined to bed, he drew, listened to the" +
                    " radio and collected pictures of movie stars around his bed.Warhol later described this period as very important in the development of his personality," +
                    " skill-set and preferences.When Warhol was 13, his father died in an accident. As a teenager, Warhol graduated from Schenley High School in 1945." +
                    " After graduating from high school, his intentions were to study art education at the University of Pittsburgh in the hope of becoming an art teacher," +
                    " but his plans changed and he enrolled in the Carnegie Institute of Technology in Pittsburgh, where he studied commercial art.During his time there, Warhol" +
                    " joined the campus Modern Dance Club and Beaux Arts Society. He also served as art director of the student art magazine, Cano, illustrating a cover" +
                    " in 1948 and a full-page interior illustration in 1949. These are believed to be his first two published artworks. Warhol earned a Bachelor" +
                    " of Fine Arts in pictorial design in 1949. Later that year, he moved to New York City and began a career in magazine illustration and advertising.",
                    Artwork1 = "https://upload.wikimedia.org/wikipedia/en/thumb/1/1f/Campbells_Soup_Cans_MOMA.jpg/300px-Campbells_Soup_Cans_MOMA.jpg",
                    Artwork2 = "https://vmfa.museum/collections/wp-content/uploads/sites/9/2013/12/Warhol_85_453_v1_KW_200909_XL-878x1024.jpg",
                    Artwork3 = "https://cdn.kastatic.org/ka-perseus-images/329f84364bd08b80515b71fa830da2d2b6802c0c.jpg",
                },

                new Artist
                {
                    ArtistID = 7,
                    Name = "Michelangelo",
                    Picture = "https://upload.wikimedia.org/wikipedia/commons/5/5e/Miguel_%C3%81ngel,_por_Daniele_da_Volterra_(detalle).jpg",
                    BirthDate = DateTime.Parse("06-03-1475"),
                    Nationality = "Italian",
                    ArtStyle = "High Renaissance",
                    Info = "As a young boy, Michelangelo was sent to Florence to study grammar under the Humanist Francesco da Urbino. The young artist, however," +
                    " showed no interest in his schooling, preferring to copy paintings from churches and seek the company of painters. The city of Florence was at that time" +
                    " the greatest centre of the arts and learning in Italy. Art was sponsored by the Signoria(the town council), by the merchant guilds and by wealthy" +
                    " patrons such as the Medici and their banking associates. The Renaissance, a renewal of Classical scholarship and the arts, had its first flowering" +
                    " in Florence. In the early 15th century, the architect Filippo Brunelleschi had studied the remains of Classical buildings in Rome and created two" +
                    " churches, San Lorenzo's and Santo Spirito, which embodied the Classical precepts. The sculptor Lorenzo Ghiberti had laboured for fifty years to create" +
                    " the bronze doors of the Baptistry, which Michelangelo was to describe as 'The Gates of Paradise'. The exterior niches of the Church of Orsanmichele" +
                    " contained a gallery of works by the most acclaimed sculptors of Florence – Donatello, Ghiberti, Andrea del Verrocchio, and Nanni di Banco. The interiors" +
                    " of the older churches were covered with frescos (mostly in Late Medieval, but also in the Early Renaissance style), begun by Giotto and continued by" +
                    " Masaccio in the Brancacci Chapel – both of whose works Michelangelo studied and copied in drawings. During Michelangelo's childhood, a team of painters" +
                    " had been called from Florence to the Vatican, in order to decorate the walls of the Sistine Chapel.Among them was Domenico Ghirlandaio, a master in fresco" +
                    " painting, perspective, figure drawing, and portraiture who had the largest workshop in Florence at that period. In 1488, at the age of 13," +
                    " Michelangelo was apprenticed to Ghirlandaio. The next year,his father persuaded Ghirlandaio to pay Michelangelo as an artist, which was rare for" +
                    " someone of fourteen. When in 1489, Lorenzo de' Medici, de facto ruler of Florence, asked Ghirlandaio for his two best pupils, Ghirlandaio sent" +
                    " Michelangelo and Francesco Granacci. From 1490 to 1492, Michelangelo attended the Humanist academy that the Medici had founded along Neo-Platonic lines." +
                    " At the academy, both Michelangelo's outlook and his art were subject to the influence of many of the most prominent philosophers and writers of the day," +
                    " including Marsilio Ficino, Pico della Mirandola and Poliziano. At this time, Michelangelo sculpted the reliefs Madonna of the Steps(1490–1492) and Battle" +
                    " of the Centaurs(1491–1492). The latter was based on a theme suggested by Poliziano and was commissioned by Lorenzo de Medici. Michelangelo worked" +
                    " for a time with the sculptor Bertoldo di Giovanni.When he was seventeen, another pupil, Pietro Torrigiano, struck him on the nose, causing the disfigurement" +
                    " that is conspicuous in all the portraits of Michelangelo.",
                    Artwork1 = "https://upload.wikimedia.org/wikipedia/commons/b/b4/Michelangelo_-_Creation_of_Adam.jpg",
                    Artwork2 = "http://s.hswstatic.com/gif/michelangelo-sculptures-13.jpg",
                    Artwork3 = "http://www.italianrenaissance.org/wp-content/uploads/2012/07/Michelangelo-pieta.jpg",
                },

                new Artist
                {
                    ArtistID = 8,
                    Name = "Claude Monet",
                    Picture = "http://www.notesontheroad.com/images/stories/yings_links/Birthdays/Monet/claude-monet.jpg",
                    BirthDate = DateTime.Parse("14-11-1840"),
                    Nationality = "French",
                    ArtStyle = "Impressionism",
                    Info = "Monet has been described as 'the driving force behind Impressionism'. Crucial to the art of the Impressionist painters was the understanding of" +
                    " the effects of light on the local colour of objects, and the effects of the juxtaposition of colours with each other. Monet's long career as a painter" +
                    " was spent in the pursuit of this aim. In 1856, his chance meeting with Eugene Boudin, a painter of small beach scenes, opened his eyes to the possibility of" +
                    " plein - air painting.From that time, with a short interruption for military service, he dedicated himself to searching for new and improved methods of" +
                    " painterly expression.To this end, as a young man, he visited the Paris Salon and familiarised himself with the works of older painters, and made friends with" +
                    " other young artists. The five years that he spent at Argenteuil, spending much time on the River Seine in a little floating studio, were formative in his" +
                    " study of the effects of light and reflections.He began to think in terms of colours and shapes rather than scenes and objects.He used bright colours in dabs" +
                    " and dashes and squiggles of paint.Having rejected the academic teachings of Gleyre's studio, he freed himself from theory, saying 'I like to paint as a bird" +
                    " sings.' In 1877 a series of paintings at St - Lazare Station had Monet looking at smoke and steam and the way that they affected colour and visibility," +
                    " being sometimes opaque and sometimes translucent.He was to further use this study in the painting of the effects of mist and rain on the landscape." +
                    " The study of the effects of atmosphere were to evolve into a number of series of paintings in which Monet repeatedly painted the same subject in different" +
                    " lights, at different hours of the day, and through the changes of weather and season.This process began in the 1880s and continued until the end of his life" +
                    " in 1926. His first series exhibited as such was of Haystacks, painted from different points of view and at different times of the day.Fifteen of the paintings" +
                    " were exhibited at the Galerie Durand - Ruel in 1891.In 1892 he produced what is probably his best - known series, twenty - six views of Rouen Cathedral." +
                    " In these paintings Monet broke with painterly traditions by cropping the subject so that only a portion of the facade is seen on the canvas.The paintings" +
                    " do not focus on the grand Medieval building, but on the play of light and shade across its surface, transforming the solid masonry.",
                    Artwork1 = "http://totallyhistory.com/wp-content/uploads/2012/10/Impression-Sunrise-by-Monet.jpg",
                    Artwork2 = "http://mystudios.com/art/impress/monet/monet-woman-with-parasol-1875.jpg",
                    Artwork3 = "http://www.larousse.fr/encyclopedie/data/images/1311059-Claude_Monet_les_Coquelicots.jpg",
                }

            );

            context.Artworks.AddOrUpdate(i => i.ArtworkID,
                new Artwork
                {
                    ArtworkID = 1,
                    ArtistID = 1,
                    Name = "Guernica",
                    ArtistName = "Pablo Picasso",
                    Picture = "https://upload.wikimedia.org/wikipedia/en/7/74/PicassoGuernica.jpg",
                },

                new Artwork
                {
                    ArtworkID = 2,
                    ArtistID = 1,
                    Name = "The Weeping Woman",
                    ArtistName = "Pablo Picasso",
                    Picture = "http://totallyhistory.com/wp-content/uploads/2012/12/pablo-picasso-weeping-woman.jpg",
                },

                new Artwork
                {
                    ArtworkID = 3,
                    ArtistID = 1,
                    Name = "Three Musicians",
                    ArtistName = "Pablo Picasso",
                    Picture = "http://www.pablopicasso.org/images/paintings/three-musicians.jpg",
                },

                new Artwork
                {
                    ArtworkID = 4,
                    ArtistID = 1,
                    Name = "The Old Guitarist",
                    ArtistName = "Pablo Picasso",
                    Picture = "http://cedareducation.org.uk/wp-content/uploads/2014/04/old-guitarist.png",
                },

                new Artwork
                {
                    ArtworkID = 5,
                    ArtistID = 2,
                    Name = "Medusa",
                    ArtistName = "Leonardo Da Vinci",
                    Picture = "http://3.bp.blogspot.com/_GzQnzaF4k-o/RlXYqQDCXgI/AAAAAAAACvc/tadSalAh6F4/s400/medusa+in+uffizi++use+this.bmp",
                },

                new Artwork
                {
                    ArtworkID = 6,
                    ArtistID = 2,
                    Name = "Annunciation",
                    ArtistName = "Leonardo Da Vinci",
                    Picture = "http://static.femina.hu/ezo/melyik_angyal_vigyaz_rad_oselemed_elarulja/gabriel.jpg",
                },

                new Artwork
                {
                    ArtworkID = 7,
                    ArtistID = 2,
                    Name = "Lady with an Ermine",
                    ArtistName = "Leonardo Da Vinci",
                    Picture = "http://www.lairweb.org.nz/leonardo/ermine.jpg",
                },

                 new Artwork
                 {
                     ArtworkID = 8,
                     ArtistID = 2,
                     Name = "St John the Baptist",
                     ArtistName = "Leonardo Da Vinci",
                     Picture = "https://upload.wikimedia.org/wikipedia/commons/f/fc/St_John_the_baptist_-_Leonardo_Da_Vinci.jpg",
                 },

                new Artwork
                {
                    ArtworkID = 9,
                    ArtistID = 3,
                    Name = "The Black Place",
                    ArtistName = "Georgia O'Keeffe",
                    Picture = "http://www.metmuseum.org/toah/images/hb/hb_59.204.1.jpg",
                },

                new Artwork
                {
                    ArtworkID = 10,
                    ArtistID = 3,
                    Name = "Cow's Skull with Calico Roses",
                    ArtistName = "Georgia O'Keeffe",
                    Picture = "http://www.artic.edu/aic/collections/citi/images/standard/WebLarge/WebImg_000313/131385_3738269.jpg",
                },

                new Artwork
                {
                    ArtworkID = 11,
                    ArtistID = 4,
                    Name = "The Potato Eaters",
                    ArtistName = "Vincent Van Gogh",
                    Picture = "https://upload.wikimedia.org/wikipedia/commons/thumb/b/b1/Van-willem-vincent-gogh-die-kartoffelesser-03850.jpg/300px-Van-willem-vincent-gogh-die-kartoffelesser-03850.jpg",
                },

                new Artwork
                {
                    ArtworkID = 12,
                    ArtistID = 4,
                    Name = "House at Auvers",
                    ArtistName = "Vincent Van Gogh",
                    Picture = "http://www.vangogh.net/images/paintings/houses-at-auvers.jpg",
                },

                new Artwork
                {
                    ArtworkID = 13,
                    ArtistID = 5,
                    Name = "Metamorphosis of Narcissus",
                    ArtistName = "Salvador Dali",
                    Picture = "https://upload.wikimedia.org/wikipedia/en/2/21/Metamorphosis_of_Narcissus.jpg",
                },

                new Artwork
                {
                    ArtworkID = 14,
                    ArtistID = 5,
                    Name = "The Face of War",
                    ArtistName = "Salvador Dali",
                    Picture = "https://upload.wikimedia.org/wikipedia/en/a/a9/The_Face_of_War.jpg",
                },

                new Artwork
                {
                    ArtworkID = 15,
                    ArtistID = 6,
                    Name = "Camouflage Self-Portrait",
                    ArtistName = "Andy Warhol",
                    Picture = "https://upload.wikimedia.org/wikipedia/en/0/06/Andywarhol.jpg",
                },

                new Artwork
                {
                    ArtworkID = 16,
                    ArtistID = 6,
                    Name = "Men in her life",
                    ArtistName = "Andy Warhol",
                    Picture = "https://upload.wikimedia.org/wikipedia/en/5/55/Men_in_her_life_by_Andy_Warhol_(1962).jpg",
                },

                new Artwork
                {
                    ArtworkID = 17,
                    ArtistID = 7,
                    Name = "Pieta",
                    ArtistName = "Michelangelo",
                    Picture = "https://upload.wikimedia.org/wikipedia/commons/thumb/f/f1/Michelangelo's_Piet%C3%A0,_St_Peter's_Basilica_(1498%E2%80%9399).jpg/275px-Michelangelo's_Piet%C3%A0,_St_Peter's_Basilica_(1498%E2%80%9399).jpg",
                },

                new Artwork
                {
                    ArtworkID = 18,
                    ArtistID = 7,
                    Name = "The Creation of Adam",
                    ArtistName = "Michelangelo",
                    Picture = "https://upload.wikimedia.org/wikipedia/commons/b/b4/Michelangelo_-_Creation_of_Adam.jpg",
                },

                new Artwork
                {
                    ArtworkID = 19,
                    ArtistID = 8,
                    Name = "The Magpie",
                    ArtistName = "Claude Monet",
                    Picture = "http://www.fineartprintsondemand.com/artists/monet/magpie-400.jpg",
                },

                new Artwork
                {
                    ArtworkID = 20,
                    ArtistID = 8,
                    Name = "Beach in Pourville",
                    ArtistName = "Claude Monet",
                    Picture = "http://totallyhistory.com/wp-content/uploads/2012/12/Beach_at_Pourville_monet.jpg",
                }

            );
        }
    }
}