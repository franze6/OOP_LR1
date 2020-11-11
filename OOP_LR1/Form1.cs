using System;
using System.Windows.Forms;

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
            unsafe {
                byte x = 2;
                short y = 15;
                long z = 545;
                int w = 434;

                this.dataGridView1.Rows.Add("Byte", $"{(int)&x:X}", $"{sizeof(byte)}");
                this.dataGridView1.Rows.Add("Short", $"{(int)&y:X}", $"{sizeof(short)}");
                this.dataGridView1.Rows.Add("Long", $"{(int)&z:X}", $"{sizeof(long)}");
                this.dataGridView1.Rows.Add("Int", $"{(int)&w:X}", $"{sizeof(int)}");
            }
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
