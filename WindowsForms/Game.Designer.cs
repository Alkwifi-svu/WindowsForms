namespace WindowsForms
{
    partial class Game
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPlayer = new System.Windows.Forms.Label();
            this.lblWinner = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnRestartGame = new System.Windows.Forms.Button();
            this.pb9 = new System.Windows.Forms.PictureBox();
            this.pb8 = new System.Windows.Forms.PictureBox();
            this.pb7 = new System.Windows.Forms.PictureBox();
            this.pb6 = new System.Windows.Forms.PictureBox();
            this.pb5 = new System.Windows.Forms.PictureBox();
            this.pb4 = new System.Windows.Forms.PictureBox();
            this.pb3 = new System.Windows.Forms.PictureBox();
            this.pb2 = new System.Windows.Forms.PictureBox();
            this.pb1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(374, 365);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(362, 42);
            this.label1.TabIndex = 9;
            this.label1.Text = "TIC-TAK-TOE [GAME]";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label2.Location = new System.Drawing.Point(113, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 42);
            this.label2.TabIndex = 10;
            this.label2.Text = "TURN";
            // 
            // lblPlayer
            // 
            this.lblPlayer.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer.ForeColor = System.Drawing.Color.White;
            this.lblPlayer.Location = new System.Drawing.Point(14, 96);
            this.lblPlayer.Name = "lblPlayer";
            this.lblPlayer.Size = new System.Drawing.Size(311, 42);
            this.lblPlayer.TabIndex = 11;
            this.lblPlayer.Text = "PLAYER 1";
            this.lblPlayer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblWinner
            // 
            this.lblWinner.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinner.ForeColor = System.Drawing.Color.Lime;
            this.lblWinner.Location = new System.Drawing.Point(32, 223);
            this.lblWinner.Name = "lblWinner";
            this.lblWinner.Size = new System.Drawing.Size(275, 42);
            this.lblWinner.TabIndex = 13;
            this.lblWinner.Text = "IN PROGRESS";
            this.lblWinner.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblWinner.TextChanged += new System.EventHandler(this.lblWinner_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label5.Location = new System.Drawing.Point(91, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 42);
            this.label5.TabIndex = 12;
            this.label5.Text = "WINNER";
            // 
            // btnRestartGame
            // 
            this.btnRestartGame.BackColor = System.Drawing.Color.Black;
            this.btnRestartGame.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestartGame.ForeColor = System.Drawing.Color.White;
            this.btnRestartGame.Location = new System.Drawing.Point(74, 352);
            this.btnRestartGame.Name = "btnRestartGame";
            this.btnRestartGame.Size = new System.Drawing.Size(190, 59);
            this.btnRestartGame.TabIndex = 14;
            this.btnRestartGame.Text = "RESTART GAME";
            this.btnRestartGame.UseVisualStyleBackColor = false;
            this.btnRestartGame.Click += new System.EventHandler(this.BtnRestartGame_Click);
            // 
            // pb9
            // 
            this.pb9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb9.Image = global::WindowsForms.Properties.Resources.White_Question_Mark;
            this.pb9.Location = new System.Drawing.Point(646, 264);
            this.pb9.Name = "pb9";
            this.pb9.Size = new System.Drawing.Size(70, 70);
            this.pb9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb9.TabIndex = 8;
            this.pb9.TabStop = false;
            this.pb9.Tag = "?";
            this.pb9.Click += new System.EventHandler(this.PictureBox_Click);
            // 
            // pb8
            // 
            this.pb8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb8.Image = global::WindowsForms.Properties.Resources.White_Question_Mark;
            this.pb8.Location = new System.Drawing.Point(518, 264);
            this.pb8.Name = "pb8";
            this.pb8.Size = new System.Drawing.Size(70, 70);
            this.pb8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb8.TabIndex = 7;
            this.pb8.TabStop = false;
            this.pb8.Tag = "?";
            this.pb8.Click += new System.EventHandler(this.PictureBox_Click);
            // 
            // pb7
            // 
            this.pb7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb7.Image = global::WindowsForms.Properties.Resources.White_Question_Mark;
            this.pb7.Location = new System.Drawing.Point(390, 264);
            this.pb7.Name = "pb7";
            this.pb7.Size = new System.Drawing.Size(70, 70);
            this.pb7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb7.TabIndex = 6;
            this.pb7.TabStop = false;
            this.pb7.Tag = "?";
            this.pb7.Click += new System.EventHandler(this.PictureBox_Click);
            // 
            // pb6
            // 
            this.pb6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb6.Image = global::WindowsForms.Properties.Resources.White_Question_Mark;
            this.pb6.Location = new System.Drawing.Point(646, 165);
            this.pb6.Name = "pb6";
            this.pb6.Size = new System.Drawing.Size(70, 70);
            this.pb6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb6.TabIndex = 5;
            this.pb6.TabStop = false;
            this.pb6.Tag = "?";
            this.pb6.Click += new System.EventHandler(this.PictureBox_Click);
            // 
            // pb5
            // 
            this.pb5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb5.Image = global::WindowsForms.Properties.Resources.White_Question_Mark;
            this.pb5.Location = new System.Drawing.Point(518, 165);
            this.pb5.Name = "pb5";
            this.pb5.Size = new System.Drawing.Size(70, 70);
            this.pb5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb5.TabIndex = 4;
            this.pb5.TabStop = false;
            this.pb5.Tag = "?";
            this.pb5.Click += new System.EventHandler(this.PictureBox_Click);
            // 
            // pb4
            // 
            this.pb4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb4.Image = global::WindowsForms.Properties.Resources.White_Question_Mark;
            this.pb4.Location = new System.Drawing.Point(390, 165);
            this.pb4.Name = "pb4";
            this.pb4.Size = new System.Drawing.Size(70, 70);
            this.pb4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb4.TabIndex = 3;
            this.pb4.TabStop = false;
            this.pb4.Tag = "?";
            this.pb4.Click += new System.EventHandler(this.PictureBox_Click);
            // 
            // pb3
            // 
            this.pb3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb3.Image = global::WindowsForms.Properties.Resources.White_Question_Mark;
            this.pb3.Location = new System.Drawing.Point(646, 68);
            this.pb3.Name = "pb3";
            this.pb3.Size = new System.Drawing.Size(70, 70);
            this.pb3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb3.TabIndex = 2;
            this.pb3.TabStop = false;
            this.pb3.Tag = "?";
            this.pb3.Click += new System.EventHandler(this.PictureBox_Click);
            // 
            // pb2
            // 
            this.pb2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb2.Image = global::WindowsForms.Properties.Resources.White_Question_Mark;
            this.pb2.Location = new System.Drawing.Point(518, 68);
            this.pb2.Name = "pb2";
            this.pb2.Size = new System.Drawing.Size(70, 70);
            this.pb2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb2.TabIndex = 1;
            this.pb2.TabStop = false;
            this.pb2.Tag = "?";
            this.pb2.Click += new System.EventHandler(this.PictureBox_Click);
            // 
            // pb1
            // 
            this.pb1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb1.Image = global::WindowsForms.Properties.Resources.White_Question_Mark;
            this.pb1.Location = new System.Drawing.Point(390, 68);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(70, 70);
            this.pb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb1.TabIndex = 0;
            this.pb1.TabStop = false;
            this.pb1.Tag = "?";
            this.pb1.Click += new System.EventHandler(this.PictureBox_Click);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRestartGame);
            this.Controls.Add(this.lblWinner);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblPlayer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pb9);
            this.Controls.Add(this.pb8);
            this.Controls.Add(this.pb7);
            this.Controls.Add(this.pb6);
            this.Controls.Add(this.pb5);
            this.Controls.Add(this.pb4);
            this.Controls.Add(this.pb3);
            this.Controls.Add(this.pb2);
            this.Controls.Add(this.pb1);
            this.Name = "Game";
            this.Text = "Game";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Game_FormClosed);
            this.Load += new System.EventHandler(this.Game_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Game_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pb9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb1;
        private System.Windows.Forms.PictureBox pb2;
        private System.Windows.Forms.PictureBox pb3;
        private System.Windows.Forms.PictureBox pb6;
        private System.Windows.Forms.PictureBox pb5;
        private System.Windows.Forms.PictureBox pb4;
        private System.Windows.Forms.PictureBox pb9;
        private System.Windows.Forms.PictureBox pb8;
        private System.Windows.Forms.PictureBox pb7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPlayer;
        private System.Windows.Forms.Label lblWinner;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnRestartGame;
    }
}