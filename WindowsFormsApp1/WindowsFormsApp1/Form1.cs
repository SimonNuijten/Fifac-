using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void givedata()
        {
            
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            //var dgurl = "DGURL";
            string id = "id";
            string users = "username";

            var url = string.Format("http://simonnuijten.nl/teams.php?username=users{0}", users);
            using (var webClient = new WebClient())
            {
                var response = webClient.DownloadString(url);
                //Console.WriteLine(response);
                //listBox1.Items.Add(response);
                phpdataLabel.Text = response;
                
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
    }
}
