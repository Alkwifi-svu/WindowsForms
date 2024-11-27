using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Tracing;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class PizzaOrderControl : UserControl
    {
        public class UCEventArgs : EventArgs
        {
            public float TotalPrice { get; }
            public int PizzaCount { get; }
            public string WhereToEat { get; }

            public UCEventArgs(float totalPrice, int pizzaCount, string whereToEat)
            {
                TotalPrice = totalPrice;
                PizzaCount = pizzaCount;
                WhereToEat = whereToEat;
            }
        }

        public event EventHandler<UCEventArgs> OnOrderPushed;

        protected virtual void OrderPushed(UCEventArgs e)
        {
            OnOrderPushed?.Invoke(this, e);
        }

        private void OrderPushed(float totalPrice, int pizzaCount, string whereToEat)
        {
            OrderPushed(new UCEventArgs(totalPrice, pizzaCount, whereToEat));
        }

       
        /// <summary>
        /// Pizza hot
        /// </summary>
        public PizzaOrderControl()
        {
            InitializeComponent();
        }

        private float _totalPrice; 
        public float GetTotalPrice
        {
            get { return _totalPrice; }
        }

        public void Message(string message)
        {
            MessageBox.Show(message);
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
            _totalPrice = (GetSelectedPizzaSize() + GetSelectedCrustType() + CalculateToppings()) * CalculatePizzaCount();
            return _totalPrice;
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

            int pizzaCount = (int)nudPizzaCount.Value;
            string whereToEat = rbEatIn.Checked ? "Eat In" : "Take Out";

            //if (OnMakeOrder != null) MakeOrder(_totalPrice.ToString());
            if (OnOrderPushed != null) OrderPushed(_totalPrice, pizzaCount, whereToEat);
        }

        private void BtnRestOrder_Click(object sender, EventArgs e)
        {
            panOrderPizza.Enabled = true;

            ResetFrom();
        }
        private void NudPizzaCount_ValueChanged(object sender, EventArgs e)
        {
            UpdateTotalPrice();
        }

        private void PizzaOrderControl_Load(object sender, EventArgs e)
        {
            InitializeFrom();
        }
    }
}
