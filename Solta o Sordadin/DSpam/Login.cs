using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Text.RegularExpressions;
using System.Diagnostics;

namespace DSpam
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

        }

        private void Login_Load(object sender, EventArgs e)
        {
            WebClient ip = new WebClient();
            string ipstring = ip.DownloadString("http://bot.whatismyipaddress.com/");
            IP_DO_JOVEM.Text = "Seu IP: " + ipstring;
        }

        private void monoFlat_Button1_Click(object sender, EventArgs e)
        {
            WebClient client = new WebClient();
            string loginstring = client.DownloadString("https://pastebin.com/raw/UGnWMYy0");

            string[] arraydologin = Regex.Split(loginstring, ":");
            string login = arraydologin[0];
            string senha = arraydologin[1];
            //MessageBox.Show(login + " " + senha);
            if (monoFlat_TextBox1.Text == login && monoFlat_TextBox2.Text == senha)
            {
                MessageBox.Show("Logado com Sucesso !!", "Solta o Soldadinho Atiralol");
                Form1 tempForm = new Form1();
                this.AddOwnedForm(tempForm);
                tempForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Login Incorreto !!", "Solta o Soldadinho Atiralol");
            }
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (monoFlat_TrackBar1.Value == 10 && monoFlat_TrackBar2.Value == 10 && monoFlat_TrackBar3.Value == 10 && monoFlat_TrackBar4.Value == 10)
            {
                monoFlat_TrackBar1.Value = 0;
                monoFlat_TrackBar2.Value = 0;
                monoFlat_TrackBar3.Value = 0;
                monoFlat_TrackBar4.Value = 0;
                MessageBox.Show("Você Desbloqueou um Easter Egg, Digite a Senha", "Soldadinho Easter Egg");
                easteregg tempForm = new easteregg();
                this.AddOwnedForm(tempForm);
                tempForm.Show();

            }

        }

        private void monoFlat_HeaderLabel1_Click(object sender, EventArgs e)
        {
            Process.GetCurrentProcess().Kill();
        }

        private void monoFlat_ThemeContainer1_Click(object sender, EventArgs e)
        {

        }
    }
}
