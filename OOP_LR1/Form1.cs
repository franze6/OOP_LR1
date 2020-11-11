using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;

namespace OOP_LR1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void StartOperation()
        {
            int a, b;
            int s = 0;
            FileStream fs = File.OpenRead(@"C:\Users\solda\source\repos\OOP_LR1\OOP_LR1\file.txt");
            using(StreamReader sr = new StreamReader(fs))
            {
                while(!sr.EndOfStream)
                {
                    string[] line = sr.ReadLine().Split(' ');
                    if (line.Length < 2)
                        continue;
                    a = int.Parse(line[0]);
                    b = int.Parse(line[1]);
                    if (a > 0 && b > 0)
                        s++;
                }
            }
            MessageBox.Show($"Оба числа были больше нуля {s} раз(а)");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.StartOperation();
        }
    }
}
