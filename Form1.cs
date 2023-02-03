using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test1
{
    public partial class Form1 : Form
    {
        private object txtResult;

        public Form1()
        {
            InitializeComponent();
        }

        private void calculate_Click(object sender, EventArgs e)
        {
            var num1 = Convert.ToInt32(txtbox1.Text);
            var num2 = Convert.ToInt32(txtbox2.Text);
            var total = (num1 + num2).ToString();
            txtbox3.Text = total.ToString();
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            txtbox1.Text = string.Empty;
            txtbox2.Text = string.Empty;
            txtbox3.Text = string.Empty;
        }
    }
}
