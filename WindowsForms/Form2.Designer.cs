namespace WindowsForms
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BottomToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.TopToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.RightToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.LeftToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.ContentPanel = new System.Windows.Forms.ToolStripContentPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.lblPrice = new System.Windows.Forms.Label();
            this.btnOpenGame = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblTheWinner = new System.Windows.Forms.Label();
            this.pizzaOrderControl1 = new WindowsForms.PizzaOrderControl();
            this.lblPizzaCount = new System.Windows.Forms.Label();
            this.lblWhereToEat = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BottomToolStripPanel
            // 
            this.BottomToolStripPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomToolStripPanel.Location = new System.Drawing.Point(0, 450);
            this.BottomToolStripPanel.Name = "BottomToolStripPanel";
            this.BottomToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.BottomToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.BottomToolStripPanel.Size = new System.Drawing.Size(800, 0);
            // 
            // TopToolStripPanel
            // 
            this.TopToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.TopToolStripPanel.Name = "TopToolStripPanel";
            this.TopToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.TopToolStripPanel.Padding = new System.Windows.Forms.Padding(0, 0, 25, 25);
            this.TopToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.TopToolStripPanel.Size = new System.Drawing.Size(800, 25);
            // 
            // RightToolStripPanel
            // 
            this.RightToolStripPanel.Location = new System.Drawing.Point(800, 25);
            this.RightToolStripPanel.Name = "RightToolStripPanel";
            this.RightToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.RightToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.RightToolStripPanel.Size = new System.Drawing.Size(0, 425);
            // 
            // LeftToolStripPanel
            // 
            this.LeftToolStripPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LeftToolStripPanel.Location = new System.Drawing.Point(0, 25);
            this.LeftToolStripPanel.Name = "LeftToolStripPanel";
            this.LeftToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.LeftToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.LeftToolStripPanel.Size = new System.Drawing.Size(0, 425);
            // 
            // ContentPanel
            // 
            this.ContentPanel.AutoScroll = true;
            this.ContentPanel.Size = new System.Drawing.Size(800, 425);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(383, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "GetTotalPrice";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(540, 17);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(64, 13);
            this.lblPrice.TabIndex = 6;
            this.lblPrice.Text = "PlayerName";
            // 
            // btnOpenGame
            // 
            this.btnOpenGame.Location = new System.Drawing.Point(30, 18);
            this.btnOpenGame.Name = "btnOpenGame";
            this.btnOpenGame.Size = new System.Drawing.Size(75, 23);
            this.btnOpenGame.TabIndex = 8;
            this.btnOpenGame.Text = "OpenGame";
            this.btnOpenGame.UseVisualStyleBackColor = true;
            this.btnOpenGame.Click += new System.EventHandler(this.BtnOpenGame_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(111, 18);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 9;
            // 
            // lblTheWinner
            // 
            this.lblTheWinner.AutoSize = true;
            this.lblTheWinner.Location = new System.Drawing.Point(217, 21);
            this.lblTheWinner.Name = "lblTheWinner";
            this.lblTheWinner.Size = new System.Drawing.Size(92, 13);
            this.lblTheWinner.TabIndex = 11;
            this.lblTheWinner.Text = "HowISTheWinner";
            // 
            // pizzaOrderControl1
            // 
            this.pizzaOrderControl1.Location = new System.Drawing.Point(52, 47);
            this.pizzaOrderControl1.Name = "pizzaOrderControl1";
            this.pizzaOrderControl1.Size = new System.Drawing.Size(712, 384);
            this.pizzaOrderControl1.TabIndex = 7;
            this.pizzaOrderControl1.OnOrderPushed += new System.EventHandler<WindowsForms.PizzaOrderControl.UCEventArgs>(this.PizzaOrderControl1_OnOrderPushed);
            // 
            // lblPizzaCount
            // 
            this.lblPizzaCount.AutoSize = true;
            this.lblPizzaCount.Location = new System.Drawing.Point(610, 18);
            this.lblPizzaCount.Name = "lblPizzaCount";
            this.lblPizzaCount.Size = new System.Drawing.Size(64, 13);
            this.lblPizzaCount.TabIndex = 12;
            this.lblPizzaCount.Text = "PlayerName";
            // 
            // lblWhereToEat
            // 
            this.lblWhereToEat.AutoSize = true;
            this.lblWhereToEat.Location = new System.Drawing.Point(680, 18);
            this.lblWhereToEat.Name = "lblWhereToEat";
            this.lblWhereToEat.Size = new System.Drawing.Size(64, 13);
            this.lblWhereToEat.TabIndex = 13;
            this.lblWhereToEat.Text = "PlayerName";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblWhereToEat);
            this.Controls.Add(this.lblPizzaCount);
            this.Controls.Add(this.lblTheWinner);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnOpenGame);
            this.Controls.Add(this.pizzaOrderControl1);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.button1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripPanel BottomToolStripPanel;
        private System.Windows.Forms.ToolStripPanel TopToolStripPanel;
        private System.Windows.Forms.ToolStripPanel RightToolStripPanel;
        private System.Windows.Forms.ToolStripPanel LeftToolStripPanel;
        private System.Windows.Forms.ToolStripContentPanel ContentPanel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblPrice;
        private PizzaOrderControl pizzaOrderControl1;
        private System.Windows.Forms.Button btnOpenGame;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblTheWinner;
        private System.Windows.Forms.Label lblPizzaCount;
        private System.Windows.Forms.Label lblWhereToEat;
    }
}