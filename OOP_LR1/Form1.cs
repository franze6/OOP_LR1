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
            double a, b;
            FileStream fs = File.OpenRead(@"C:\Users\solda\source\repos\OOP_LR1\OOP_LR1\file.txt");
            using(StreamReader sr = new StreamReader(fs))
            {
                while(!sr.EndOfStream)
                {
                    string[] line = sr.ReadLine().Split(' ');
                    if (line.Length < 2)
                        continue;
                    a = double.Parse(line[0]);
                    b = double.Parse(line[1]);
                    this.listBox1.Items.Add($"Re={a} Im={b}");
                }
            }

            fs.Close();

            fs = File.OpenWrite(@"C:\Users\solda\source\repos\OOP_LR1\OOP_LR1\Result.txt");
            using(StreamWriter sw = new StreamWriter(fs))
            {
                foreach(var item in this.listBox1.Items)
                {
                    sw.WriteLine(item.ToString());
                }
            }

            fs.Close();
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
