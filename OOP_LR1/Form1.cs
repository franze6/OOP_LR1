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
            string value = this.textBox1.Text;
            this.listBox1.Items.Clear();
            if (value == string.Empty)
                return;

            try
            {
                int number = int.Parse(value);

                if (number < 1)
                    return;
                for(int i = 2; i <= number/2; i++)
                {
                    if(number % i == 0)
                    {
                        this.listBox1.Items.Add(i);
                    }
                }
                
                if (this.listBox1.Items.Count == 0)
                {
                    MessageBox.Show("Исходное число - простое");
                }
            }
            catch
            {
                MessageBox.Show("Ошибка");
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
