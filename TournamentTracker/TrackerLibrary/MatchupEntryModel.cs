using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    internal class MatchupEntryModel
    { /// <summary>
    /// 1 team in the matchup
    /// </summary>
        public TeamModel TeamCompeting { get; set; }
/// <summary>
/// score
/// </summary>
        public double Score { get; set; }
        /// <summary>
        /// rappresenta l'ultima sfida che il team ha vinto
        /// </summary>
        public MatchupModel ParentMatchup { get; set;  }

        public MatchupEntryModel(double initialscore) {
            Console.WriteLine("ciao");
        }
    }
}
