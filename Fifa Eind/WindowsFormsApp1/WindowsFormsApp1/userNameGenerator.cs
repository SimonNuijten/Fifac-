using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class userNameGenerator : Form
    {
        const string SAVE_LOCATION = "saved-game.json";

        public userNameGenerator()
        {
            InitializeComponent();
        }

        private void generator_Click(object sender, EventArgs e)
        {
            if (Program.username == "")
            {
                userCreator userCreator = new userCreator();
                userCreator.random();
                MessageBox.Show("U nieuwe naam is : " + Program.username);
                Form1 form1 = new Form1();
                form1.ShowDialog();
            }
            else
            {
                MessageBox.Show("U heeft al een account");
            }
        }

        private void nameController_Tick(object sender, EventArgs e)
        {
            userNameLabel.Text = Program.username;

        }

        private void userNameGenerator_Load(object sender, EventArgs e)
        {
            try
            {
                nameController.Enabled = true;
                string saveJson = File.ReadAllText(SAVE_LOCATION);
                Save save = JsonConvert.DeserializeObject<Save>(saveJson);
                Program.username = save.name;
                Program.cash = save.cash;
                if (Program.username != "")
                {
                    Form1 form1 = new Form1();
                    form1.ShowDialog();
                }
            }

            catch
            {
                MessageBox.Show("U heeft nog geen account");
            }





        }
    }
}
