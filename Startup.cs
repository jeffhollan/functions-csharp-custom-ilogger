using Microsoft.Azure.Functions.Extensions.DependencyInjection;

[assembly:FunctionsStartup(typeof(Hollan.Functions.Startup))]

namespace Hollan.Functions {
    public class Startup : FunctionsStartup
    {
        public override void Configure(IFunctionsHostBuilder builder)
        {
            
        }
    }
}