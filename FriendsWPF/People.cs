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
        private int id;
        private int age;
        private string hobby;
        [JsonProperty ("names")]
        private string name;
        private string gender;

        public override string ToString()
        {
            return $"{id}. {name} ({age} , {gender})\tHobby: {hobby}";
        }
    }
}
