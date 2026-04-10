using System;
using System.IO;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using SlackAPI;

namespace ConsoleApplication1
{
    //internal class Program
    //{
    //    public static async Task Main(string[] args)
    //    {
    //        const string
    //            TOKEN =
    //                "xoxb-3487626729126-3506907032193-QPybb9Nt5O6f31SSF6B9APPR"; // token from last step in section above
    //        var slackClient = new SlackTaskClient(TOKEN);

    //        var response = await slackClient.PostMessageAsync("#general", "hello world");
    //        Console.WriteLine("Done?");
    //    }
    //}
    public class program
    {
        public HttpWebRequest CreateSOAPWebRequest()
        {
            //Making Web Request    
            HttpWebRequest Req = (HttpWebRequest)WebRequest.Create(@"http://localhost/Employee.asmx");
            //SOAPAction    
            Req.Headers.Add(@"SOAPAction:http://tempuri.org/Addition");
            //Content_type    
            Req.ContentType = "text/xml;charset=\"utf-8\"";
            Req.Accept = "text/xml";
            //HTTP method    
            Req.Method = "POST";
            //return HttpWebRequest    
            return Req;
        }

    }
   
}