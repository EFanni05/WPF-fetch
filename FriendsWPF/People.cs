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
        private string name;
        private int age;
        private string gender;
        private string hobby;

        public People(int id, string name, int age, string gender, string hobby)
        {
            this.id = id;
            this.name = name;
            this.age = age;
            this.gender = gender;
            this.hobby = hobby;
        }

        public override string ToString()
        {
            return $"{id}. {name} ({age} , {gender})\tHobby: {hobby}";
        }
    }
}
