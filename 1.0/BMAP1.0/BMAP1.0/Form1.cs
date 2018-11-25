using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMAP1._0
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            Gauge1.To = 100;
            Gauge2.To = 100;
            Gauge3.To = 100;
            Gauge4.To = 100;
            Gauge5.To = 100;
            Gauge6.To = 100;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Gauge1_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            float a;
            bool b = float.TryParse(textBox1.Text, out a);
            if (b)
            {
                Gauge1.Value = float.Parse(textBox1.Text);
            }
            

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            float a;
            bool b = float.TryParse(textBox2.Text, out a);
            if (b)
            {
                Gauge2.Value = float.Parse(textBox2.Text);
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            float a;
            bool b = float.TryParse(textBox3.Text, out a);
            if (b)
            {
                Gauge3.Value = float.Parse(textBox3.Text);
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            float a;
            bool b = float.TryParse(textBox4.Text, out a);
            if (b)
            {
                Gauge4.Value = float.Parse(textBox4.Text);
            }
        }
    }
}
