namespace BD
{
    partial class ClientBank
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
            this.IdReg = new System.Windows.Forms.ComboBox();
            this.IdDev = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Create = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // IdReg
            // 
            this.IdReg.FormattingEnabled = true;
            this.IdReg.Location = new System.Drawing.Point(152, 16);
            this.IdReg.Name = "IdReg";
            this.IdReg.Size = new System.Drawing.Size(121, 21);
            this.IdReg.TabIndex = 0;
            // 
            // IdDev
            // 
            this.IdDev.FormattingEnabled = true;
            this.IdDev.Location = new System.Drawing.Point(152, 60);
            this.IdDev.Name = "IdDev";
            this.IdDev.Size = new System.Drawing.Size(121, 21);
            this.IdDev.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Регистрационный номер";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Номер события";
            // 
            // Create
            // 
            this.Create.Location = new System.Drawing.Point(89, 98);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(116, 36);
            this.Create.TabIndex = 4;
            this.Create.Text = "Сформировать";
            this.Create.UseVisualStyleBackColor = true;
            this.Create.Click += new System.EventHandler(this.Create_Click);
            // 
            // ClientBank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 146);
            this.Controls.Add(this.Create);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IdDev);
            this.Controls.Add(this.IdReg);
            this.Name = "ClientBank";
            this.Text = "ClientBank";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox IdReg;
        private System.Windows.Forms.ComboBox IdDev;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Create;
    }
}