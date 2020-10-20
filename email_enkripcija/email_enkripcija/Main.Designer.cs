namespace email_enkripcija
{
    partial class Main
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.inputBody = new System.Windows.Forms.RichTextBox();
            this.inputToAdress = new System.Windows.Forms.TextBox();
            this.inputSubject = new System.Windows.Forms.TextBox();
            this.inputToName = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvMails = new System.Windows.Forms.DataGridView();
            this.btnShowMail = new System.Windows.Forms.Button();
            this.checkBoxCrypto = new System.Windows.Forms.CheckBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMails)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(765, 437);
            this.tabControl1.TabIndex = 10;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.checkBoxCrypto);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.btnSend);
            this.tabPage1.Controls.Add(this.inputBody);
            this.tabPage1.Controls.Add(this.inputToAdress);
            this.tabPage1.Controls.Add(this.inputSubject);
            this.tabPage1.Controls.Add(this.inputToName);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(757, 411);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Novi mail";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 125);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Sadržaj";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Naslov";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Primatelj adresa";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Primatelj ime";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(205, 359);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(543, 23);
            this.btnSend.TabIndex = 18;
            this.btnSend.Text = "Pošalji";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // inputBody
            // 
            this.inputBody.Location = new System.Drawing.Point(139, 122);
            this.inputBody.Name = "inputBody";
            this.inputBody.Size = new System.Drawing.Size(609, 231);
            this.inputBody.TabIndex = 17;
            this.inputBody.Text = "";
            // 
            // inputToAdress
            // 
            this.inputToAdress.Location = new System.Drawing.Point(139, 45);
            this.inputToAdress.Name = "inputToAdress";
            this.inputToAdress.Size = new System.Drawing.Size(609, 20);
            this.inputToAdress.TabIndex = 15;
            // 
            // inputSubject
            // 
            this.inputSubject.Location = new System.Drawing.Point(139, 71);
            this.inputSubject.Name = "inputSubject";
            this.inputSubject.Size = new System.Drawing.Size(609, 20);
            this.inputSubject.TabIndex = 16;
            // 
            // inputToName
            // 
            this.inputToName.Location = new System.Drawing.Point(139, 19);
            this.inputToName.Name = "inputToName";
            this.inputToName.Size = new System.Drawing.Size(609, 20);
            this.inputToName.TabIndex = 14;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnShowMail);
            this.tabPage2.Controls.Add(this.dgvMails);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(757, 411);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Inbox";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvMails
            // 
            this.dgvMails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMails.Location = new System.Drawing.Point(6, 24);
            this.dgvMails.Name = "dgvMails";
            this.dgvMails.Size = new System.Drawing.Size(745, 355);
            this.dgvMails.TabIndex = 0;
            // 
            // btnShowMail
            // 
            this.btnShowMail.Location = new System.Drawing.Point(564, 385);
            this.btnShowMail.Name = "btnShowMail";
            this.btnShowMail.Size = new System.Drawing.Size(187, 23);
            this.btnShowMail.TabIndex = 1;
            this.btnShowMail.Text = "Prikaži odabrani email";
            this.btnShowMail.UseVisualStyleBackColor = true;
            this.btnShowMail.Click += new System.EventHandler(this.btnShowMail_Click);
            // 
            // checkBoxCrypto
            // 
            this.checkBoxCrypto.AutoSize = true;
            this.checkBoxCrypto.Location = new System.Drawing.Point(139, 359);
            this.checkBoxCrypto.Name = "checkBoxCrypto";
            this.checkBoxCrypto.Size = new System.Drawing.Size(60, 17);
            this.checkBoxCrypto.TabIndex = 19;
            this.checkBoxCrypto.Text = "Kriptiraj";
            this.checkBoxCrypto.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.RichTextBox inputBody;
        private System.Windows.Forms.TextBox inputToAdress;
        private System.Windows.Forms.TextBox inputSubject;
        private System.Windows.Forms.TextBox inputToName;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvMails;
        private System.Windows.Forms.Button btnShowMail;
        private System.Windows.Forms.CheckBox checkBoxCrypto;
    }
}

