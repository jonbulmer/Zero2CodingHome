using Microsoft.Owin;
using Owin;

namespace TrainDemoDemo.UI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
