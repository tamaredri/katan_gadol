using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Http;
using System.Net.Http.Headers;
using System.IO;
using System.Net;
using System.Text;
using System.Diagnostics;
using Xabe.FFmpeg;


namespace KatanGadolWeb
{
    public partial class uploadePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            //IConversionResult result = Conversion.Concatenate(File.Create("converted", (int)FileMode.Create), introVideo.FileContent, storyVideo.FileContent, );
        }


        //start an application
        //Process.Start("notepad", "readme.txt");

        #region web access
        protected void Button4_Click(object sender, EventArgs e)
        {
            string strCmdText = "/C copy /b Image1.jpg + Archive.rar Image2.jpg";
            System.Diagnostics.Process.Start("CMD.exe", strCmdText);


            MyWebRequest myRequest = new MyWebRequest("http://www.google.com");
            //show the response string on the console screen.
            Debug.WriteLine(myRequest.GetResponse());
        }
        #endregion
    }
    #region web access class
    public class MyWebRequest
    {
        private WebRequest request;
        private Stream dataStream;

        private string status;

        public String Status
        {
            get
            {
                return status;
            }
            set
            {
                status = value;
            }
        }

        public MyWebRequest(string url)
        {
            // Create a request using a URL that can receive a post.

            request = WebRequest.Create(url);
        }

        public MyWebRequest(string url, string method)
            : this(url)
        {

            if (method.Equals("GET") || method.Equals("POST"))
            {
                // Set the Method property of the request to POST.
                request.Method = method;
            }
            else
            {
                throw new Exception("Invalid Method Type");
            }
        }

        public MyWebRequest(string url, string method, string data)
            : this(url, method)
        {

            // Create POST data and convert it to a byte array.
            string postData = data;
            byte[] byteArray = Encoding.UTF8.GetBytes(postData);

            // Set the ContentType property of the WebRequest.
            request.ContentType = "application/x-www-form-urlencoded";

            // Set the ContentLength property of the WebRequest.
            request.ContentLength = byteArray.Length;

            // Get the request stream.
            dataStream = request.GetRequestStream();

            // Write the data to the request stream.
            dataStream.Write(byteArray, 0, byteArray.Length);

            // Close the Stream object.
            dataStream.Close();

        }

        public string GetResponse()
        {
            // Get the original response.
            WebResponse response = request.GetResponse();

            this.Status = ((HttpWebResponse)response).StatusDescription;

            // Get the stream containing all content returned by the requested server.
            dataStream = response.GetResponseStream();

            // Open the stream using a StreamReader for easy access.
            StreamReader reader = new StreamReader(dataStream);

            // Read the content fully up to the end.
            string responseFromServer = reader.ReadToEnd();

            // Clean up the streams.
            reader.Close();
            dataStream.Close();
            response.Close();

            return responseFromServer;
        }

        #endregion
    }
}