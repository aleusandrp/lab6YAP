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
    public partial class Z2 : Form
    {
        Kvadrad Kv = new Kvadrad();
        BiKvadrav BiKv = new BiKvadrav();

        public Z2()
        {
            InitializeComponent();
            Kv.ChangeK += ChangeKv;
            BiKv.ChangeK += ChangeBiKv;
        }

        private void Z2_Load(object sender, EventArgs e)
        {

        }

        private void ChangeKv()
        {
            label8.Text = Kv.ToString();
        }

        private void ChangeBiKv()
        {
            label9.Text = BiKv.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Kv.A = Double.Parse(textBox2.Text);
                BiKv.A = Double.Parse(textBox2.Text);
            }
            catch
            {
                Kv.A = 0;
                BiKv.A = 0;
            }
            ChangeKv();
            ChangeBiKv();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Kv.B = Double.Parse(textBox2.Text);
                BiKv.B = Double.Parse(textBox2.Text);
            }
            catch
            {
                Kv.B = 0;
                BiKv.B = 0;
            }
            ChangeKv();
            ChangeBiKv();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Kv.C = Double.Parse(textBox3.Text);
                BiKv.C = Double.Parse(textBox3.Text);
            }
            catch
            {
                Kv.C = 0;
                BiKv.C = 0;
            }
            ChangeKv();
            ChangeBiKv();
        }

        private void Z2_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                textBox1.SelectAll();
                textBox2.SelectAll();
                textBox3.SelectAll();
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool Minez = ((TextBox)sender).Text.Length > 0 ? true : false;
            bool Seporator = ((((TextBox)sender).Text.Length == 1 && ((TextBox)sender).Text[0] != '-') || ((((TextBox)sender).Text.Length == 2) && Char.IsDigit(Convert.ToChar(((TextBox)sender).Text[1])))) ? true : false;
            bool Zero = ((((TextBox)sender).Text.Length == 1 && ((TextBox)sender).Text[0] == '0') || (((TextBox)sender).Text.Length == 2 && ((TextBox)sender).Text[1] == '0')) ? true : false;

            
            if ((e.KeyChar <= 47 || e.KeyChar >= 57) && e.KeyChar != 8 && e.KeyChar != 44 && e.KeyChar != 45)
                e.Handled = true;
            else if (e.KeyChar == 45 && Minez)
                e.Handled = true;
            else if (e.KeyChar == 44 && !Seporator)
                e.Handled = true;
            else if (e.KeyChar == 48 && Zero)
                e.Handled = true;
            else if (((TextBox)sender).Text == ((TextBox)sender).SelectedText)
                ((TextBox)sender).Text = "";
            else
                return;

        }
    }
}
