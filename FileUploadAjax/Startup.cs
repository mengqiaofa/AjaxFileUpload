using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FileUploadAjax.Startup))]
namespace FileUploadAjax
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
