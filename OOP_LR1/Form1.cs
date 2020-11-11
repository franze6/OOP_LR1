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
            if (value == string.Empty)
                return;

            try
            {
                int number = int.Parse(value);
                if (number >= 127)
                {
                    this.textBox2.Text = "Символа нет";
                    return;
                }
                
                this.textBox2.Text += char.IsDigit((char)number) ? "Цифра" : 
                    char.IsLower((char)number) ? "Строчная буква" : 
                    char.IsUpper((char)number) ? "Прописная буква" :
                    char.IsControl((char)number) ? "Управляющий символ" : "Другой символ";
            }
            catch
            {
                this.textBox2.Text = "Ошибка";
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
