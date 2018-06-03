using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            new SearchForm().Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            new CreateForm().Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            new InfoForm().Show();

        }
    }
}
