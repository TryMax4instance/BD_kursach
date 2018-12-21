namespace BD
{
    partial class AddBets
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
            this.OkButton = new System.Windows.Forms.Button();
            this.DevComboBox = new System.Windows.Forms.ComboBox();
            this.AgentComboBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.RateBox = new System.Windows.Forms.TextBox();
            this.CountBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // OkButton
            // 
            this.OkButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OkButton.Location = new System.Drawing.Point(68, 174);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(136, 47);
            this.OkButton.TabIndex = 33;
            this.OkButton.Text = "ОК";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // DevComboBox
            // 
            this.DevComboBox.FormattingEnabled = true;
            this.DevComboBox.Location = new System.Drawing.Point(130, 40);
            this.DevComboBox.Name = "DevComboBox";
            this.DevComboBox.Size = new System.Drawing.Size(133, 21);
            this.DevComboBox.TabIndex = 57;
            // 
            // AgentComboBox
            // 
            this.AgentComboBox.FormattingEnabled = true;
            this.AgentComboBox.Location = new System.Drawing.Point(130, 140);
            this.AgentComboBox.Name = "AgentComboBox";
            this.AgentComboBox.Size = new System.Drawing.Size(133, 21);
            this.AgentComboBox.TabIndex = 56;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 143);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 55;
            this.label8.Text = "Код агента";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 54;
            this.label7.Text = "Коэффициент";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 13);
            this.label6.TabIndex = 53;
            this.label6.Text = "Номер события";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 13);
            this.label5.TabIndex = 52;
            this.label5.Text = "Дата и время ставки";
            // 
            // RateBox
            // 
            this.RateBox.Location = new System.Drawing.Point(130, 106);
            this.RateBox.Name = "RateBox";
            this.RateBox.Size = new System.Drawing.Size(133, 20);
            this.RateBox.TabIndex = 51;
            // 
            // CountBox
            // 
            this.CountBox.Location = new System.Drawing.Point(130, 73);
            this.CountBox.Name = "CountBox";
            this.CountBox.Size = new System.Drawing.Size(133, 20);
            this.CountBox.TabIndex = 50;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 49;
            this.label2.Text = "Размер ставки";
            // 
            // DateTimePicker
            // 
            this.DateTimePicker.CustomFormat = "yyyy.MM.dd HH:mm:ss";
            this.DateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateTimePicker.Location = new System.Drawing.Point(130, 12);
            this.DateTimePicker.Name = "DateTimePicker";
            this.DateTimePicker.Size = new System.Drawing.Size(133, 20);
            this.DateTimePicker.TabIndex = 58;
            // 
            // AddBets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 233);
            this.Controls.Add(this.DateTimePicker);
            this.Controls.Add(this.DevComboBox);
            this.Controls.Add(this.AgentComboBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.RateBox);
            this.Controls.Add(this.CountBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.OkButton);
            this.Name = "AddBets";
            this.Text = "AddBets";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.ComboBox DevComboBox;
        private System.Windows.Forms.ComboBox AgentComboBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox RateBox;
        private System.Windows.Forms.TextBox CountBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker DateTimePicker;
    }
}