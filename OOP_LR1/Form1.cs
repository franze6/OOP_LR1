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
            this.textBox2.Clear();
            string value = this.textBox1.Text;

            if (value == String.Empty)
                return;

            try
            {
                this.textBox2.Text = Convert.ToInt32(value, 16).ToString();
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
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
