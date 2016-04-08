using Nancy;

namespace NancyPlayground.Modules
{
    public class RouteParametersModule : NancyModule
    {
        public RouteParametersModule()
        {
            Get["/parameters/route/{thing}/{thing2}/{value}"] = parameters => "Route Parameters"
                                                                      + ", thing: "  + parameters.thing
                                                                      + ", thing2: " + parameters.thing2
                                                                      + ", value: "  + parameters.value;
        }
    }
}