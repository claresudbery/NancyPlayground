using Nancy;

namespace NancyPlayground.Modules
{
    public class RatesQueryModule : NancyModule
    {
        public RatesQueryModule()
        {
            Get["/api/htng2014b"] = parameters => "Hello from Rates Query";
            Post["/api/htng2014b"] = parameters => "<?xml version=\"1.0\" encoding=\"UTF-8\"?>"
            + "\n<OTA_ErrorRS TimeStamp=\"2016-04-08T12:09:17.641Z\""
            + "\nVersion=\"3.000\""
            + "\nxmlns=\"http://www.opentravel.org/OTA/2003/05\""
            + "\nErrorCode=\"448xx\""
            + "\nErrorMessage=\"Request could not be processed due to an internal error.\""
            + "\nStatus=\"Unknown\""
            + "\nCorrelationID=\"a0c0cc00-73c0-49c0-a5c5-32288f32f29a\"/>";
        }
    }
}