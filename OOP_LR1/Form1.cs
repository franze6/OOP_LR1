using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;
using System.Collections.Generic;

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
            List<int> list = new List<int>();
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
                    list.Add(a);
                    list.Add(b);
                }
            }

            fs.Close();

            int max = list[0];

            for(int i =0; i < 5; i++)
            {
                if (list[i] > max) max = list[i];
            }

            MessageBox.Show($"Максимальный элемент: {max}");
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
