using System;
using System.Linq;
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
            foreach (var (item,i) in value.Select((item, i)=>(item, i)))
            {
                if (!char.IsLetterOrDigit(item) && !char.IsWhiteSpace(item))
                {
                    this.Result.Text = "Неправильная строка";
                    this.textBox1.Focus();
                    this.textBox1.SelectionStart = i;
                    this.textBox1.SelectionLength = 1;
                    return;
                }
            }
            this.Result.Text = "Правильная строка";
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
