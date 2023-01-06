using Microsoft.Owin;
using Owin;


[assembly: OwinStartupAttribute(typeof(IndrivoFinal.Startup))]
namespace IndrivoFinal
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }

    }
}