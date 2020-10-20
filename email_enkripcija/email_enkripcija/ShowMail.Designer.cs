namespace email_enkripcija
{
    partial class ShowMail
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
            this.Poslao = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelContent = new System.Windows.Forms.RichTextBox();
            this.labelFrom = new System.Windows.Forms.TextBox();
            this.labelSubject = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Poslao
            // 
            this.Poslao.AutoSize = true;
            this.Poslao.Location = new System.Drawing.Point(23, 49);
            this.Poslao.Name = "Poslao";
            this.Poslao.Size = new System.Drawing.Size(42, 13);
            this.Poslao.TabIndex = 0;
            this.Poslao.Text = "Poslao:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Naslov";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Sadržaj:";
            // 
            // labelContent
            // 
            this.labelContent.Location = new System.Drawing.Point(79, 104);
            this.labelContent.Name = "labelContent";
            this.labelContent.ReadOnly = true;
            this.labelContent.Size = new System.Drawing.Size(689, 294);
            this.labelContent.TabIndex = 2;
            this.labelContent.Text = "";
            // 
            // labelFrom
            // 
            this.labelFrom.Location = new System.Drawing.Point(79, 46);
            this.labelFrom.Name = "labelFrom";
            this.labelFrom.ReadOnly = true;
            this.labelFrom.Size = new System.Drawing.Size(689, 20);
            this.labelFrom.TabIndex = 3;
            // 
            // labelSubject
            // 
            this.labelSubject.Location = new System.Drawing.Point(79, 73);
            this.labelSubject.Name = "labelSubject";
            this.labelSubject.ReadOnly = true;
            this.labelSubject.Size = new System.Drawing.Size(689, 20);
            this.labelSubject.TabIndex = 3;
            // 
            // ShowMail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelSubject);
            this.Controls.Add(this.labelFrom);
            this.Controls.Add(this.labelContent);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Poslao);
            this.Name = "ShowMail";
            this.Text = "ShowMail";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Poslao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox labelContent;
        private System.Windows.Forms.TextBox labelFrom;
        private System.Windows.Forms.TextBox labelSubject;
    }
}