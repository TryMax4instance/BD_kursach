namespace BD
{
    partial class ShowBets
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID_Bet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateBet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_Dev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CountBet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_Agent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UpdButton = new System.Windows.Forms.Button();
            this.InsertButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
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
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(790, 466);
            this.dataGridView1.TabIndex = 6;
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
            // UpdButton
            // 
            this.UpdButton.Location = new System.Drawing.Point(820, 420);
            this.UpdButton.Name = "UpdButton";
            this.UpdButton.Size = new System.Drawing.Size(93, 34);
            this.UpdButton.TabIndex = 10;
            this.UpdButton.Text = "Обновить таблицу";
            this.UpdButton.UseVisualStyleBackColor = true;
            this.UpdButton.Click += new System.EventHandler(this.UpdButton_Click);
            // 
            // InsertButton
            // 
            this.InsertButton.Location = new System.Drawing.Point(820, 217);
            this.InsertButton.Name = "InsertButton";
            this.InsertButton.Size = new System.Drawing.Size(93, 34);
            this.InsertButton.TabIndex = 9;
            this.InsertButton.Text = "Изменить ставку";
            this.InsertButton.UseVisualStyleBackColor = true;
            this.InsertButton.Click += new System.EventHandler(this.InsertButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(820, 145);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(93, 42);
            this.DeleteButton.TabIndex = 8;
            this.DeleteButton.Text = "Удалить ставку";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(820, 85);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(93, 37);
            this.AddButton.TabIndex = 7;
            this.AddButton.Text = "Добавить ставку";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // ShowBets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 466);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.UpdButton);
            this.Controls.Add(this.InsertButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.AddButton);
            this.Name = "ShowBets";
            this.Text = "ShowBets";
            this.Load += new System.EventHandler(this.ShowBets_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button UpdButton;
        private System.Windows.Forms.Button InsertButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Bet;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateBet;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Dev;
        private System.Windows.Forms.DataGridViewTextBoxColumn CountBet;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Agent;
    }
}