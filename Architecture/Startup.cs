using Microsoft.Owin;
using Owin;
using Mappings;

[assembly: OwinStartupAttribute(typeof(Architecture.Startup))]
namespace Architecture
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            AutoMapperConfig.Configure();
        }
    }
}
