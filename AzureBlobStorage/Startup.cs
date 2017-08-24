using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AzureBlobStorage.Startup))]
namespace AzureBlobStorage
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
