using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;

namespace apiintermedio.api.Services
{
    public class ConsumoApi
    {
        
        public string GetApiHttpGet(string path)
        {
            var datos = "";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(path);
            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                datos = reader.ReadToEnd();
            }
            return datos;
        }

        public string GetApiHttpGet(string path, string token)
        {
            var datos = "";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(path);
            request.Headers.Add("Authorization", "Bearer " + token);
            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                datos = reader.ReadToEnd();
            }
            return datos;
        }

        public string ConsumePostNoToken(string path, string body) 
        {
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
            //ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
            System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

            WebRequest request = WebRequest.Create(path);
            request.Method = "POST";
            request.ContentType = "application/json; charset=UTF-8";

            using (StreamWriter requestSW = new StreamWriter(request.GetRequestStream()))
            {
                requestSW.Write(body);
                requestSW.Flush();
                requestSW.Close();
            }

            WebResponse response = request.GetResponse();

            string result;
            using (StreamReader respondeSR = new StreamReader(response.GetResponseStream()))
            {
                result = respondeSR.ReadToEnd();
            }
            return result;
        }
        public string GetApiHttpPost(string path, string valor)
        {
            string url = path;
            string postdata = valor;
            byte[] data = Encoding.UTF8.GetBytes(postdata);

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);

            request.KeepAlive = false;
            request.ProtocolVersion = HttpVersion.Version10;
            request.ContentType = "text/json";
            request.Method = "POST";
            // turn our request string into a byte stream
            byte[] postBytes = Encoding.UTF8.GetBytes(postdata);

            // this is important - make sure you specify type this way
            //request.ContentType = "application/x-www-form-urlencoded";
            request.ContentType = "application/json; charset=UTF-8";
            request.Accept = "*/*";
            request.ContentLength = postBytes.Length;
            //request.CookieContainer = Cookies;
            //request.UserAgent = currentUserAgent;
            Stream requestStream = request.GetRequestStream();

            // now send it
            requestStream.Write(postBytes, 0, postBytes.Length);
            requestStream.Close();

            // grab te response and print it out to the console along with the status code
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            string result;
            using (StreamReader rdr = new StreamReader(response.GetResponseStream()))
            {
                result = rdr.ReadToEnd();
            }
            return result;
        }

        public string GetApiHttpPost(string path, string valor, string token)
        {
            string url = path;
            string postdata = valor;
            byte[] data = Encoding.UTF8.GetBytes(postdata);

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Headers.Add("Authorization", "Bearer " + token);
            request.KeepAlive = false;
            request.ProtocolVersion = HttpVersion.Version10;
            request.Method = "POST";
            // turn our request string into a byte stream
            byte[] postBytes = Encoding.UTF8.GetBytes(postdata);

            // this is important - make sure you specify type this way
            request.ContentType = "application/json; charset=UTF-8";
            request.Accept = "application/json";
            request.ContentLength = postBytes.Length;
            //request.CookieContainer = Cookies;
            //request.UserAgent = currentUserAgent;
            Stream requestStream = request.GetRequestStream();

            // now send it
            requestStream.Write(postBytes, 0, postBytes.Length);
            requestStream.Close();

            // grab te response and print it out to the console along with the status code
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            string result;
            using (StreamReader rdr = new StreamReader(response.GetResponseStream()))
            {
                result = rdr.ReadToEnd();
            }
            return result;
        }

        public string GetApiHttpPut(string path, string valor, string token)
        {
            string url = path;
            string postdata = valor;
            byte[] data = Encoding.UTF8.GetBytes(postdata);

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Headers.Add("Authorization", "Bearer " + token);
            request.KeepAlive = false;
            request.ProtocolVersion = HttpVersion.Version10;
            request.Method = "PUT";
            // turn our request string into a byte stream
            byte[] postBytes = Encoding.UTF8.GetBytes(postdata);

            // this is important - make sure you specify type this way
            request.ContentType = "application/json; charset=UTF-8";
            request.Accept = "application/json";
            request.ContentLength = postBytes.Length;
            //request.CookieContainer = Cookies;
            //request.UserAgent = currentUserAgent;
            Stream requestStream = request.GetRequestStream();

            // now send it
            requestStream.Write(postBytes, 0, postBytes.Length);
            requestStream.Close();

            // grab te response and print it out to the console along with the status code
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            string result;
            using (StreamReader rdr = new StreamReader(response.GetResponseStream()))
            {
                result = rdr.ReadToEnd();
            }
            return result;
        }

        public bool AcceptAllCertifications(object sender, System.Security.Cryptography.X509Certificates.X509Certificate certification, System.Security.Cryptography.X509Certificates.X509Chain chain, System.Net.Security.SslPolicyErrors sslPolicyErrors)
        {
            return true;
        }
    }
}