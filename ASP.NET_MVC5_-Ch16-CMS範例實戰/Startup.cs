using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ASP.NET_MVC5__Ch16_CMS範例實戰.Startup))]
namespace ASP.NET_MVC5__Ch16_CMS範例實戰
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
