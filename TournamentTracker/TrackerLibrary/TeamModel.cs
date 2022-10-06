using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    internal class TeamModel
    {
        public List<Person> TeamMember { get; set; } = new List<Person>();
        public String TeamName { get; set; }

    }
}
