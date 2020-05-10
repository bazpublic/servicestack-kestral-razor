using Funq;
using ServiceStack;
using ServiceStack.Api.OpenApi;
using ServiceStack.Razor;
using Static.Service;

namespace Console.Razor.Example
{
    public class ExampleApi : AppSelfHostBase
    {
        public ExampleApi() : base("Example", typeof(StaticService).Assembly)
        {
        }

        public override void Configure(Container container)
        {
            Plugins.Add(new RazorFormat());
            Plugins.Add(new OpenApiFeature());
        }
    }
}
