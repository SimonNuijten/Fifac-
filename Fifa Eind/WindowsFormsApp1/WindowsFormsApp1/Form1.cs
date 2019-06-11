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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        const string SAVE_LOCATION = "saved-game.json";

        string fullSchedule;
        FetchSchedule fetchedSchedule;
        public int scoreone;
        public int scoretwo;
        public string[] scores;
        public int one;
        public int two;
        public int Amount = 25;

        public string saveJson0;

        Save save = new Save();
        Save save0 = new Save();

        public Form1()
        {
            InitializeComponent();
            System.Net.WebClient client = new System.Net.WebClient();
            string read = client.DownloadString("http://simonnuijten.nl/bracket2.php?token=570724329");
            fetchedSchedule = JsonConvert.DeserializeObject<FetchSchedule>(read);
        }

        public void givedata()
        {

        }

        public void saveit()
        {

            
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            const string SAVE_LOCATION = "saved-game.json";

            if(File.Exists(SAVE_LOCATION))
            {
                string saveJson0 = File.ReadAllText(SAVE_LOCATION);

                Save desave0 = JsonConvert.DeserializeObject<Save>(saveJson0);

                label4.Text = desave0.cash.ToString();
            }
            

            //string saveJson0 = File.ReadAllText(SAVE_LOCATION);
            

            

            timer1.Enabled = true;

            string team = "team";
            string response;

            var url = string.Format("http://simonnuijten.nl/teams.php?token=570724329", team);
            using (var webClient = new WebClient())
            {
                response = webClient.DownloadString(url);

                Teams teams = JsonConvert.DeserializeObject<Teams>(response);










                for (int i = 0; i < teams.names.Count; i++)
                {
                    favCombobox.Items.Add(teams.names[i].ToString());
                    //leftteamCombobox.Items.Add(teams.names[i].ToString());
                    //rightteamCombobox.Items.Add(teams.names[i].ToString());

                }

            }





            //client.Headers["Authorization"] = apiKey.Text;













        }

        private void button1_Click(object sender, EventArgs e)
        {
            saveit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            usernameLabel.Text = "Welkom " + Program.username;
            label4.Text = "Saldo " + Program.cash;
        }










        public void SetBet()
        {







            Random rnd = new Random();
            int random = rnd.Next(0, 6);
            int random2 = rnd.Next(0, 6);













            //int score1;




            /*List<FetchScores> fetchedScores;

            System.Net.WebClient client = new System.Net.WebClient();
            string read3 = client.DownloadString("http://simonnuijten.nl/matchesApi.php");
            fetchedScores = JsonConvert.DeserializeObject<List<FetchScores>>(read3);

            string both = leftteamCombobox.Text + " - " + rightteamCombobox.Text;
            //var item;*/



            /*foreach (FetchScores scor in fetchedScores)


            {
                if (leftteamCombobox.Text == favCombobox.Text && int.Parse(leftteamGoalsTextBox.Text) > int.Parse(rightteamGoalsTextBox.Text) && scor.score1 > scor.score2 && leftteamGoalsTextBox.Text + rightteamGoalsTextBox.Text == scor.score1.ToString() + scor.score2.ToString() || rightteamCombobox.Text == favCombobox.Text && int.Parse(rightteamGoalsTextBox.Text) > int.Parse(leftteamGoalsTextBox.Text) && scor.score2 > scor.score1 && leftteamGoalsTextBox.Text + rightteamGoalsTextBox.Text == scor.score1.ToString() + scor.score2.ToString())
                {
                    MessageBox.Show("Well done, en je team heeft gewonnen, en de uitslag ook nog 's goed geraden!");

                }

                if (leftteamCombobox.Text == favCombobox.Text && leftteamCombobox.Text + rightteamCombobox.Text == scor.team1 + scor.team2)
                {


                    

                    if (int.Parse(leftteamGoalsTextBox.Text) > int.Parse(rightteamGoalsTextBox.Text) && scor.score1 > scor.score2 || int.Parse(leftteamGoalsTextBox.Text) < int.Parse(rightteamGoalsTextBox.Text) && scor.score1 > scor.score2)
                    {
                        MessageBox.Show("je team heeft gewonnen");
                        MessageBox.Show("Daadwerkelijke uitslag:" + scor.score1.ToString() + " - " + scor.score2.ToString());
                        Program.cash = 1 / 2;

                    }
                    if (int.Parse(leftteamGoalsTextBox.Text) > int.Parse(rightteamGoalsTextBox.Text) && scor.score1 == scor.score2)
                    {
                        MessageBox.Show("gelijk spel!");
                        MessageBox.Show("Daadwerkelijke uitslag:" + scor.score1.ToString() + " - " + scor.score2.ToString());
                    }
                    if (int.Parse(leftteamGoalsTextBox.Text) < int.Parse(rightteamGoalsTextBox.Text) && scor.score1 < scor.score2 || int.Parse(leftteamGoalsTextBox.Text) > int.Parse(rightteamGoalsTextBox.Text) && scor.score1 < scor.score2)
                    {
                        MessageBox.Show("je team heeft verloren");
                        MessageBox.Show("Daadwerkelijke uitslag:" + scor.score1.ToString() + " - " + scor.score2.ToString());
                    }
                   
                }






                

                    


                    if (int.Parse(rightteamGoalsTextBox.Text) > int.Parse(leftteamGoalsTextBox.Text) && scor.score1 == scor.score2 || int.Parse(rightteamGoalsTextBox.Text) < int.Parse(leftteamGoalsTextBox.Text) && scor.score1 == scor.score2)
                    {
                        MessageBox.Show("gelijk spel!");
                        MessageBox.Show("Daadwerkelijke uitslag:" + scor.score2.ToString() + " - " + scor.score1.ToString());
                    }

                    if (int.Parse(rightteamGoalsTextBox.Text) > int.Parse(leftteamGoalsTextBox.Text) && scor.score1 < scor.score2)
                    {
                        MessageBox.Show("je team heeft gewonnen");
                        MessageBox.Show("Daadwerkelijke uitslag:" + scor.score1.ToString() + " - " + scor.score2.ToString());
                    }

                    
                    if (int.Parse(rightteamGoalsTextBox.Text) < int.Parse(leftteamGoalsTextBox.Text) && scor.score1 > scor.score2 || int.Parse(rightteamGoalsTextBox.Text) > int.Parse(leftteamGoalsTextBox.Text) && scor.score1 > scor.score2)
                    {
                        MessageBox.Show("je team heeft verloren");
                        MessageBox.Show("Daadwerkelijke uitslag:" + scor.score1.ToString() + " - " + scor.score2.ToString());
                    }

                    

                    

                    

                }*/

            if (label4.Text == "0")
            {
                MessageBox.Show("je hebt niet genoeg geld om te wedden");

            }
            else
            {


                Program.cash -= 1 * Amount;

                save.name = Program.username;
                save.cash = Program.cash;




                save.team1 = leftteamCombobox.Text;
                save.team2 = rightteamCombobox.Text;
                save.favteam = favCombobox.Text;

                save.score1 = leftteamGoalsTextBox.Text;
                save.score2 = rightteamGoalsTextBox.Text;

                string saveJson = JsonConvert.SerializeObject(save);
                // Write the saved game to a text file
                File.WriteAllText(SAVE_LOCATION, saveJson);

            }










































            //string f = item;
            //string newString = Regex.Replace(f, "[^.0-9]", "");




            //newString = newString.Insert(1, " ");

            //scores = newString.Split(' ');

            //one = scor.score1;
            //two = scor.score2;

            //one.Trim();
            //two.Trim();







            //MessageBox.Show(newString);
            //MessageBox.Show(score1.ToString());
            //MessageBox.Show(score2.ToString());
            //}







            //scoreone = one;
            //scoretwo = two;


            //score1 = Convert.ToInt32(one);
            //score2 = Convert.ToInt32(two);

            //FetchScores sco;

            //sco = new FetchScores();








        }

    

       
