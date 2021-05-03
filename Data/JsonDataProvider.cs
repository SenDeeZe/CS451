using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json;
using System.Collections;
using Newtonsoft.Json;

namespace Razor1.Data
{
    public class JsonDataProvider<T> : IJsonDataProvider<T>
    {

        public JsonDataProvider(IWebHostEnvironment webHostEnvironment)
        {
            WebHostEnvironment = webHostEnvironment;
        }

        public IWebHostEnvironment WebHostEnvironment { get; }

        private string JsonFileName
        {
            get { return Path.Combine(WebHostEnvironment.WebRootPath, "testimonials.json"); }
        }

        public List<T> GetData()
        {
            List<T> list = JsonConvert.DeserializeObject<List<T>>(File.ReadAllText(JsonFileName));
            return list;
        }
    }
}
