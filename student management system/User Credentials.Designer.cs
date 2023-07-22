namespace student_management_system
{
    partial class userCredentials_Form
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
            this.userName_textBox = new System.Windows.Forms.TextBox();
            this.userName_label = new System.Windows.Forms.Label();
            this.logIn_button = new System.Windows.Forms.Button();
            this.password_label = new System.Windows.Forms.Label();
            this.password_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // userName_textBox
            // 
            this.userName_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userName_textBox.Location = new System.Drawing.Point(540, 272);
            this.userName_textBox.Name = "userName_textBox";
            this.userName_textBox.Size = new System.Drawing.Size(310, 55);
            this.userName_textBox.TabIndex = 0;
            // 
            // userName_label
            // 
            this.userName_label.AutoSize = true;
            this.userName_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userName_label.Location = new System.Drawing.Point(532, 198);
            this.userName_label.Name = "userName_label";
            this.userName_label.Size = new System.Drawing.Size(230, 48);
            this.userName_label.TabIndex = 1;
            this.userName_label.Text = "User Name";
            // 
            // logIn_button
            // 
            this.logIn_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logIn_button.Location = new System.Drawing.Point(540, 591);
            this.logIn_button.Name = "logIn_button";
            this.logIn_button.Size = new System.Drawing.Size(310, 68);
            this.logIn_button.TabIndex = 2;
            this.logIn_button.Text = "Log In";
            this.logIn_button.UseVisualStyleBackColor = true;
            this.logIn_button.Click += new System.EventHandler(this.logIn_button_Click);
            // 
            // password_label
            // 
            this.password_label.AutoSize = true;
            this.password_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_label.Location = new System.Drawing.Point(532, 402);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(203, 48);
            this.password_label.TabIndex = 4;
            this.password_label.Text = "Password";
            // 
            // password_textBox
            // 
            this.password_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_textBox.Location = new System.Drawing.Point(540, 472);
            this.password_textBox.Name = "password_textBox";
            this.password_textBox.Size = new System.Drawing.Size(310, 55);
            this.password_textBox.TabIndex = 3;
            this.password_textBox.TextChanged += new System.EventHandler(this.password_textBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(299, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(613, 95);
            this.label1.TabIndex = 5;
            this.label1.Text = "Bufon\'s School";
            // 
            // userCredentials_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1283, 743);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.password_label);
            this.Controls.Add(this.password_textBox);
            this.Controls.Add(this.logIn_button);
            this.Controls.Add(this.userName_label);
            this.Controls.Add(this.userName_textBox);
            this.Name = "userCredentials_Form";
            this.Text = "User Credentials";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.userCredentials_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox userName_textBox;
        private System.Windows.Forms.Label userName_label;
        private System.Windows.Forms.Button logIn_button;
        private System.Windows.Forms.Label password_label;
        private System.Windows.Forms.TextBox password_textBox;
        private System.Windows.Forms.Label label1;
    }
}

