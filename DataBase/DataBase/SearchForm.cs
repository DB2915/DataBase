using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace DataBase
{
    public partial class SearchForm : Form
    {
        public SearchForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string[] info = File.ReadAllLines("Info");
            int a = Convert.ToInt32(info[0]);
            string[] data = File.ReadAllLines("1");

            if (comboBox1.Text=="Имя")
            {
                for (int i = 1; i < a+1; i++)
                {
                    if (data[0]==textBox1.Text)
                    {
                        textBox2.AppendText(data[1] + " " + data[0] + " " + data[2] + Environment.NewLine);
                    }
                    data = File.ReadAllLines((i + 1).ToString());
                }
                data = File.ReadAllLines("1");
            }
            else if (comboBox1.Text=="Фамилия")
            {
                for (int i = 1; i < a + 1; i++)
                {
                    if (data[1] == textBox1.Text)
                    {
                        textBox2.AppendText(data[1] + " " + data[0] + " " + data[2] + Environment.NewLine);
                    }
                    data = File.ReadAllLines((i + 1).ToString());
                }
                data = File.ReadAllLines("1");
            }
            else if (comboBox1.Text == "Отчество")
            {
                for (int i = 1; i < a + 1; i++)
                {
                    if (data[2] == textBox1.Text)
                    {
                        textBox2.AppendText(data[1] + " " + data[0] + " " + data[2] + Environment.NewLine);
                    }
                    data = File.ReadAllLines((i + 1).ToString());
                }
                data = File.ReadAllLines("1");
            }

        }
    }
}
