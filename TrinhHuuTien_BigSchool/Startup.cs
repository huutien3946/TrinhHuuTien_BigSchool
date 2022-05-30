using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TrinhHuuTien_BigSchool.Startup))]
namespace TrinhHuuTien_BigSchool
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
