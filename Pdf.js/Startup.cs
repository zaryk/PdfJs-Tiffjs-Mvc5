using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Pdf.js.Startup))]
namespace Pdf.js
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
