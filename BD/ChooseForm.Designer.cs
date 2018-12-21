namespace BD
{
    partial class ChooseForm
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
            this.AgentButton = new System.Windows.Forms.Button();
            this.BetsButton = new System.Windows.Forms.Button();
            this.DevButton = new System.Windows.Forms.Button();
            this.ClientButton = new System.Windows.Forms.Button();
            this.DocButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AgentButton
            // 
            this.AgentButton.Location = new System.Drawing.Point(12, 12);
            this.AgentButton.Name = "AgentButton";
            this.AgentButton.Size = new System.Drawing.Size(75, 23);
            this.AgentButton.TabIndex = 0;
            this.AgentButton.Text = "Агенты";
            this.AgentButton.UseVisualStyleBackColor = true;
            this.AgentButton.Click += new System.EventHandler(this.AgentButton_Click);
            // 
            // BetsButton
            // 
            this.BetsButton.Location = new System.Drawing.Point(12, 80);
            this.BetsButton.Name = "BetsButton";
            this.BetsButton.Size = new System.Drawing.Size(75, 23);
            this.BetsButton.TabIndex = 1;
            this.BetsButton.Text = "Ставки";
            this.BetsButton.UseVisualStyleBackColor = true;
            this.BetsButton.Click += new System.EventHandler(this.BetsButton_Click);
            // 
            // DevButton
            // 
            this.DevButton.Location = new System.Drawing.Point(128, 12);
            this.DevButton.Name = "DevButton";
            this.DevButton.Size = new System.Drawing.Size(75, 23);
            this.DevButton.TabIndex = 2;
            this.DevButton.Text = "События";
            this.DevButton.UseVisualStyleBackColor = true;
            this.DevButton.Click += new System.EventHandler(this.DevButton_Click);
            // 
            // ClientButton
            // 
            this.ClientButton.Location = new System.Drawing.Point(128, 80);
            this.ClientButton.Name = "ClientButton";
            this.ClientButton.Size = new System.Drawing.Size(75, 23);
            this.ClientButton.TabIndex = 3;
            this.ClientButton.Text = "Клиенты";
            this.ClientButton.UseVisualStyleBackColor = true;
            this.ClientButton.Click += new System.EventHandler(this.ClientButton_Click);
            // 
            // DocButton
            // 
            this.DocButton.Location = new System.Drawing.Point(45, 125);
            this.DocButton.Name = "DocButton";
            this.DocButton.Size = new System.Drawing.Size(132, 23);
            this.DocButton.TabIndex = 4;
            this.DocButton.Text = "Выходные документы";
            this.DocButton.UseVisualStyleBackColor = true;
            this.DocButton.Click += new System.EventHandler(this.DocButton_Click);
            // 
            // ChooseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(215, 160);
            this.Controls.Add(this.DocButton);
            this.Controls.Add(this.ClientButton);
            this.Controls.Add(this.DevButton);
            this.Controls.Add(this.BetsButton);
            this.Controls.Add(this.AgentButton);
            this.Name = "ChooseForm";
            this.Text = "ChooseForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AgentButton;
        private System.Windows.Forms.Button BetsButton;
        private System.Windows.Forms.Button DevButton;
        private System.Windows.Forms.Button ClientButton;
        private System.Windows.Forms.Button DocButton;
    }
}