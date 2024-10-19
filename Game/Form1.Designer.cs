namespace Game
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblPlayerXScore = new Label();
            btnNewGame = new Button();
            btnReset = new Button();
            btnExit = new Button();
            label1 = new Label();
            label2 = new Label();
            lblPlayerOScore = new Label();
            SuspendLayout();
            // 
            // lblPlayerXScore
            // 
            lblPlayerXScore.AutoSize = true;
            lblPlayerXScore.BackColor = Color.White;
            lblPlayerXScore.Font = new Font("Segoe UI", 24F);
            lblPlayerXScore.Location = new Point(516, 53);
            lblPlayerXScore.Name = "lblPlayerXScore";
            lblPlayerXScore.Size = new Size(122, 54);
            lblPlayerXScore.TabIndex = 9;
            lblPlayerXScore.Text = "         ";
            lblPlayerXScore.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnNewGame
            // 
            btnNewGame.Font = new Font("Segoe UI", 25F);
            btnNewGame.Location = new Point(326, 167);
            btnNewGame.Name = "btnNewGame";
            btnNewGame.Size = new Size(312, 68);
            btnNewGame.TabIndex = 11;
            btnNewGame.Text = "New Game";
            btnNewGame.UseVisualStyleBackColor = true;
            btnNewGame.Click += btnNewGame_Click_1;
            // 
            // btnReset
            // 
            btnReset.Font = new Font("Segoe UI", 25F);
            btnReset.Location = new Point(326, 231);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(143, 66);
            btnReset.TabIndex = 12;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click_1;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Segoe UI", 25F);
            btnExit.Location = new Point(466, 231);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(172, 66);
            btnExit.TabIndex = 13;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(255, 192, 192);
            label1.Font = new Font("Segoe UI", 25F);
            label1.Location = new Point(321, 50);
            label1.Name = "label1";
            label1.Size = new Size(195, 57);
            label1.TabIndex = 14;
            label1.Text = "Player X :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(255, 192, 192);
            label2.Font = new Font("Segoe UI", 25F);
            label2.Location = new Point(326, 107);
            label2.Name = "label2";
            label2.Size = new Size(190, 57);
            label2.TabIndex = 15;
            label2.Text = "Player O:";
            // 
            // lblPlayerOScore
            // 
            lblPlayerOScore.AutoSize = true;
            lblPlayerOScore.BackColor = Color.White;
            lblPlayerOScore.Font = new Font("Segoe UI", 24F);
            lblPlayerOScore.Location = new Point(516, 110);
            lblPlayerOScore.Name = "lblPlayerOScore";
            lblPlayerOScore.Size = new Size(122, 54);
            lblPlayerOScore.TabIndex = 16;
            lblPlayerOScore.Text = "         ";
            lblPlayerOScore.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 192);
            ClientSize = new Size(655, 313);
            Controls.Add(lblPlayerOScore);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnExit);
            Controls.Add(btnReset);
            Controls.Add(btnNewGame);
            Controls.Add(lblPlayerXScore);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            RightToLeftLayout = true;
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblPlayerXScore;
        private Button btnNewGame;
        private Button btnReset;
        private Button btnExit;
        private Label label1;
        private Label label2;
        private Label lblPlayerOScore;
    }
}
