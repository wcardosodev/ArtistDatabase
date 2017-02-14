using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ArtistDatabase.Startup))]
namespace ArtistDatabase
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
