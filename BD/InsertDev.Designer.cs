namespace BD
{
    partial class InsertDev
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
            this.SearchButton = new System.Windows.Forms.Button();
            this.SearchComboBox = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.OkButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DevBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID_Dev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateDev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Result = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ResultComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchButton
            // 
            this.SearchButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.SearchButton.Location = new System.Drawing.Point(7, 52);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(93, 28);
            this.SearchButton.TabIndex = 42;
            this.SearchButton.Text = "Поиск";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // SearchComboBox
            // 
            this.SearchComboBox.FormattingEnabled = true;
            this.SearchComboBox.Location = new System.Drawing.Point(7, 25);
            this.SearchComboBox.Name = "SearchComboBox";
            this.SearchComboBox.Size = new System.Drawing.Size(214, 21);
            this.SearchComboBox.TabIndex = 40;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(218, 13);
            this.label9.TabIndex = 39;
            this.label9.Text = "Выберите номер события для изменения";
            // 
            // OkButton
            // 
            this.OkButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OkButton.Location = new System.Drawing.Point(12, 407);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(93, 47);
            this.OkButton.TabIndex = 38;
            this.OkButton.Text = "ОК";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 33;
            this.label6.Text = "Дата события";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "Событие";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 234);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Результат";
            // 
            // DevBox
            // 
            this.DevBox.Location = new System.Drawing.Point(121, 164);
            this.DevBox.Name = "DevBox";
            this.DevBox.Size = new System.Drawing.Size(91, 20);
            this.DevBox.TabIndex = 25;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Dev,
            this.Dev,
            this.DateDev,
            this.Result});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Right;
            this.dataGridView1.Location = new System.Drawing.Point(239, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(470, 466);
            this.dataGridView1.TabIndex = 45;
            // 
            // ID_Dev
            // 
            this.ID_Dev.HeaderText = "Номер события";
            this.ID_Dev.Name = "ID_Dev";
            this.ID_Dev.ReadOnly = true;
            // 
            // Dev
            // 
            this.Dev.HeaderText = "Событие";
            this.Dev.Name = "Dev";
            this.Dev.ReadOnly = true;
            // 
            // DateDev
            // 
            this.DateDev.HeaderText = "Дата события";
            this.DateDev.Name = "DateDev";
            this.DateDev.ReadOnly = true;
            // 
            // Result
            // 
            this.Result.HeaderText = "Результат";
            this.Result.Name = "Result";
            this.Result.ReadOnly = true;
            // 
            // DateTimePicker
            // 
            this.DateTimePicker.CustomFormat = "yyyy.MM.dd";
            this.DateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateTimePicker.Location = new System.Drawing.Point(121, 195);
            this.DateTimePicker.Name = "DateTimePicker";
            this.DateTimePicker.Size = new System.Drawing.Size(91, 20);
            this.DateTimePicker.TabIndex = 60;
            // 
            // ResultComboBox
            // 
            this.ResultComboBox.FormattingEnabled = true;
            this.ResultComboBox.Location = new System.Drawing.Point(121, 231);
            this.ResultComboBox.Name = "ResultComboBox";
            this.ResultComboBox.Size = new System.Drawing.Size(91, 21);
            this.ResultComboBox.TabIndex = 61;
            // 
            // InsertDev
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 466);
            this.Controls.Add(this.ResultComboBox);
            this.Controls.Add(this.DateTimePicker);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.SearchComboBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DevBox);
            this.Name = "InsertDev";
            this.Text = "InsertDev";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.ComboBox SearchComboBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox DevBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Dev;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dev;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateDev;
        private System.Windows.Forms.DataGridViewTextBoxColumn Result;
        private System.Windows.Forms.DateTimePicker DateTimePicker;
        private System.Windows.Forms.ComboBox ResultComboBox;
    }
}