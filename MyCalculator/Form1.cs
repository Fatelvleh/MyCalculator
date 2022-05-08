using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCalculator
{
    public partial class Form1 : Form
    {
        ICalculate calculate;
        public Form1()
        {
            InitializeComponent();
            calculate = new Calculate();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // Check Input Validation
        bool ValidateInputs()
        {
            bool isvalid = true;

            if (txtNumber1.Value == 0)
            { 
                isvalid = false;
                MessageBox.Show("عدد اول را وارد کنید");
            }
            else 
            {
                if (txtNumber2.Value == 0)
                {
                    isvalid = false;
                    MessageBox.Show("عدد دوم را وارد کنید");
                }
                 
            }
            return isvalid;

            


        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                int sum = calculate.Plus((int)txtNumber1.Value,(int)txtNumber2.Value);
                MessageBox.Show("" + sum);
            }
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {

            if (ValidateInputs())
            {
                int minus = calculate.Minus((int)txtNumber1.Value, (int)txtNumber2.Value);
                MessageBox.Show("" + minus);
            }
        }

        private void btnMultiple_Click(object sender, EventArgs e)
        {

            if (ValidateInputs())
            {
                int multiple = calculate.Multiple((int)txtNumber1.Value, (int)txtNumber2.Value);
                MessageBox.Show("" + multiple);
            }
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {

            if (ValidateInputs())
            {
                int Divide = calculate.Divide((int)txtNumber1.Value, (int)txtNumber2.Value);
                MessageBox.Show("" + Divide);
            }
        }
    }
}
