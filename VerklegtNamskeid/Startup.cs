using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VerklegtNamskeid.Startup))]
namespace VerklegtNamskeid
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
