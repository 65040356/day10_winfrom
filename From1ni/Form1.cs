using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace From1ni
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void botton1_Click(object sender, EventArgs e)
        {
            string gettext = question_text.Text;
            string[] strings_values = gettext.Split('/');
            double a, b, c;
            a=Convert.ToDouble(strings_values[0]);
            b=Convert.ToDouble(strings_values[1]);
            c = a / b;
            solution_textbox.Text = c.ToString();
            solution_label.Text = c.ToString();
        }
    }
}
