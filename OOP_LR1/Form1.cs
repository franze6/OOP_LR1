using System;
using Microsoft.VisualBasic;
using System.Windows.Forms;
using System.Security.Cryptography.X509Certificates;

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

            double a = double.Parse(Interaction.InputBox("Введите a", "Ввод коэффициентов", "", 500, 500));
            double b = double.Parse(Interaction.InputBox("Введите b", "Ввод коэффициентов", "", 500, 500));
            double c = double.Parse(Interaction.InputBox("Введите c", "Ввод коэффициентов", "", 500, 500));
            double x1, x2;

            if (a == 0)
            {
                if (b == 0)
                {
                    MessageBox.Show("Корней нет.");
                    return;
                }
                else
                {
                    x1 = -c / b;
                    x2 = x1;
                }
            }
            else
            {
                if (b == 0)
                {
                    if (-c / a < 0)
                    {
                        MessageBox.Show("Действительных корней нет.");
                        return;
                    }
                    else
                    {
                        x1 = Math.Sqrt(-c / a);
                        x2 = x1;
                    }
                }
                else
                {
                    double D = b * b - 4 * a * c;
                    if (D < 0)
                    {
                        MessageBox.Show("Действительных корней нет.");
                        return;
                    }
                    else
                    {
                        x1 = ((-b + Math.Sqrt(D)) / (2 * a));
                        x2 = -x1;
                    }
                }
            }

            MessageBox.Show($"Корни уравнения: х1={x1} x2={x2}");
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
