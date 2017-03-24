using System;
using System.Linq;
using System.Net;

using Newtonsoft.Json.Linq;

namespace Podcaster.Services
{
    public class JsonFeedsReader
    {
        public void MyMethod(string url)
        {
            var json = new WebClient().DownloadString(url);
            var obj = JObject.Parse(json);
            var query = from JObject ev in obj.PropertyValues()
                        from JObject evid in ev.PropertyValues()
                        select
                        new
                            {
                                Description = (string)evid["Description"],
                                OutcomeDateTime = Convert.ToDateTime((string)evid["OutcomeDateTime"]),
                                Teams =
                                from JObject comps in evid["Competitors"]["Competitors"] select (string)comps["Team"],
                            };
        }
    }
}