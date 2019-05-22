using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;


namespace Piano
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ResetujDugmice()
        {
            button1.BackColor = Color.DarkRed;
            button2.BackColor = Color.DarkRed;
            button3.BackColor = Color.DarkRed;
            button4.BackColor = Color.DarkRed;
            button5.BackColor = Color.DarkRed;
            button6.BackColor = Color.DarkRed;
            button7.BackColor = Color.DarkRed;
            button8.BackColor = Color.DarkRed;
            button9.BackColor = Color.DarkRed;
            button10.BackColor = Color.DarkRed;
            button11.BackColor = Color.DarkRed;
            button12.BackColor = Color.Black;
            button13.BackColor = Color.Black;
            button14.BackColor = Color.Black;
            button15.BackColor = Color.Black;
            button16.BackColor = Color.Black;
            button17.BackColor = Color.Black;
            button18.BackColor = Color.Black;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer(Properties.Resources.C);
            player.Load();

            ResetujDugmice();
            button1.BackColor = Color.IndianRed;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer(Properties.Resources.D);
            player.Play();

            ResetujDugmice();
            button2.BackColor = Color.IndianRed;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer(Properties.Resources.E);
            player.Play();

            ResetujDugmice();
            button3.BackColor = Color.IndianRed;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer(Properties.Resources.F);
            player.Play();

            ResetujDugmice();
            button4.BackColor = Color.IndianRed;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer(Properties.Resources.G);
            player.Play();

            ResetujDugmice();
            button5.BackColor = Color.IndianRed;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer(Properties.Resources.A);
            player.Play();

            ResetujDugmice();
            button6.BackColor = Color.IndianRed;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer(Properties.Resources.B);
            player.Play();

            ResetujDugmice();
            button7.BackColor = Color.IndianRed;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer(Properties.Resources.C1);
            player.Play();

            ResetujDugmice();
            button8.BackColor = Color.IndianRed;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer(Properties.Resources.D1);
            player.Play();

            ResetujDugmice();
            button9.BackColor = Color.IndianRed;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer(Properties.Resources.E1);
            player.Play();

            ResetujDugmice();
            button10.BackColor = Color.IndianRed;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer(Properties.Resources.F1);
            player.Play();

            ResetujDugmice();
            button11.BackColor = Color.IndianRed;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer(Properties.Resources.C_s);
            player.Play();

            ResetujDugmice();
            button12.BackColor = Color.DarkGray;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer(Properties.Resources.D_s);
            player.Play();

            ResetujDugmice();
            button13.BackColor = Color.DarkGray;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer(Properties.Resources.F_s);
            player.Play();

            ResetujDugmice();
            button14.BackColor = Color.DarkGray;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer(Properties.Resources.G_s);
            player.Play();

            ResetujDugmice();
            button15.BackColor = Color.DarkGray;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer(Properties.Resources.Bb);
            player.Play();

            ResetujDugmice();
            button16.BackColor = Color.DarkGray;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer(Properties.Resources.C_s1);
            player.Play();

            ResetujDugmice();
            button17.BackColor = Color.DarkGray;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer(Properties.Resources.D_s1);
            player.Play();

            ResetujDugmice();
            button18.BackColor = Color.DarkGray;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.A:
                    e.Handled = true;
                    button1.PerformClick();
                    break;
                case Keys.S:
                    e.Handled = true;
                    button2.PerformClick();
                    break;
                case Keys.D:
                    e.Handled = true;
                    button3.PerformClick();
                    break;
                case Keys.F:
                    e.Handled = true;
                    button4.PerformClick();
                    break;
                case Keys.G:
                    e.Handled = true;
                    button5.PerformClick();
                    break;
                case Keys.H:
                    e.Handled = true;
                    button6.PerformClick();
                    break;
                case Keys.J:
                    e.Handled = true;
                    button7.PerformClick();
                    break;
                case Keys.K:
                    e.Handled = true;
                    button8.PerformClick();
                    break;
                case Keys.L:
                    e.Handled = true;
                    button9.PerformClick();
                    break;
                case Keys.Z:
                    e.Handled = true;
                    button10.PerformClick();
                    break;
                case Keys.X:
                    e.Handled = true;
                    button11.PerformClick();
                    break;
                case Keys.W:
                    e.Handled = true;
                    button12.PerformClick();
                    break;
                case Keys.E:
                    e.Handled = true;
                    button13.PerformClick();
                    break;
                case Keys.T:
                    e.Handled = true;
                    button14.PerformClick();
                    break;
                case Keys.Y:
                    e.Handled = true;
                    button15.PerformClick();
                    break;
                case Keys.U:
                    e.Handled = true;
                    button16.PerformClick();
                    break;
                case Keys.O:
                    e.Handled = true;
                    button17.PerformClick();
                    break;
                case Keys.P:
                    e.Handled = true;
                    button18.PerformClick();
                    break;
            }
        }
    }
}
