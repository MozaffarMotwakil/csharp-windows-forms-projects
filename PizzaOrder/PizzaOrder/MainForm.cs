using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaOrder
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateTotalPrice();
        }

        private float CalculateToppingsPrice()
        {
            float toppingsTotalPrice = 0;

            if (chkExtraChees.Checked)
            {
                toppingsTotalPrice += Convert.ToSingle(chkExtraChees.Tag);
            }

            if (chkGreenPeppers.Checked)
            {
                toppingsTotalPrice += Convert.ToSingle(chkGreenPeppers.Tag);
            }

            if (chkMushrooms.Checked)
            {
                toppingsTotalPrice += Convert.ToSingle(chkMushrooms.Tag);
            }

            if (chkOlives.Checked)
            {
                toppingsTotalPrice += Convert.ToSingle(chkOlives.Tag);
            }

            if (chkOnion.Checked)
            {
                toppingsTotalPrice += Convert.ToSingle(chkOnion.Tag);
            }

            if (chkTomatoes.Checked)
            {
                toppingsTotalPrice += Convert.ToSingle(chkTomatoes.Tag);
            }

            return toppingsTotalPrice;
        }

        private float GetSelectedCrustPrice()
        {
            if (rbThin.Checked)
            {
                return Convert.ToSingle(rbThin.Tag);
            }
            
            if (rbThick.Checked)
            {
                return Convert.ToSingle(rbThick.Tag);
            }

            return 0;
        }

        private float GetSelectedSizePrice()
        {
            if (rbSmall.Checked)
            {
                return Convert.ToSingle(rbSmall.Tag);
            }

            if (rbMeduim.Checked)
            {
                return Convert.ToSingle(rbMeduim.Tag);
            }

            if (rbLarg.Checked)
            {
                return Convert.ToSingle(rbLarg.Tag);
            }

            return 0;
        }

        private float CalculateTotalPrice()
        {
            return (GetSelectedSizePrice() + GetSelectedCrustPrice() + CalculateToppingsPrice()) * (float)nudQuantity.Value;
        }

        private void UpdateTotalPrice()
        {
            lblEndTotalPrice.Text = "$" + CalculateTotalPrice().ToString();
        }

        private void UpdateSize()
        {
            UpdateTotalPrice();

            if (rbSmall.Checked)
            {
                lblEndSize.Text = rbSmall.Text;
                return;
            }

            if (rbMeduim.Checked)
            {
                lblEndSize.Text = rbMeduim.Text;
                return;
            }

            if (rbLarg.Checked)
            {
                lblEndSize.Text = rbLarg.Text;
                return;
            }

        }

        private void rbSmall_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void rbMeduim_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void rbLarg_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void UpdateCrust()
        {
            UpdateTotalPrice();

            if (rbThin.Checked)
            {
                lblEndCrustType.Text = rbThin.Text;
                return;
            }

            if (rbThick.Checked)
            {
                lblEndCrustType.Text = rbThick.Text;
                return;
            }

        }

        private void rbThin_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrust();
        }

        private void rbThick_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrust();
        }

        private void UpdateWhereToEat()
        {
            if (rbEatIn.Checked)
            {
                lblEndEatPlace.Text = rbEatIn.Text;
                return;
            }

            if (rbTakeOut.Checked)
            {
                lblEndEatPlace.Text = rbTakeOut.Text;
                return;
            }
        }

        private void rbEatIn_CheckedChanged(object sender, EventArgs e)
        {
            UpdateWhereToEat();
        }

        private void rbTakeOut_CheckedChanged(object sender, EventArgs e)
        {
            UpdateWhereToEat();
        }

        private void UpdateToppings()
        {
            UpdateTotalPrice();

            string strToppings = "";

            if (chkExtraChees.Checked)
            {
                strToppings += ", " + chkExtraChees.Text;
            }

            if (chkGreenPeppers.Checked)
            {
                strToppings += ", " + chkGreenPeppers.Text;
            }

            if (chkMushrooms.Checked)
            {
                strToppings += ", " + chkMushrooms.Text;
            }

            if (chkOlives.Checked)
            {
                strToppings += ", " + chkOlives.Text;
            }

            if (chkOnion.Checked)
            {
                strToppings += ", " + chkOnion.Text;
            }

            if (chkTomatoes.Checked)
            {
                strToppings += ", " + chkTomatoes.Text;
            }

            if (strToppings.StartsWith(","))
            {
                strToppings = strToppings.Remove(0, 1).Trim();
            }

            if (string.IsNullOrEmpty(strToppings))
            {
                strToppings = "No Toppings";
            }

            lblEndToppings.Text = strToppings;
        }

        private void chkExtraChees_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkMushrooms_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkTomatoes_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkOnion_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkOlives_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkGreenPeppers_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void btnOrderPizza_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirm Order", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                MessageBox.Show("Order PLaced Seccussfuly", "Seccess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Make all group boxes disable
                gbSize.Enabled = false;
                gbCrustType.Enabled = false;
                gbEatPlace.Enabled = false;
                gbToppings.Enabled = false;

                // Make "Order Pizza" button disable
                btnOrderPizza.Enabled = false;
            }
        }

        private void ResetForm()
        {
            // Reset All Toppings
            chkExtraChees.Checked = false;
            chkGreenPeppers.Checked = false;
            chkMushrooms.Checked = false;
            chkOlives.Checked = false;
            chkOnion.Checked = false;
            chkTomatoes.Checked = false;

            // Reset size to "Small" because samll is default
            rbSmall.Checked = true;
            
            // Reset crust to "Thin" because thin is default
            rbThin.Checked = true;
            
            // Reset Eating place To "Eat In" because eat in is default
            rbEatIn.Checked = true;

            // Make all group boxes enable
            gbSize.Enabled = true;
            gbCrustType.Enabled = true;
            gbEatPlace.Enabled = true;
            gbToppings.Enabled = true;

            // Make "Order Pizza" button enable
            btnOrderPizza.Enabled = true;
        }

        private void btnResetForm_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void nudQuantity_ValueChanged(object sender, EventArgs e)
        {
            UpdateTotalPrice();
        }

    }
}