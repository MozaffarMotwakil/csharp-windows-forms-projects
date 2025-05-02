using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace L1_Ex1_Calculater
{
    public partial class MainForm : Form
    {
        string currentOperation;

        private void CalculateResult()
        {
            try
            {
                string[] parts = txtExpression.Text.Split(currentOperation[0]);

                double num1 = double.Parse(parts[0]);
                double num2 = double.Parse(parts[1]);

                double result;

                switch (currentOperation)
                {
                    case "+": result = num1 + num2; break;
                    case "-": result = num1 - num2; break;
                    case "×": result = num1 * num2; break;
                    case "÷":
                        if (num2 == 0)
                        {
                            txtResult.Text = "Cannot be divided by 0";
                            return;
                        }
                        else
                        {
                            result = num1 / num2;
                        }
                        break;
                    case "^": result = Math.Pow(num1, num2); break;
                    case "%": result = num1 % num2; break;
                    default:
                        txtResult.Text = "Unknown operation";
                        return;
                }

                txtResult.Text = result.ToString();
            }
            catch
            {
                txtResult.Text = "Calculation Error";
            }
        }

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnNum_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            txtExpression.Text += btn.Text;
        }

        private void btnOperation_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtExpression.Text) || currentOperation != " ")
            {
                return;
            }

            Button btn = sender as Button;

            if (!String.IsNullOrWhiteSpace(txtExpression.Text))
            {
                currentOperation = btn.Text;
                currentOperation = currentOperation == "Pow" ? "^" : currentOperation == "Mod" ? "%" : currentOperation; 
                txtExpression.Text += currentOperation;
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtExpression.Text = txtResult.Text = currentOperation = " ";
        }

        private void btnBackspace_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtExpression.Text)) 
            {
                if (!string.IsNullOrEmpty(currentOperation) && txtExpression.Text.Last() == currentOperation[0])
                {
                    btnAdd.Enabled = btnSubtract.Enabled = btnMultiply.Enabled = btnDivid.Enabled = btnPow.Enabled = btnMod.Enabled = true;
                    currentOperation = " ";
                }

                txtExpression.Text = txtExpression.Text.Remove(txtExpression.Text.Length - 1, 1);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            currentOperation = " ";
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            if (currentOperation == " ")
            {
                return;
            }

            if (txtExpression.Text.Last() == currentOperation[0])
            {
                return;
            }

            currentOperation = " ";
            
            if (txtResult.Text != "Cannot be divided by 0" && txtResult.Text != "Unknown operation" && txtResult.Text != "Calculation Error")
            {
                txtExpression.Text = txtResult.Text;
            }
        }

        private void btnThemeToggle_Click(object sender, EventArgs e)
        {
            if (this.BackColor == Color.White)
            {
                this.BackColor = Color.Black;
                btnThemeToggle.BackColor = Color.Black;
                btnThemeToggle.ForeColor = Color.White;
                btnThemeToggle.Text = "Light Mode";
                txtExpression.BackColor = Color.Black;
                txtResult.BackColor = Color.Black;
                txtExpression.ForeColor = Color.White;
                txtResult.ForeColor = Color.White;
            }
            else
            {
                this.BackColor = Color.White;
                btnThemeToggle.BackColor = Color.White;
                btnThemeToggle.ForeColor = Color.Black;
                btnThemeToggle.Text = "Dark Mode";
                txtExpression.BackColor = Color.White;
                txtResult.BackColor = Color.White;
                txtExpression.ForeColor = Color.Black;
                txtResult.ForeColor = Color.Black;
            }
        }

        private void txtExpression_TextChanged(object sender, EventArgs e)
        {
            txtResult.Text = "";

            if (currentOperation != " " && txtExpression.Text.Last() != currentOperation[0])
            {
                CalculateResult();
            }
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtExpression.Text) || txtExpression.Text.Last() == currentOperation[0])
            {
                txtExpression.Text += "0.";
                return;
            }

            if (char.IsDigit(txtExpression.Text.Last()))
            {
                if (currentOperation == " " && txtExpression.Text.IndexOf('.') != -1)
                {
                    return;
                }
                
                if (currentOperation != " " && (txtExpression.Text.Split(currentOperation[0]))[1].IndexOf('.') != -1)
                {
                    return;
                }

                txtExpression.Text += '.';
                return;
            }

            if (txtExpression.Text.Last() == '.')
            {
                return;
            }
        }

    }
}