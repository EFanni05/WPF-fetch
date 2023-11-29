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

        public People(int id, string name, int age, string gender, string hobby)
        {
            Id = id;
            Name = name;
            Age = age;
            Gender = gender;
            Hobby = hobby;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
        public string Gender { get => gender; set => gender = value; }
        public string Hobby { get => hobby; set => hobby = value; }

        public override string ToString()
        {
            return $"{Id}. {Name} ({Age} , {Gender})\nHobby: {Hobby}";
        }
    }
}
