using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApp_V2
{
    public partial class CalculatorUI : Form
    {

        double firstNumber;
        double secondNumber;


        public CalculatorUI()
        {
            InitializeComponent();
        }

        private Calculator calculator;

        private void addButton_Click(object sender, EventArgs e)
        {
            calculator = new Calculator();

            IniatilizeFirstNoSecondNo();
            resultTextBox.Text = calculator.Add(firstNumber ,secondNumber).ToString();
        }

   

        private void subtractButton_Click(object sender, EventArgs e)
        {
            calculator = new Calculator();

            IniatilizeFirstNoSecondNo();
            resultTextBox.Text = calculator.Subtract(firstNumber, secondNumber).ToString();
        }

        private void divideButton_Click(object sender, EventArgs e)
        {
            calculator = new Calculator();

            IniatilizeFirstNoSecondNo();
            resultTextBox.Text = calculator.Divide(firstNumber, secondNumber).ToString();
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            calculator = new Calculator();

            IniatilizeFirstNoSecondNo();
            resultTextBox.Text = calculator.Multiply(firstNumber, secondNumber).ToString();
        }



        private void IniatilizeFirstNoSecondNo()
        {
            firstNumber = Convert.ToDouble(firstNameTextBox.Text);
            secondNumber = Convert.ToDouble(secondNameTextBox.Text);
        }
    }
}
