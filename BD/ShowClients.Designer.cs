﻿namespace BD
{
    partial class ShowClients
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
            this.UpdButton = new System.Windows.Forms.Button();
            this.InsertButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id_Client = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Registration_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_Bet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // UpdButton
            // 
            this.UpdButton.Location = new System.Drawing.Point(370, 371);
            this.UpdButton.Name = "UpdButton";
            this.UpdButton.Size = new System.Drawing.Size(93, 34);
            this.UpdButton.TabIndex = 10;
            this.UpdButton.Text = "Обновить таблицу";
            this.UpdButton.UseVisualStyleBackColor = true;
            this.UpdButton.Click += new System.EventHandler(this.UpdButton_Click_1);
            // 
            // InsertButton
            // 
            this.InsertButton.Location = new System.Drawing.Point(370, 168);
            this.InsertButton.Name = "InsertButton";
            this.InsertButton.Size = new System.Drawing.Size(93, 34);
            this.InsertButton.TabIndex = 9;
            this.InsertButton.Text = "Изменить клиента";
            this.InsertButton.UseVisualStyleBackColor = true;
            this.InsertButton.Click += new System.EventHandler(this.InsertButton_Click_1);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(370, 96);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(93, 42);
            this.DeleteButton.TabIndex = 8;
            this.DeleteButton.Text = "Удалить клиента";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click_1);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(370, 36);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(93, 37);
            this.AddButton.TabIndex = 7;
            this.AddButton.Text = "Добавить клиента";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_Client,
            this.Registration_number,
            this.ID_Bet});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(346, 417);
            this.dataGridView1.TabIndex = 6;
            // 
            // Id_Client
            // 
            this.Id_Client.HeaderText = "Код Клиента";
            this.Id_Client.Name = "Id_Client";
            this.Id_Client.ReadOnly = true;
            // 
            // Registration_number
            // 
            this.Registration_number.HeaderText = "Регистрационный номер";
            this.Registration_number.Name = "Registration_number";
            this.Registration_number.ReadOnly = true;
            // 
            // ID_Bet
            // 
            this.ID_Bet.HeaderText = "Номер ставки";
            this.ID_Bet.Name = "ID_Bet";
            this.ID_Bet.ReadOnly = true;
            // 
            // ShowClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 417);
            this.Controls.Add(this.UpdButton);
            this.Controls.Add(this.InsertButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ShowClients";
            this.Text = "ShowClient";
            this.Load += new System.EventHandler(this.ShowClients_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button UpdButton;
        private System.Windows.Forms.Button InsertButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Client;
        private System.Windows.Forms.DataGridViewTextBoxColumn Registration_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Bet;
    }
}