public void betButton_Click(object sender, EventArgs e)
        {
            
            SetBet();
           


        }

        private void leftteamCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {



            string a = comboBox2.Text.Split('-')[0];

            leftteamCombobox.Text = a.Trim().ToString();


            string b = comboBox2.Text.Split('-')[1];

            rightteamCombobox.Text = b.Trim().ToString();


        }

        private void rightteamCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            Program.cash += 50;
        }

        private void favCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            fullSchedule = "";

            var favo = favCombobox.Text;

            //for (int i = 0; i < fetchedSchedule.matches.Count; i++)
            foreach (var item in fetchedSchedule.matches)

            {

                if (item.Contains(favo))
                {

                    //fullSchedule += fetchedSchedule.matches[i] + "\n";
                    //comboBox2.Items.Add(fetchedSchedule.matches[i].ToString());
                    comboBox2.Items.Add(item);
                }

            }

        }

        private void favCombobox_TextUpdate(object sender, EventArgs e)
        {

        }

        

        private void CheckScore_Click(object sender, EventArgs e)
        {

            int Amount = 25;

            const string SAVE_LOCATION = "saved-game.json";

            string saveJson = File.ReadAllText(SAVE_LOCATION);

            Save desave = JsonConvert.DeserializeObject<Save>(saveJson);

            List<FetchScores> fetchedScores;

            System.Net.WebClient client = new System.Net.WebClient();
            string read3 = client.DownloadString("http://simonnuijten.nl/matchesApi.php?token=570724329");
            fetchedScores = JsonConvert.DeserializeObject<List<FetchScores>>(read3);

            string both = leftteamCombobox.Text + " - " + rightteamCombobox.Text;



            foreach (FetchScores scor in fetchedScores)


            {
                if (desave.score1 + desave.score2 == scor.score1.ToString() + scor.score2.ToString() && scor.played == 1 || desave.score1 + desave.score2 == scor.score1.ToString() + scor.score2.ToString() && scor.played == 1)
                {
                    MessageBox.Show("JA, je hebt de uitslag goed geraden!");
                    MessageBox.Show("Daadwerkelijke uitslag:" + scor.score1.ToString() + " - " + scor.score2.ToString());
                    int money = Program.cash += Amount * 3;
                    label4.Text = money.ToString();
                    save.cash = Program.cash;
                    
                        string saveJson1 = JsonConvert.SerializeObject(save);
                        File.WriteAllText(SAVE_LOCATION, saveJson1);
                    



                }

                if(desave.team1 == desave.favteam && desave.team1 + desave.team2 == scor.team1 + scor.team2 && scor.played == 0 || desave.team2 == desave.favteam && desave.team1 + desave.team2 == scor.team1 + scor.team2 && scor.played == 0)
                {
                    MessageBox.Show("je team heeft nog niet gespeeld");
                }
            }

                
        }

        private void CheckWon_Click(object sender, EventArgs e)
        {
            int Amount = 25;

            const string SAVE_LOCATION = "saved-game.json";

            string saveJson = File.ReadAllText(SAVE_LOCATION);

            Save desave = JsonConvert.DeserializeObject<Save>(saveJson);

            List<FetchScores> fetchedScores;

            System.Net.WebClient client = new System.Net.WebClient();
            string read3 = client.DownloadString("http://simonnuijten.nl/matchesApi.php?token=570724329");
            fetchedScores = JsonConvert.DeserializeObject<List<FetchScores>>(read3);

            string both = leftteamCombobox.Text + " - " + rightteamCombobox.Text;



            foreach (FetchScores scor in fetchedScores)


            {
                

                if (desave.team1 == desave.favteam && desave.team1 + desave.team2 == scor.team1 + scor.team2)
                {
                    if (scor.played == 0)
                    {
                        MessageBox.Show("je team heeft nog niet gespeeld");
                    }





                    if (int.Parse(desave.score1) > int.Parse(desave.score2) && scor.score1 > scor.score2 && scor.played == 1 || int.Parse(desave.score1) < int.Parse(desave.score2) && scor.score1 > scor.score2 && scor.played == 1)
                    {
                        MessageBox.Show("je team heeft gewonnen");
                        MessageBox.Show("Daadwerkelijke uitslag:" + scor.score1.ToString() + " - " + scor.score2.ToString());
                        int money = Program.cash += Amount * 2;
                        label4.Text = money.ToString();
                        save.cash = Program.cash;
                        
                            string saveJson1 = JsonConvert.SerializeObject(save);
                            File.WriteAllText(SAVE_LOCATION, saveJson1);
                        



                    }
                    if (int.Parse(desave.score1) > int.Parse(desave.score2) && scor.score1 == scor.score2 && scor.played == 1)
                    {
                        MessageBox.Show("gelijk spel!");
                        MessageBox.Show("Daadwerkelijke uitslag:" + scor.score1.ToString() + " - " + scor.score2.ToString());
                    }
                    if (int.Parse(desave.score1) < int.Parse(desave.score2) && scor.score1 < scor.score2 && scor.played == 1 || int.Parse(desave.score1) > int.Parse(desave.score2) && scor.score1 < scor.score2 && scor.played == 1)
                    {
                        MessageBox.Show("je team heeft verloren");
                        MessageBox.Show("Daadwerkelijke uitslag:" + scor.score1.ToString() + " - " + scor.score2.ToString());
                        int money = Program.cash -= Amount;
                        label4.Text = money.ToString();
                        save.cash = Program.cash;
                        
                            string saveJson1 = JsonConvert.SerializeObject(save);
                            File.WriteAllText(SAVE_LOCATION, saveJson1);
                        
                    }

                }






                if (desave.team2 == desave.favteam && desave.team1 + desave.team2 == scor.team1 + scor.team2)
                {
                    /*if (int.Parse(rightteamGoalsTextBox.Text) > int.Parse(leftteamGoalsTextBox.Text) && scor.score2 > scor.score1)
                    {
                        MessageBox.Show("je team heeft gewonnen");
                        MessageBox.Show("Daadwerkelijke uitslag:" + scor.score1.ToString() + " - " + scor.score2.ToString());
                        Program.cash = 100;

                    }*/

                    if (scor.played == 0)
                    {
                        MessageBox.Show("je team heeft nog niet gespeeld");
                    }





                    if (int.Parse(desave.score2) > int.Parse(desave.score1) && scor.score1 == scor.score2 && scor.played == 1 || int.Parse(desave.score2) < int.Parse(desave.score1) && scor.score1 == scor.score2 && scor.played == 1)
                    {
                        MessageBox.Show("gelijk spel!");
                        MessageBox.Show("Daadwerkelijke uitslag:" + scor.score2.ToString() + " - " + scor.score1.ToString());
                    }

                    if (int.Parse(desave.score2) > int.Parse(desave.score1) && scor.score1 < scor.score2 && scor.played == 1)
                    {
                        MessageBox.Show("je team heeft gewonnen");
                        MessageBox.Show("Daadwerkelijke uitslag:" + scor.score1.ToString() + " - " + scor.score2.ToString());
                        int money = Program.cash += Amount * 2;
                        label4.Text = money.ToString();
                        save.cash = Program.cash;
                        
                            string saveJson1 = JsonConvert.SerializeObject(save);
                            File.WriteAllText(SAVE_LOCATION, saveJson1);
                        
                    }

                    /*if (int.Parse(rightteamGoalsTextBox.Text) > int.Parse(leftteamGoalsTextBox.Text) && random2 > random)
                    {
                        MessageBox.Show("je team heeft verloren");
                        MessageBox.Show(random.ToString() + " - " + random2.ToString());
                    }*/
                    if (int.Parse(desave.score2) < int.Parse(desave.score1) && scor.score1 > scor.score2 && scor.played == 1 || int.Parse(desave.score2) > int.Parse(desave.score1) && scor.score1 > scor.score2 && scor.played == 1)
                    {
                        MessageBox.Show("je team heeft verloren");
                        MessageBox.Show("Daadwerkelijke uitslag:" + scor.score1.ToString() + " - " + scor.score2.ToString());
                        int money = Program.cash -= Amount;
                        label4.Text = money.ToString();
                        save.cash = Program.cash;
                        
                            string saveJson1 = JsonConvert.SerializeObject(save);
                            File.WriteAllText(SAVE_LOCATION, saveJson1);
                        
                    }

                }
            }





        }
    }
}
