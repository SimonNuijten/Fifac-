using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class FetchScores
    {

        public string team1 { get; set; }

        public string team2 { get; set; }

        public string score1 { get; set; }

        public string score2 { get; set; }



        public override string ToString()

        {

            return string.Format(" {0} - {1})", this.team1, this.team2);

        }

        public List<string> scores = new List<string>();

        
    }
}
