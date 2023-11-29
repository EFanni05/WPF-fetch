using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FetchWPF
{
    public class People
    {
        [JsonProperty("id")]
        private int id;
        [JsonProperty ("names")]
        private string name;
        [JsonProperty("age")]
        private int age;
        [JsonProperty("gender")]
        private string gender;
        [JsonProperty("hobby")]
        private string hobby;

        public override string ToString()
        {
            return $"{id}. {name} ({age} , {gender})\nHobby: {hobby}";
        }
    }
}
