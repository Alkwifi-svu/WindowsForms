using ComponentFactory.Krypton.Toolkit;
using System;
using System.Drawing;
using System.Windows.Forms;
using WindowsForms.Properties;

namespace WindowsForms
{
    public partial class Form1 : KryptonForm
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void ResetFrom()
        {
            rbMeduim.Checked = true;
            rbThinCrust.Checked = true;
            rbEatIn.Checked = true;
            chkExtraChees.Checked = false;
            chkGreenPeppers.Checked = false;
            chkMushrooms.Checked = false;
            chkOlives.Checked = false;
            chkOnion.Checked = false;
            chkTometoes.Checked = false;
            nudPizzaCount.Value = 1;

            InitializeFrom();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeFrom();
        }

        private void InitializeFrom()
        {
            UpdateSize();
            UpdateToppings();
            UpdateCrust();
            UpdateTotalPrice();
        }


        private void UpdateTotalPrice()
        {
            lblTotalPrice.Text = "$" + CalculateTotalPrice().ToString();
        }

        private float CalculateTotalPrice()
        {
            return (GetSelectedPizzaSize() + GetSelectedCrustType() + CalculateToppings()) * CalculatePizzaCount();
        }

        private float CalculatePizzaCount()
        {
            return (float)nudPizzaCount.Value;
        }

        private float CalculateToppings()
        {
            float totalToppings = 0;

            if (chkExtraChees.Checked)
                totalToppings += Convert.ToSingle(chkExtraChees.Tag);

            if (chkGreenPeppers.Checked)
                totalToppings += Convert.ToSingle(chkGreenPeppers.Tag);

            if (chkMushrooms.Checked)
                totalToppings += Convert.ToSingle(chkMushrooms.Tag);

            if (chkOlives.Checked)
                totalToppings += Convert.ToSingle(chkOlives.Tag);

            if (chkOnion.Checked)
                totalToppings += Convert.ToSingle(chkOnion.Tag);

            if (chkTometoes.Checked)
                totalToppings += Convert.ToSingle(chkTometoes.Tag);

            return totalToppings;
        }

        private float GetSelectedCrustType()
        {
            if (rbThikCrust.Checked)
            {
                return Convert.ToSingle(rbThikCrust.Tag);
            }

            if (rbThinCrust.Checked)
            {
                return Convert.ToSingle(rbThinCrust.Tag);
            }

            return 0;
        }

        private float GetSelectedPizzaSize()
        {
            if (rbSmall.Checked)
            {
                return Convert.ToSingle(rbSmall.Tag);
            }

            if (rbMeduim.Checked)
            {
                return Convert.ToSingle(rbMeduim.Tag);
            }

            if (rbLarge.Checked)
            {
                return Convert.ToSingle(rbLarge.Tag);
            }

            return 0;
        }

        private void UpdateCrust()
        {
            if (rbThikCrust.Checked)
            {
                lblCrustType.Text = rbThikCrust.Text;
                return;
            }

            if (rbThinCrust.Checked)
            {
                lblCrustType.Text = rbThinCrust.Text;
                return;
            }
        }

        private void UpdateToppings()
        {
            string totalToppings = "";

            if (chkExtraChees.Checked)
                totalToppings += chkExtraChees.Text + ", ";

            if (chkGreenPeppers.Checked)
                totalToppings += chkGreenPeppers.Text + ", ";

            if (chkMushrooms.Checked)
                totalToppings += chkMushrooms.Text + ", ";

            if (chkOlives.Checked)
                totalToppings += chkOlives.Text + ", ";

            if (chkOnion.Checked)
                totalToppings += chkOnion.Text + ", ";

            if (chkTometoes.Checked)
                totalToppings += chkTometoes.Text;

            lblToppings.Text = totalToppings.Length > 0 ? totalToppings : "No Toppings";
        }

        private void UpdateSize()
        {
            if (rbLarge.Checked)
            {
                lblPizzaSize.Text = rbLarge.Text;
                return;
            }

            if (rbMeduim.Checked)
            {
                lblPizzaSize.Text = rbMeduim.Text;
                return;
            }

            if (rbSmall.Checked)
            {
                lblPizzaSize.Text = rbSmall.Text;
                return;
            }
        }

        private void UpdateWhereToEat()
        {
            if (rbEatIn.Checked)
            {
                lblWhereToEat.Text = rbEatIn.Text;
                return;
            }

            if (rbTakeOut.Checked)
            {
                lblWhereToEat.Text = rbTakeOut.Text;
                return;
            }

        }

        private void RbLarge_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTotalPrice();
            UpdateSize();
        }

        private void RbMeduim_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTotalPrice();
            UpdateSize();
        }

        private void RbSmall_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTotalPrice();
            UpdateSize();
        }

        private void RbThinCrust_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTotalPrice();
            UpdateCrust();
        }

        private void RbThikCrust_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTotalPrice();
            UpdateCrust();
        }

        private void RbEatIn_CheckedChanged(object sender, EventArgs e)
        {
            UpdateWhereToEat();
        }

        private void RbTakeOut_CheckedChanged(object sender, EventArgs e)
        {
            UpdateWhereToEat();
        }

        private void BtnOrderPizza_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pizza Ordered Sucssusfully", "Pizza Order", MessageBoxButtons.OK, MessageBoxIcon.Information);
            panOrderPizza.Enabled = false;
        }

        private void BtnRestOrder_Click(object sender, EventArgs e)
        {
            panOrderPizza.Enabled = true;

            ResetFrom();
        }

        private void ChkExtraChees_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTotalPrice();
            UpdateToppings();
        }

        private void ChkOnion_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTotalPrice();
            UpdateToppings();
        }

        private void ChkMushrooms_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTotalPrice();
            UpdateToppings();
        }

        private void ChkOlives_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTotalPrice();
            UpdateToppings();
        }

        private void ChkTometoes_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTotalPrice();
            UpdateToppings();
        }

        private void ChkGreenPeppers_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTotalPrice();
            UpdateToppings();
        }

        private void NudPizzaCount_ValueChanged(object sender, EventArgs e)
        {
            UpdateTotalPrice();
        }
    }
}
