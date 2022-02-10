using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trackerLibrary
{
   public class TeamModel
    {
        /// <summary>
        /// List of teammembers which gets initiliazed
        /// </summary>
        public List<PersonModel> TeamMembers { get; set; } = new List<PersonModel>();
        public string TeamName { get; set; }

           
    }
}
