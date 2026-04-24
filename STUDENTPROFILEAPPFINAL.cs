using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentProfileApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;

            int age;
            double mark;

            if (!int.TryParse(txtAge.Text, out age))
            {
                MessageBox.Show("Enter a valid age");
                return;
            }

            if (!double.TryParse(txtMark.Text, out mark))
            {
                MessageBox.Show("Enter a valid mark");
                return;
            }

            string status = GetStatus(mark);

            lblResults.Text =
                "Name: " + name +
                "\nAge: " + age +
                "\nMark: " + mark +
                "\nStatus: " + status;
        }

        private string GetStatus(double mark)
        {
            if (mark >= 50)
                return "Ready";
            else
                return "Not Ready";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
