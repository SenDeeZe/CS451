using System;
using System.Net;
using System.IO;
using System.Collections.Generic;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            HttpListener listener = new HttpListener();
            listener.Prefixes.Add("http://localhost:8888/");
            listener.Start();
            while (true)
            {
                HttpListenerContext context = listener.GetContext();
                HttpListenerRequest request = context.Request;
                string answer = request.RawUrl.Remove(0, 1);
                HttpListenerResponse response = context.Response;
                if (File.Exists(answer))
                {
                    byte[] buffer = File.ReadAllBytes(answer);
                    response.ContentLength64 = buffer.Length;
                    Stream output = response.OutputStream;
                    output.Write(buffer, 0, buffer.Length);
                    output.Close();
                }
                else {
                    response.StatusCode = 404;
                    string responseStr = "<html><head><meta charset='utf8'></head><body>" +
                                            "<h1>Server Error " + response.StatusCode + ": Not Found</h1></body></html>";
                    byte[] buffer = System.Text.Encoding.UTF8.GetBytes(responseStr);
                    response.ContentLength64 = buffer.Length;
                    Stream output = response.OutputStream;
                    output.Write(buffer, 0, buffer.Length);
                    output.Close();
                }
                var lines = new List<String>
                {
                    DateTime.Now.ToString(),
                    request.RemoteEndPoint.ToString(),
                    answer,
                    response.StatusCode.ToString(),
                    " "
                };
                File.AppendAllLines("log.txt", lines);
            }
        }
    }
}
