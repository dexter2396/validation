namespace WindowsFormsApp1
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.username_txtbox = new System.Windows.Forms.TextBox();
            this.username_validation = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.email_txtbox = new System.Windows.Forms.TextBox();
            this.email_validation = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.password_txtbox = new System.Windows.Forms.TextBox();
            this.password_validation = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.confirmpass_txtbox = new System.Windows.Forms.TextBox();
            this.confirmpass_validation = new System.Windows.Forms.Label();
            this.SignupButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.SignupButton);
            this.panel1.Controls.Add(this.confirmpass_validation);
            this.panel1.Controls.Add(this.confirmpass_txtbox);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.password_validation);
            this.panel1.Controls.Add(this.password_txtbox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.email_validation);
            this.panel1.Controls.Add(this.email_txtbox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.username_validation);
            this.panel1.Controls.Add(this.username_txtbox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(82, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(324, 399);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(116, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "SIGN UP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 57);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(78, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // username_txtbox
            // 
            this.username_txtbox.Location = new System.Drawing.Point(18, 76);
            this.username_txtbox.Name = "username_txtbox";
            this.username_txtbox.Size = new System.Drawing.Size(285, 20);
            this.username_txtbox.TabIndex = 2;
            this.username_txtbox.TextChanged += new System.EventHandler(this.username_txtbox_TextChanged);
            // 
            // username_validation
            // 
            this.username_validation.AutoSize = true;
            this.username_validation.ForeColor = System.Drawing.Color.Red;
            this.username_validation.Location = new System.Drawing.Point(28, 99);
            this.username_validation.Name = "username_validation";
            this.username_validation.Size = new System.Drawing.Size(106, 13);
            this.username_validation.TabIndex = 3;
            this.username_validation.Text = "Username is required";
            this.username_validation.Visible = false;
            this.username_validation.Click += new System.EventHandler(this.username_validation_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Email";
            // 
            // email_txtbox
            // 
            this.email_txtbox.Location = new System.Drawing.Point(18, 140);
            this.email_txtbox.Name = "email_txtbox";
            this.email_txtbox.Size = new System.Drawing.Size(285, 20);
            this.email_txtbox.TabIndex = 5;
            this.email_txtbox.TextChanged += new System.EventHandler(this.email_txtbox_TextChanged);
            // 
            // email_validation
            // 
            this.email_validation.AutoSize = true;
            this.email_validation.ForeColor = System.Drawing.Color.Red;
            this.email_validation.Location = new System.Drawing.Point(28, 163);
            this.email_validation.Name = "email_validation";
            this.email_validation.Size = new System.Drawing.Size(83, 13);
            this.email_validation.TabIndex = 6;
            this.email_validation.Text = "Email is required";
            this.email_validation.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Password";
            // 
            // password_txtbox
            // 
            this.password_txtbox.Location = new System.Drawing.Point(18, 206);
            this.password_txtbox.Name = "password_txtbox";
            this.password_txtbox.PasswordChar = '*';
            this.password_txtbox.Size = new System.Drawing.Size(285, 20);
            this.password_txtbox.TabIndex = 8;
            this.password_txtbox.TextChanged += new System.EventHandler(this.password_txtbox_TextChanged);
            // 
            // password_validation
            // 
            this.password_validation.AutoSize = true;
            this.password_validation.ForeColor = System.Drawing.Color.Red;
            this.password_validation.Location = new System.Drawing.Point(28, 229);
            this.password_validation.Name = "password_validation";
            this.password_validation.Size = new System.Drawing.Size(104, 13);
            this.password_validation.TabIndex = 9;
            this.password_validation.Text = "Password is required";
            this.password_validation.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 257);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Confirm Password";
            // 
            // confirmpass_txtbox
            // 
            this.confirmpass_txtbox.Location = new System.Drawing.Point(18, 276);
            this.confirmpass_txtbox.Name = "confirmpass_txtbox";
            this.confirmpass_txtbox.PasswordChar = '*';
            this.confirmpass_txtbox.Size = new System.Drawing.Size(280, 20);
            this.confirmpass_txtbox.TabIndex = 11;
            this.confirmpass_txtbox.TextChanged += new System.EventHandler(this.confirmpass_txtbox_TextChanged);
            // 
            // confirmpass_validation
            // 
            this.confirmpass_validation.AutoSize = true;
            this.confirmpass_validation.ForeColor = System.Drawing.Color.Red;
            this.confirmpass_validation.Location = new System.Drawing.Point(28, 299);
            this.confirmpass_validation.Name = "confirmpass_validation";
            this.confirmpass_validation.Size = new System.Drawing.Size(122, 13);
            this.confirmpass_validation.TabIndex = 12;
            this.confirmpass_validation.Text = "Password doesn\'t match";
            this.confirmpass_validation.Visible = false;
            // 
            // SignupButton
            // 
            this.SignupButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignupButton.Location = new System.Drawing.Point(93, 347);
            this.SignupButton.Name = "SignupButton";
            this.SignupButton.Size = new System.Drawing.Size(139, 32);
            this.SignupButton.TabIndex = 13;
            this.SignupButton.Text = "SIGN UP";
            this.SignupButton.UseVisualStyleBackColor = true;
            this.SignupButton.Click += new System.EventHandler(this.SignupButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label username_validation;
        private System.Windows.Forms.TextBox username_txtbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox password_txtbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label email_validation;
        private System.Windows.Forms.TextBox email_txtbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label password_validation;
        private System.Windows.Forms.Label confirmpass_validation;
        private System.Windows.Forms.TextBox confirmpass_txtbox;
        private System.Windows.Forms.Button SignupButton;
    }
}

