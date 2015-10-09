using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Nancy;

namespace NancyPlayground
{
    public class HelloModule : NancyModule
    {
        public HelloModule()
        {
            Get["/hello"] = parameters => "Hello World";
        }
    }
}