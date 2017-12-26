using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace upvoteNotification
{
    class Posts
    {
        static string Source(string apiUrl)
        {
            try
            {
                HttpWebRequest myRequest = (HttpWebRequest)WebRequest.Create(apiUrl);
                myRequest.Headers.Add(HttpRequestHeader.AcceptEncoding, "gzip,deflate");
                myRequest.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;
                myRequest.Method = "GET";
                myRequest.UserAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/535.2 (KHTML, like Gecko) Chrome/15.0.874.121 Safari/535.2";
                myRequest.Timeout = 5000;
                WebResponse myResponse = myRequest.GetResponse();
                StreamReader sr = new StreamReader(myResponse.GetResponseStream(), Encoding.UTF8);
                string result = sr.ReadToEnd();
                sr.Close();
                myResponse.Close();
                return result;
            }
            catch (Exception ex) { return ex.Message; }

        }
        public static content getContent(string url)
        {
            try
            {
                string permLink = url.Split('/')[url.Split('/').Length - 1];
                string src = Source("https://api.steemjs.com/get_content?author=" + url.Split('/')[url.Split('/').Length - 2].Replace("@", "").Trim() + "&permlink=" + permLink);
                JObject res = JObject.Parse(src); //it will parse our api page
                content co = new content();
                co.upvoteCount = (int)res["net_votes"]; // get value from the information we'have accessed through the steam API
                co.totalSbd = double.Parse(res["pending_payout_value"].ToString().Replace("SBD", "").Trim());
                co.Url = url;
                return co;
            }
            catch { }return new content();
        }
        
    }
}
