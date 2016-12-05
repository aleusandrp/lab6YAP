using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Achievement__Unlocked_Ya_Sel_Za_Labu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool EpilepsyHall = true;

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (EpilepsyHall)
            {
                double x = (double)e.X / ClientSize.Width * 255;
                double y = (double)e.Y / ClientSize.Height * 255;
                BackColor = Color.FromArgb((int)x, (int)y, (int)y);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Закрыть форму?", Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                e.Cancel = true;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.Alt && e.KeyCode == Keys.C)
                EpilepsyHall = !EpilepsyHall;

            if ((e.Alt && e.KeyCode == Keys.X)||(e.KeyCode == Keys.F10))
                Close();
            switch (e.KeyCode)
            {
                case Keys.Up:
                    if (Top >= 0)
                        Top -= 5;
                    break;
                case Keys.Down:
                    if (Bottom <= Screen.PrimaryScreen.WorkingArea.Height + 5) 
                        Top += 5;
                    break;
                case Keys.Left:
                    if (Left >= 0) 
                        Left -= 5;
                    break;
                case Keys.Right:
                    if (Right <= Screen.PrimaryScreen.WorkingArea.Width + 5)
                        Left += 5;
                    break;
            }
            if(e.KeyCode == Keys.G)
            {
                Z2 Forma = new Z2();
                Forma.Show();
            }
        }

        private void Form1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
