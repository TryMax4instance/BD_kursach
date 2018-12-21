namespace BD
{
    partial class ManyDocs
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
            this.ClientBankbutton = new System.Windows.Forms.Button();
            this.BankRollbutton = new System.Windows.Forms.Button();
            this.ClientOrderbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ClientBankbutton
            // 
            this.ClientBankbutton.Location = new System.Drawing.Point(122, 24);
            this.ClientBankbutton.Name = "ClientBankbutton";
            this.ClientBankbutton.Size = new System.Drawing.Size(75, 23);
            this.ClientBankbutton.TabIndex = 0;
            this.ClientBankbutton.Text = "Открыть";
            this.ClientBankbutton.UseVisualStyleBackColor = true;
            this.ClientBankbutton.Click += new System.EventHandler(this.ClientBankbutton_Click);
            // 
            // BankRollbutton
            // 
            this.BankRollbutton.Location = new System.Drawing.Point(122, 79);
            this.BankRollbutton.Name = "BankRollbutton";
            this.BankRollbutton.Size = new System.Drawing.Size(75, 23);
            this.BankRollbutton.TabIndex = 1;
            this.BankRollbutton.Text = "Открыть";
            this.BankRollbutton.UseVisualStyleBackColor = true;
            this.BankRollbutton.Click += new System.EventHandler(this.BankRollbutton_Click);
            // 
            // ClientOrderbutton
            // 
            this.ClientOrderbutton.Location = new System.Drawing.Point(122, 134);
            this.ClientOrderbutton.Name = "ClientOrderbutton";
            this.ClientOrderbutton.Size = new System.Drawing.Size(75, 23);
            this.ClientOrderbutton.TabIndex = 2;
            this.ClientOrderbutton.Text = "Открыть";
            this.ClientOrderbutton.UseVisualStyleBackColor = true;
            this.ClientOrderbutton.Click += new System.EventHandler(this.ClientOrderbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Расчет клиента";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Справка о выручке";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Жетон клиента";
            // 
            // ManyDocs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(218, 180);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ClientOrderbutton);
            this.Controls.Add(this.BankRollbutton);
            this.Controls.Add(this.ClientBankbutton);
            this.Name = "ManyDocs";
            this.Text = "ManyDocs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ClientBankbutton;
        private System.Windows.Forms.Button BankRollbutton;
        private System.Windows.Forms.Button ClientOrderbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}