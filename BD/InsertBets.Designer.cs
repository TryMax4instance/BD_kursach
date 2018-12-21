namespace BD
{
    partial class InsertBets
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
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.RateBox = new System.Windows.Forms.TextBox();
            this.CountBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID_Bet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateBet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_Dev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CountBet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_Agent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AgentComboBox = new System.Windows.Forms.ComboBox();
            this.DevComboBox = new System.Windows.Forms.ComboBox();
            this.DateTimePicker = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchButton
            // 
            this.SearchButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.SearchButton.Location = new System.Drawing.Point(12, 50);
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
            this.SearchComboBox.Location = new System.Drawing.Point(12, 23);
            this.SearchComboBox.Name = "SearchComboBox";
            this.SearchComboBox.Size = new System.Drawing.Size(214, 21);
            this.SearchComboBox.TabIndex = 40;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 7);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(210, 13);
            this.label9.TabIndex = 39;
            this.label9.Text = "Выберите номер ставки для изменения";
            // 
            // OkButton
            // 
            this.OkButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OkButton.Location = new System.Drawing.Point(12, 401);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(93, 47);
            this.OkButton.TabIndex = 38;
            this.OkButton.Text = "ОК";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 236);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 37;
            this.label8.Text = "Код агента";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 197);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 35;
            this.label7.Text = "Коэффициент";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 13);
            this.label6.TabIndex = 33;
            this.label6.Text = "Номер события";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "Дата и время ставки";
            // 
            // RateBox
            // 
            this.RateBox.Location = new System.Drawing.Point(130, 194);
            this.RateBox.Name = "RateBox";
            this.RateBox.Size = new System.Drawing.Size(133, 20);
            this.RateBox.TabIndex = 30;
            // 
            // CountBox
            // 
            this.CountBox.Location = new System.Drawing.Point(130, 161);
            this.CountBox.Name = "CountBox";
            this.CountBox.Size = new System.Drawing.Size(133, 20);
            this.CountBox.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Размер ставки";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Bet,
            this.DateBet,
            this.Id_Dev,
            this.CountBet,
            this.Rate,
            this.Total,
            this.Id_Agent});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Right;
            this.dataGridView1.Location = new System.Drawing.Point(317, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(800, 450);
            this.dataGridView1.TabIndex = 45;
            // 
            // ID_Bet
            // 
            this.ID_Bet.HeaderText = "Номер Ставки";
            this.ID_Bet.Name = "ID_Bet";
            this.ID_Bet.ReadOnly = true;
            // 
            // DateBet
            // 
            this.DateBet.HeaderText = "Дата и время ставки";
            this.DateBet.Name = "DateBet";
            this.DateBet.ReadOnly = true;
            // 
            // Id_Dev
            // 
            this.Id_Dev.HeaderText = "Номер события";
            this.Id_Dev.Name = "Id_Dev";
            this.Id_Dev.ReadOnly = true;
            // 
            // CountBet
            // 
            this.CountBet.HeaderText = "Размер ставки";
            this.CountBet.Name = "CountBet";
            this.CountBet.ReadOnly = true;
            // 
            // Rate
            // 
            this.Rate.HeaderText = "Коэффициент";
            this.Rate.Name = "Rate";
            this.Rate.ReadOnly = true;
            // 
            // Total
            // 
            this.Total.HeaderText = "Итого";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // Id_Agent
            // 
            this.Id_Agent.HeaderText = "Код агента";
            this.Id_Agent.Name = "Id_Agent";
            this.Id_Agent.ReadOnly = true;
            // 
            // AgentComboBox
            // 
            this.AgentComboBox.FormattingEnabled = true;
            this.AgentComboBox.Location = new System.Drawing.Point(130, 233);
            this.AgentComboBox.Name = "AgentComboBox";
            this.AgentComboBox.Size = new System.Drawing.Size(133, 21);
            this.AgentComboBox.TabIndex = 46;
            // 
            // DevComboBox
            // 
            this.DevComboBox.FormattingEnabled = true;
            this.DevComboBox.Location = new System.Drawing.Point(130, 128);
            this.DevComboBox.Name = "DevComboBox";
            this.DevComboBox.Size = new System.Drawing.Size(133, 21);
            this.DevComboBox.TabIndex = 47;
            // 
            // DateTimePicker
            // 
            this.DateTimePicker.CustomFormat = "yyyy.MM.dd HH:mm:ss";
            this.DateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateTimePicker.Location = new System.Drawing.Point(130, 91);
            this.DateTimePicker.Name = "DateTimePicker";
            this.DateTimePicker.Size = new System.Drawing.Size(133, 20);
            this.DateTimePicker.TabIndex = 59;
            // 
            // InsertBets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 450);
            this.Controls.Add(this.DateTimePicker);
            this.Controls.Add(this.DevComboBox);
            this.Controls.Add(this.AgentComboBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.SearchComboBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.RateBox);
            this.Controls.Add(this.CountBox);
            this.Controls.Add(this.label2);
            this.Name = "InsertBets";
            this.Text = "InsertBets";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.ComboBox SearchComboBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox RateBox;
        private System.Windows.Forms.TextBox CountBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Bet;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateBet;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Dev;
        private System.Windows.Forms.DataGridViewTextBoxColumn CountBet;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Agent;
        private System.Windows.Forms.ComboBox AgentComboBox;
        private System.Windows.Forms.ComboBox DevComboBox;
        private System.Windows.Forms.DateTimePicker DateTimePicker;
    }
}