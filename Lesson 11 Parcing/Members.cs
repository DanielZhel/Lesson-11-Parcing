using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_11_Parcing
{
   
    public class Members
    {
        public string name { get; set; }
        public int age { get; set; }
        public string secretIdentity { get; set; }
        public List<string> powers { get; set; }

        public Members(string name, int age, string secretIdentity, List<string> powers)
        {
            this.name = name;
            this.age = age;
            this.secretIdentity = secretIdentity;
            this.powers = powers;
          
        }

        public Members()
        {

        }
    }
}
