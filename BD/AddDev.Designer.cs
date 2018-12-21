namespace BD
{
    partial class AddDev
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
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DevBox = new System.Windows.Forms.TextBox();
            this.DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ResultComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // OkButton
            // 
            this.OkButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OkButton.Location = new System.Drawing.Point(12, 121);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(93, 47);
            this.OkButton.TabIndex = 45;
            this.OkButton.Text = "ОК";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 44;
            this.label6.Text = "Дата события";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 43;
            this.label5.Text = "Событие";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 40;
            this.label2.Text = "Результат";
            // 
            // DevBox
            // 
            this.DevBox.Location = new System.Drawing.Point(126, 17);
            this.DevBox.Name = "DevBox";
            this.DevBox.Size = new System.Drawing.Size(100, 20);
            this.DevBox.TabIndex = 39;
            // 
            // DateTimePicker
            // 
            this.DateTimePicker.CustomFormat = "yyyy.MM.dd";
            this.DateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateTimePicker.Location = new System.Drawing.Point(126, 48);
            this.DateTimePicker.Name = "DateTimePicker";
            this.DateTimePicker.Size = new System.Drawing.Size(100, 20);
            this.DateTimePicker.TabIndex = 61;
            // 
            // ResultComboBox
            // 
            this.ResultComboBox.FormattingEnabled = true;
            this.ResultComboBox.Location = new System.Drawing.Point(126, 79);
            this.ResultComboBox.Name = "ResultComboBox";
            this.ResultComboBox.Size = new System.Drawing.Size(100, 21);
            this.ResultComboBox.TabIndex = 62;
            // 
            // AddDev
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 179);
            this.Controls.Add(this.ResultComboBox);
            this.Controls.Add(this.DateTimePicker);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DevBox);
            this.Name = "AddDev";
            this.Text = "AddDev";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox DevBox;
        private System.Windows.Forms.DateTimePicker DateTimePicker;
        private System.Windows.Forms.ComboBox ResultComboBox;
    }
}