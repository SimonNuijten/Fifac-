using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Bet
    {
        public int Amount;
        public int Team;
        public Guy Bettor;
        public string GetDescription()
        {
            if (Amount == 0)
            {
                string description = Bettor.Name + " heeft geen weddenschap geplaatst.";
                return description;
            }
            else
            {
                string description = Bettor.Name + " Wedt $" + this.Amount + " op Team " + (this.Team + 1);
                return description;
            }
        }
        public int PayOut(int Winner)
        {
            if (Winner == this.Team)
            {
                return this.Amount * 2;
            }
            else
            {
                return -1 * this.Amount;
            }
        }




    }
}
