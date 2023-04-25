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

namespace randevu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string filePath = "randevu.txt";
            if (!File.Exists(filePath))
            {
                using (StreamWriter sw = File.CreateText(filePath))
                {
                    sw.WriteLine(textBox1.Text);
                }
            }
            else
            {
                using (StreamWriter sw = new StreamWriter(File.Open(filePath, System.IO.FileMode.Append)))
                {
                    sw.WriteLine(textBox1.Text);
                }
            }
            textBox1.Text = "";
            label1.Text = "Yazma işlemi tamamlandı.";
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string filePath = "randevu.txt";
            if (!File.Exists(filePath))
            {
                using (StreamWriter sw = File.CreateText(filePath))
                {
                    sw.WriteLine(textBox2.Text);
                }
            }
            else
            {
                using (StreamWriter sw = new StreamWriter(File.Open(filePath, System.IO.FileMode.Append)))
                {
                    sw.WriteLine(textBox2.Text);
                }
            }
            textBox2.Text = "";
            label2.Text = "Yazma işlemi tamamlandı.";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string filePath = "randevu.txt";
            if (!File.Exists(filePath))
            {
                using (StreamWriter sw = File.CreateText(filePath))
                {
                    sw.WriteLine(textBox3.Text);
                }
            }
            else
            {
                using (StreamWriter sw = new StreamWriter(File.Open(filePath, System.IO.FileMode.Append)))
                {
                    sw.WriteLine(textBox3.Text);
                }
            }
            textBox3.Text = "";
            label3.Text = "Yazma işlemi tamamlandı.";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string filePath = "randevu.txt";
            listBox1.Items.Clear();
            int count = 0;
            using (StreamReader sr = new StreamReader(filePath))
            {
                while(sr.Peek() >= 0)
                {
                    count++;
                    listBox1.Items.Add((count) + "->" + sr.ReadLine());
                }
            }
            label4.Text = "Randevu Kayıdınız oluşturuldu.";
        }
    }
}
