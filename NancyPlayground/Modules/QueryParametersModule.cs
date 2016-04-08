using Nancy;

namespace NancyPlayground.Modules
{
    public class QueryParametersModule : NancyModule
    {
        public QueryParametersModule()
        {
            Get["/parameters/query"] = parameters =>
                {
                    var param1 = Request.Query["param1"];
                    var param2 = Request.Query["param2"];
                    var param3 = Request.Query["param3"];

                    return "Query Parameters"
                           + ", param1: " + param1
                           + ", param2: " + param2
                           + ", param3: " + param3;
                };
        }
    }
}