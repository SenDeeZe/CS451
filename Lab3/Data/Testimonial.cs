using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Razor1.Data
{
    public class Testimonial
    {
        [JsonProperty(PropertyName = "Title")]
        public string Title { set; get; }

        [JsonProperty(PropertyName = "Text")]
        public string Text { set; get; }

        [JsonProperty(PropertyName = "Image")]
        public string Image { set; get; }

        [JsonProperty(PropertyName = "Name")]
        public string Name { set; get; }

        [JsonProperty(PropertyName = "Occupation")]
        public string Occupation { set; get; }
    }
}
