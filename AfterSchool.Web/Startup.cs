using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AfterSchool.Web.Startup))]
namespace AfterSchool.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
