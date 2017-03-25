using System;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Text.RegularExpressions;
using System.Xml;

using Newtonsoft.Json.Linq;

namespace Podcaster.Console
{
    class Program
    {
        private static void GetValue(string urlToXml)
        {
            XmlReader reader = XmlReader.Create(urlToXml);
            SyndicationFeed feed = SyndicationFeed.Load(reader);
            reader.Close();
            SyndicationItem item = feed.Items.ElementAt(3);

            System.Console.WriteLine(item.Id);
            System.Console.WriteLine();

            System.Console.WriteLine(item.Authors);
            System.Console.WriteLine();

            System.Console.WriteLine(item.SourceFeed.Generator);
            System.Console.WriteLine();

            System.Console.WriteLine(item.LastUpdatedTime.Date);
            System.Console.WriteLine();

            /* System.Console.WriteLine(item.Links.Count);
             foreach (var i in item.Links)
             {
                 System.Console.WriteLine(i.);
             }*/

            /* ParseLinkToFeed(item.Id);
             System.Console.WriteLine();
             System.Console.WriteLine(item.Title.Text);
             System.Console.WriteLine();*/

            /*System.Console.WriteLine(item.Id);*/

            /*var summary = item.Summary.Text;
            System.Console.WriteLine(summary);*/
        }

        static void Main(string[] args)
        {
            var url = @"https://itunes.apple.com/us/rss/toppodcasts/limit=10/explicit=true/";

            /*var json = new WebClient().DownloadString(url + "json");*/
            string urlToXml = url + "xml";

            MyMethod(urlToXml);

            // GetValue(urlToXml);

            /*JToken node = JToken.Parse(json);

            WalkNode(node, n =>
            {
                JToken token = n["feed"];
                if (token != null && token.Type == JTokenType.String)
                {
                    string title = token.Value<string>();
                    System.Console.WriteLine(title);
                }
            });*/
        }

        static void MyMethod(string url)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(url);
            var namespaceManager = new XmlNamespaceManager(doc.NameTable);
            namespaceManager.AddNamespace("itunes", "http://www.w3.org/2005/Atom");
            namespaceManager.AddNamespace("im", "http://itunes.apple.com/rss");

            XmlNodeList items = doc.SelectNodes("//itunes:entry", namespaceManager);
            foreach (XmlNode item in items)
            {
                var price = item.SelectSingleNode("im:price", namespaceManager);
                var releaseDate = item.SelectSingleNode("im:releaseDate", namespaceManager);

                if (price != null)
                {
                    System.Console.WriteLine(price.Attributes["amount"].InnerText);
                }

                if (releaseDate != null)
                {
                    System.Console.WriteLine(releaseDate.Attributes["label"].InnerText);
                }
            }
        }

        static void ParseLinkToFeed(string url)
        {
            var match = Regex.Match(url, @"(\d+)");
            System.Console.WriteLine(match);
        }

        /*static void WalkNode(JToken node, Action<JObject> action)
        {
            if (node.Type == JTokenType.Object)
            {
                action((JObject)node);

                foreach (JProperty child in node.Children<JProperty>())
                {
                    WalkNode(child.Value, action);
                }
            }
            else if (node.Type == JTokenType.Array)
            {
                foreach (JToken child in node.Children())
                {
                    WalkNode(child, action);
                }
            }
        }*/
    }
}