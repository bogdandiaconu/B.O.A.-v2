using Microsoft.Owin;
using Owin;


[assembly: OwinStartupAttribute(typeof(Proiect_BD.Startup))]
namespace Proiect_BD
{
    public partial class Startup {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
      
    }
}
