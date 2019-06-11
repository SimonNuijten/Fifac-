using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class userCreator
    {
        public void random()
        {
            Random random = new Random();
            int User = random.Next(1, 11);
            if(User == 1)
            {
                Program.username = "Ronald";
            }
            if (User == 2)
            {
                Program.username = "Tim";
            }
            if (User == 3)
            {
                Program.username = "Elton";
            }
            if (User == 4)
            {
                Program.username = "Kim";
            }
            if (User == 5)
            {
                Program.username = "Sophie";
            }
            if (User == 6)
            {
                Program.username = "Eva";
            }
            if (User == 7)
            {
                Program.username = "Mike";
            }
            if (User == 8)
            {
                Program.username = "Mark";
            }
            if (User == 9)
            {
                Program.username = "Fleur";
            }
            if (User == 10)
            {
                Program.username = "Yousli";
            }

        }
    }
}
