using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Petrov_Lab_1
{
    public partial class Controller : Form
    {
        public Controller()
        {
            InitializeComponent();
        }
        Percent Pr = new Percent();
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Convert.ToInt32(textBox1.Text);
                label4.Text = "Введите сумму в чеке";
            }
            catch (System.FormatException)
            {
                label4.Text = "Вы ввели символ! Пожалуйста,введите цифрy";
                textBox1.Clear();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {   
            int value = Pr.countSumTrunc(0.1, Convert.ToInt32(textBox1.Text));
            label2.Text = Convert.ToString("Необходимя сумма = " + value);
            label1.Text = "";
            label3.Text = "";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int value = Pr.countSumTrunc(0.15, Convert.ToInt32(textBox1.Text));
            label1.Text = Convert.ToString("Необходимя сумма = " + value);
            label2.Text = "";
            label3.Text = "";
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            int value = Pr.countSumTrunc(0.03, Convert.ToInt32(textBox1.Text));
            label3.Text = Convert.ToString("Необходимя сумма = " + value);
            label1.Text = "";
            label2.Text = "";
        }

        private void Controller_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
    public class Percent {
        private double countPr(double sum, int pr)
        {
            return sum * pr;
        }
        private double countSum(double sum, int pr)
        {
            return countPr(sum, pr) + pr;
        }
        public int countSumTrunc(double sum, int pr)
        {
           return Convert.ToInt32(Math.Round(countSum(sum, pr)));
        }

    }
}
