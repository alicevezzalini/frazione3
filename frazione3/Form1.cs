using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frazione3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Fraction somma = Fraction.Parse("0/1");
            foreach(Fraction f in listBox1.Items)
            {
                somma = somma + f;
            }
            label1.Text = somma.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Fraction primo = (Fraction)listBox1.Items[0];

            for (int i = 1; i < listBox1.Items.Count; i++)
            {
                primo = primo - (Fraction)listBox1.Items[i];
            }

            label1.Text = primo.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Fraction moltiplica = Fraction.Parse("1/1");
            foreach (Fraction f in listBox1.Items)
            {
                moltiplica = moltiplica * f;
            }
            label1.Text = moltiplica.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Fraction p = (Fraction)listBox1.Items[0];
            for (int i = 1; i < listBox1.Items.Count; i++)
            {
                p = p / (Fraction)listBox1.Items[1];
            }
            
            label1.Text = p.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Fraction f = Fraction.Parse(textBox1.Text);
            listBox1.Items.Add(f);

        }
    }
}
