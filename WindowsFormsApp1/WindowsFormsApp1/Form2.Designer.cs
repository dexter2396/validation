namespace WindowsFormsApp1
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.username_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.email_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.password_txt = new System.Windows.Forms.TextBox();
            this.viewButton = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Controls.Add(this.viewButton);
            this.panel2.Controls.Add(this.password_txt);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.email_txt);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.username_txt);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(93, 26);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(559, 398);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username: ";
            // 
            // username_txt
            // 
            this.username_txt.Location = new System.Drawing.Point(109, 52);
            this.username_txt.Multiline = true;
            this.username_txt.Name = "username_txt";
            this.username_txt.ReadOnly = true;
            this.username_txt.Size = new System.Drawing.Size(428, 30);
            this.username_txt.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Email: ";
            // 
            // email_txt
            // 
            this.email_txt.Location = new System.Drawing.Point(109, 129);
            this.email_txt.Multiline = true;
            this.email_txt.Name = "email_txt";
            this.email_txt.ReadOnly = true;
            this.email_txt.Size = new System.Drawing.Size(420, 29);
            this.email_txt.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password: ";
            // 
            // password_txt
            // 
            this.password_txt.Location = new System.Drawing.Point(109, 224);
            this.password_txt.Multiline = true;
            this.password_txt.Name = "password_txt";
            this.password_txt.ReadOnly = true;
            this.password_txt.Size = new System.Drawing.Size(418, 30);
            this.password_txt.TabIndex = 5;
            // 
            // viewButton
            // 
            this.viewButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewButton.Location = new System.Drawing.Point(199, 313);
            this.viewButton.Name = "viewButton";
            this.viewButton.Size = new System.Drawing.Size(186, 47);
            this.viewButton.TabIndex = 6;
            this.viewButton.Text = "VIEW";
            this.viewButton.UseVisualStyleBackColor = true;
            this.viewButton.Click += new System.EventHandler(this.viewButton_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox username_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button viewButton;
        private System.Windows.Forms.TextBox password_txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox email_txt;
        private System.Windows.Forms.Label label2;
    }
}