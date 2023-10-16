namespace Asynchronous_Programming
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
            txtBookOne = new TextBox();
            txtBookTwo = new TextBox();
            lblBookOne = new Label();
            lblBookTwo = new Label();
            btnBook1 = new Button();
            btnBookTwo = new Button();
            btnExit = new Button();
            btnSubmit = new Button();
            lstBox1 = new ListBox();
            lstBox2 = new ListBox();
            SuspendLayout();
            // 
            // txtBookOne
            // 
            txtBookOne.Location = new Point(136, 53);
            txtBookOne.Name = "txtBookOne";
            txtBookOne.Size = new Size(382, 31);
            txtBookOne.TabIndex = 0;
            // 
            // txtBookTwo
            // 
            txtBookTwo.Location = new Point(792, 57);
            txtBookTwo.Name = "txtBookTwo";
            txtBookTwo.Size = new Size(382, 31);
            txtBookTwo.TabIndex = 1;
            // 
            // lblBookOne
            // 
            lblBookOne.AutoSize = true;
            lblBookOne.Location = new Point(52, 59);
            lblBookOne.Name = "lblBookOne";
            lblBookOne.Size = new Size(68, 25);
            lblBookOne.TabIndex = 2;
            lblBookOne.Text = "Book 1";
            // 
            // lblBookTwo
            // 
            lblBookTwo.AutoSize = true;
            lblBookTwo.Location = new Point(707, 59);
            lblBookTwo.Name = "lblBookTwo";
            lblBookTwo.Size = new Size(68, 25);
            lblBookTwo.TabIndex = 3;
            lblBookTwo.Text = "Book 2";
            // 
            // btnBook1
            // 
            btnBook1.Location = new Point(536, 54);
            btnBook1.Name = "btnBook1";
            btnBook1.Size = new Size(112, 34);
            btnBook1.TabIndex = 4;
            btnBook1.Text = "Browse";
            btnBook1.UseVisualStyleBackColor = true;
            btnBook1.Click += btnBook1_Click;
            // 
            // btnBookTwo
            // 
            btnBookTwo.Location = new Point(1192, 57);
            btnBookTwo.Name = "btnBookTwo";
            btnBookTwo.Size = new Size(112, 34);
            btnBookTwo.TabIndex = 5;
            btnBookTwo.Text = "Browse";
            btnBookTwo.UseVisualStyleBackColor = true;
            btnBookTwo.Click += btnBookTwo_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(707, 127);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(112, 34);
            btnExit.TabIndex = 6;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(536, 127);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(113, 34);
            btnSubmit.TabIndex = 7;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // lstBox1
            // 
            lstBox1.FormattingEnabled = true;
            lstBox1.ItemHeight = 25;
            lstBox1.Location = new Point(52, 196);
            lstBox1.Name = "lstBox1";
            lstBox1.Size = new Size(594, 429);
            lstBox1.TabIndex = 8;
            lstBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // lstBox2
            // 
            lstBox2.FormattingEnabled = true;
            lstBox2.ItemHeight = 25;
            lstBox2.Location = new Point(707, 196);
            lstBox2.Name = "lstBox2";
            lstBox2.Size = new Size(632, 429);
            lstBox2.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1376, 698);
            Controls.Add(lstBox2);
            Controls.Add(lstBox1);
            Controls.Add(btnSubmit);
            Controls.Add(btnExit);
            Controls.Add(btnBookTwo);
            Controls.Add(btnBook1);
            Controls.Add(lblBookTwo);
            Controls.Add(lblBookOne);
            Controls.Add(txtBookTwo);
            Controls.Add(txtBookOne);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBookOne;
        private TextBox txtBookTwo;
        private Label lblBookOne;
        private Label lblBookTwo;
        private Button btnBook1;
        private Button btnBookTwo;
        private Button btnExit;
        private Button btnSubmit;
        private ListBox lstBox1;
        private ListBox lstBox2;
    }
}