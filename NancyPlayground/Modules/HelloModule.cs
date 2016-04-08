using Nancy;

namespace NancyPlayground.Modules
{
    public class HelloModule : NancyModule
    {
        public HelloModule()
        {
            Get["/hello"] = parameters => "Hello World";
        }
    }
}