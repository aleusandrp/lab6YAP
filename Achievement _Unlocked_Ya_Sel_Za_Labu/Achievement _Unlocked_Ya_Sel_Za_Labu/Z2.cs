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
                Kv.A = Double.Parse(textBox1.Text);
                BiKv.A = Double.Parse(textBox1.Text);
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
    }
}
