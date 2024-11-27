using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblPrice.Text = pizzaOrderControl1.GetTotalPrice.ToString();
        }

        private void BtnOpenGame_Click(object sender, EventArgs e)
        {
            Game game = new Game(textBox1.Text);

            game.DataBack += SelectTheWinner;

            game.ShowDialog();
        }

        private void SelectTheWinner(string theWinner)
        {
            lblTheWinner.Text = theWinner;
        }

        private void PizzaOrderControl1_OnOrderPushed(object sender, PizzaOrderControl.UCEventArgs e)
        {
            lblPrice.Text = e.TotalPrice.ToString();
            lblPizzaCount.Text = e.PizzaCount.ToString();
            lblWhereToEat.Text = e.WhereToEat;
            this.BackColor = Color.FloralWhite;
        }
        
    }
}
