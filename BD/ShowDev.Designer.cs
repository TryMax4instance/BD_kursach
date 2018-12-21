namespace BD
{
    partial class ShowDev
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
            this.ID_Dev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateDev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Result = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.ID_Dev,
            this.Dev,
            this.DateDev,
            this.Result});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(470, 454);
            this.dataGridView1.TabIndex = 6;
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
            // UpdButton
            // 
            this.UpdButton.Location = new System.Drawing.Point(506, 386);
            this.UpdButton.Name = "UpdButton";
            this.UpdButton.Size = new System.Drawing.Size(93, 34);
            this.UpdButton.TabIndex = 10;
            this.UpdButton.Text = "Обновить таблицу";
            this.UpdButton.UseVisualStyleBackColor = true;
            this.UpdButton.Click += new System.EventHandler(this.UpdButton_Click);
            // 
            // InsertButton
            // 
            this.InsertButton.Location = new System.Drawing.Point(506, 183);
            this.InsertButton.Name = "InsertButton";
            this.InsertButton.Size = new System.Drawing.Size(93, 34);
            this.InsertButton.TabIndex = 9;
            this.InsertButton.Text = "Изменить событие";
            this.InsertButton.UseVisualStyleBackColor = true;
            this.InsertButton.Click += new System.EventHandler(this.InsertButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(506, 111);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(93, 42);
            this.DeleteButton.TabIndex = 8;
            this.DeleteButton.Text = "Удалить событие";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(506, 51);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(93, 37);
            this.AddButton.TabIndex = 7;
            this.AddButton.Text = "Добавить событие";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // ShowDev
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 454);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.UpdButton);
            this.Controls.Add(this.InsertButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.AddButton);
            this.Name = "ShowDev";
            this.Text = "ShowDev";
            this.Load += new System.EventHandler(this.ShowDev_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button UpdButton;
        private System.Windows.Forms.Button InsertButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Dev;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dev;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateDev;
        private System.Windows.Forms.DataGridViewTextBoxColumn Result;
    }
}