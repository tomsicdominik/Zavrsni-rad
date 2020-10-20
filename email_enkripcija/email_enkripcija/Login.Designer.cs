namespace email_enkripcija
{
    partial class Login
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.inputFromAdress = new System.Windows.Forms.TextBox();
            this.inputPassword = new System.Windows.Forms.TextBox();
            this.inputFromName = new System.Windows.Forms.TextBox();
            this.inputPort = new System.Windows.Forms.TextBox();
            this.inputHost = new System.Windows.Forms.TextBox();
            this.inputPortRead = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Pošiljatelj adresa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Pošiljatelj ime";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Lozinka";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Izlazni port";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Host";
            // 
            // inputFromAdress
            // 
            this.inputFromAdress.Location = new System.Drawing.Point(178, 160);
            this.inputFromAdress.Name = "inputFromAdress";
            this.inputFromAdress.Size = new System.Drawing.Size(197, 20);
            this.inputFromAdress.TabIndex = 13;
            this.inputFromAdress.Text = "dtomsic@foi.hr";
            // 
            // inputPassword
            // 
            this.inputPassword.Location = new System.Drawing.Point(178, 188);
            this.inputPassword.Name = "inputPassword";
            this.inputPassword.PasswordChar = '*';
            this.inputPassword.Size = new System.Drawing.Size(197, 20);
            this.inputPassword.TabIndex = 14;
            // 
            // inputFromName
            // 
            this.inputFromName.Location = new System.Drawing.Point(178, 132);
            this.inputFromName.Name = "inputFromName";
            this.inputFromName.Size = new System.Drawing.Size(197, 20);
            this.inputFromName.TabIndex = 7;
            this.inputFromName.Text = "Dominik";
            // 
            // inputPort
            // 
            this.inputPort.Location = new System.Drawing.Point(178, 76);
            this.inputPort.Name = "inputPort";
            this.inputPort.Size = new System.Drawing.Size(197, 20);
            this.inputPort.TabIndex = 6;
            this.inputPort.Text = "25";
            // 
            // inputHost
            // 
            this.inputHost.Location = new System.Drawing.Point(178, 48);
            this.inputHost.Name = "inputHost";
            this.inputHost.Size = new System.Drawing.Size(197, 20);
            this.inputHost.TabIndex = 5;
            this.inputHost.Text = "mail.foi.hr";
            // 
            // inputPortRead
            // 
            this.inputPortRead.Location = new System.Drawing.Point(178, 104);
            this.inputPortRead.Name = "inputPortRead";
            this.inputPortRead.Size = new System.Drawing.Size(197, 20);
            this.inputPortRead.TabIndex = 6;
            this.inputPortRead.Text = "995";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(47, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "POP3 port";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(300, 228);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 15;
            this.btnLogin.Text = "Ulogiraj se";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 274);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inputFromAdress);
            this.Controls.Add(this.inputPassword);
            this.Controls.Add(this.inputPortRead);
            this.Controls.Add(this.inputFromName);
            this.Controls.Add(this.inputPort);
            this.Controls.Add(this.inputHost);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputFromAdress;
        private System.Windows.Forms.TextBox inputPassword;
        private System.Windows.Forms.TextBox inputFromName;
        private System.Windows.Forms.TextBox inputPort;
        private System.Windows.Forms.TextBox inputHost;
        private System.Windows.Forms.TextBox inputPortRead;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnLogin;
    }
}