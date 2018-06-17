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
using System.Threading;

namespace DataBase
{
    public partial class CreateForm : Form
    {
        public CreateForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Загружаем данные из полей ввода
            string[] pinfo = new string[10];
            pinfo[0] = textBox1.Text;
            pinfo[1] = textBox2.Text;
            pinfo[2] = textBox3.Text;
            pinfo[3] = comboBox1.Text;
            pinfo[4] = textBox4.Text;
            pinfo[5] = comboBox2.Text;
            pinfo[6] = comboBox3.Text;
            pinfo[7] = comboBox4.Text;
            pinfo[8] = textBox5.Text;
            pinfo[9] = comboBox6.Text;

            //Узнаем кол-во файлов
            string[] info = File.ReadAllLines("Info");
            int num = Convert.ToInt32(info[0]);
            string name = Convert.ToString(num+1);


            File.Create(name);
            //Пишем в промежуточный файл
            File.WriteAllLines("0", pinfo);
            //Создаем и запускаем новый поток
            Thread WriteData = new Thread(func);
            WriteData.Start(name);
            Thread.Sleep(500);
            //Поток 2 завершился, сообщаем об этом и чистим поля ввода
            MessageBox.Show("Успешно");
            //Добавляем кол-во файлов в файле информации
            info[0] = Convert.ToString(Convert.ToInt32(info[0]) + 1);
            File.WriteAllLines("Info", info);

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            comboBox1.Text = "";
            comboBox2.Text = "";
            comboBox3.Text = "";
            comboBox4.Text = "";
            comboBox6.Text = "";
        }
        public static void func(object name)
        {
            //Записываем информацию в файл
            string[] pinfo = File.ReadAllLines("0");
            File.WriteAllLines(name.ToString(), pinfo);
            //Чистим промежуточный файл
            string[] nothing = new string[1];
            nothing[0] = "";
            File.WriteAllLines("0", nothing);
        }
    }
}