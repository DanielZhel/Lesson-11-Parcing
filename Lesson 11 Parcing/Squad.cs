using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_11_Parcing
{
    public  class Squad
    {
        public string squadName { get; set; }
        public string homeTown { get; set; }
        public int formed {get; set; }
        public string secretBase { get; set; }
        public bool active { get; set; }
        public List<Members> members { get; set; }
        public Squad(string squadName, string homeTown, int formed, string secretBase, bool active, List<Members> members)
        {
            this.squadName = squadName;
            this.homeTown = homeTown;
            this.formed = formed;
            this.secretBase = secretBase;
            this.active = active;
            this.members = members;
            
        }
        public Squad()
        {

        }

    }
}
