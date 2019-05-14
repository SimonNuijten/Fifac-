using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        const string SAVE_LOCATION = "saved-game.json";

        public Form1()
        {
            InitializeComponent();
        }

        public void givedata()
        {
            
        }

        public void save()
        {
            Save save = new Save();
            save.name = Program.username;
            save.amount = Program.amount;

            string saveJson = JsonConvert.SerializeObject(save);
            // Write the saved game to a text file
            File.WriteAllText(SAVE_LOCATION, saveJson);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;

            string team = "team";
            string response;
            
            var url = string.Format("http://simonnuijten.nl/teams.php?name=team", team);
            using (var webClient = new WebClient())
            {
                response = webClient.DownloadString(url);

                Teams teams = JsonConvert.DeserializeObject<Teams>(response);

                //Teams teams = JsonConvert.DeserializeObject<Teams>(response);

                //string[] splitScores = response.Trim().Split('\n');

                for (int i = 0; i < teams.names.Count; i++)
                {
                    comboBox1.Items.Add(teams.names[i].ToString());
                }

            }






            /*
            //string username = "";
            var team = "team";
            var id = "id";
            string urlAddress = "http://simonnuijten.nl/page.php";
            

            using (WebClient client = new WebClient())
            {
                NameValueCollection postData = new NameValueCollection()
       {
              { "team", team },  //order: {"parameter name", "parameter value"}
              { "id", id }
       };


                // this string contains the webpage's source
                string pagesource = client.DownloadString(urlAddress);

                //phpdataLabel.Text = pagesource;
                listBox1.Items.Add(pagesource);
            }


            */


        }

        private void button1_Click(object sender, EventArgs e)
        {
            save();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            usernameLabel.Text = "Welkom " + Program.username;
            amountLabel.Text = "Uw saldo is : " + Program.amount;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "25" && Program.amount < 1)
            {
                Program.amount += 25;
            }
        }
    }
}
