using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Models
{
    internal class ReviewModel
    {
        [JsonProperty("id_user")]
        public int IdUser { get; set; }
        public string Login { get; set; }
        public string Text { get; set; }
        public int Grade { get; set; }
    }
}
