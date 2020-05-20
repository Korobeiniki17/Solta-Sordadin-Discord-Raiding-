using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSpam
{
    
    public partial class easteregg : Form
    {
        public easteregg()
        {
            InitializeComponent();
        }
        public static int cu;
        private void monoFlat_Button1_Click(object sender, EventArgs e)
        {
            
            if (monoFlat_CheckBox2.Checked == true)
            {
                timer1.Enabled = true;
                monoFlat_Label1.Text = "Você Está no Modo: Automatico";
                monoFlat_Label1.Location = new Point(418, 578);
            }
            if (monoFlat_CheckBox2.Checked == false)
            {
                monoFlat_Label1.Text = "Você Está no Modo: Manual";
                monoFlat_Label1.Location = new Point(433, 578);
                timer1.Enabled = false;
                Random rnd2 = new Random();
                int numero_sorteado2 = rnd2.Next(2, 11);
                if (numero_sorteado2 == 2)
                {
                    pictureBox1.Image = Properties.Resources._2;
                }
                if (numero_sorteado2 == 3)
                {
                    pictureBox1.Image = Properties.Resources._3;
                }
                if (numero_sorteado2 == 4)
                {
                    pictureBox1.Image = Properties.Resources._4;
                }
                if (numero_sorteado2 == 5)
                {
                    pictureBox1.Image = Properties.Resources._5;
                }
                if (numero_sorteado2 == 6)
                {
                    pictureBox1.Image = Properties.Resources._6;
                }
                if (numero_sorteado2 == 7)
                {
                    pictureBox1.Image = Properties.Resources._7;
                }
                if (numero_sorteado2 == 8)
                {
                    pictureBox1.Image = Properties.Resources._8;
                }
                if (numero_sorteado2 == 9)
                {
                    pictureBox1.Image = Properties.Resources._9;
                }
                if (numero_sorteado2 == 10)
                {
                    pictureBox1.Image = Properties.Resources._10;
                }
                if (numero_sorteado2 == 11)
                {
                    pictureBox1.Image = Properties.Resources._11;
                }
            }
        }

        private void monoFlat_ThemeContainer1_Click(object sender, EventArgs e)
        {

        }

        private void monoFlat_CheckBox1_CheckedChanged(object sender)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int numero_sorteado = rnd.Next(2, 11);
            if (numero_sorteado == 2)
            {
                pictureBox1.Image = Properties.Resources._2;
            }
            if (numero_sorteado == 3)
            {
                pictureBox1.Image = Properties.Resources._3;
            }
            if (numero_sorteado == 4)
            {
                pictureBox1.Image = Properties.Resources._4;
            }
            if (numero_sorteado == 5)
            {
                pictureBox1.Image = Properties.Resources._5;
            }
            if (numero_sorteado == 6)
            {
                pictureBox1.Image = Properties.Resources._6;
            }
            if (numero_sorteado == 7)
            {
                pictureBox1.Image = Properties.Resources._7;
            }
            if (numero_sorteado == 8)
            {
                pictureBox1.Image = Properties.Resources._8;
            }
            if (numero_sorteado == 9)
            {
                pictureBox1.Image = Properties.Resources._9;
            }
            if (numero_sorteado == 10)
            {
                pictureBox1.Image = Properties.Resources._10;
            }
            if (numero_sorteado == 11)
            {
                pictureBox1.Image = Properties.Resources._11;
            }
        }

        private void monoFlat_CheckBox2_CheckedChanged(object sender)
        {
            
        }

        private void monoFlat_HeaderLabel1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
