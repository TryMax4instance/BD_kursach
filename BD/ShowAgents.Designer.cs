namespace BD
{
    partial class ShowAgents
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.AddButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.InsertButton = new System.Windows.Forms.Button();
            this.UpdButton = new System.Windows.Forms.Button();
            this.ID_Agent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ASurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.APatronymic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Street = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HouseNumb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FlatNumb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PassData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Agent,
            this.ASurname,
            this.AName,
            this.APatronymic,
            this.Street,
            this.HouseNumb,
            this.FlatNumb,
            this.Number,
            this.PassData});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(954, 455);
            this.dataGridView1.TabIndex = 0;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(982, 74);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(93, 37);
            this.AddButton.TabIndex = 1;
            this.AddButton.Text = "Добавить агента";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(982, 134);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(93, 42);
            this.DeleteButton.TabIndex = 2;
            this.DeleteButton.Text = "Удалить агента";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // InsertButton
            // 
            this.InsertButton.Location = new System.Drawing.Point(982, 206);
            this.InsertButton.Name = "InsertButton";
            this.InsertButton.Size = new System.Drawing.Size(93, 34);
            this.InsertButton.TabIndex = 3;
            this.InsertButton.Text = "Изменить агента";
            this.InsertButton.UseVisualStyleBackColor = true;
            this.InsertButton.Click += new System.EventHandler(this.InsertButton_Click);
            // 
            // UpdButton
            // 
            this.UpdButton.Location = new System.Drawing.Point(982, 409);
            this.UpdButton.Name = "UpdButton";
            this.UpdButton.Size = new System.Drawing.Size(93, 34);
            this.UpdButton.TabIndex = 5;
            this.UpdButton.Text = "Обновить таблицу";
            this.UpdButton.UseVisualStyleBackColor = true;
            this.UpdButton.Click += new System.EventHandler(this.UpdButton_Click);
            // 
            // ID_Agent
            // 
            this.ID_Agent.HeaderText = "Код Агента";
            this.ID_Agent.Name = "ID_Agent";
            this.ID_Agent.ReadOnly = true;
            // 
            // ASurname
            // 
            this.ASurname.HeaderText = "Фамилия";
            this.ASurname.Name = "ASurname";
            this.ASurname.ReadOnly = true;
            // 
            // AName
            // 
            this.AName.HeaderText = "Имя";
            this.AName.Name = "AName";
            this.AName.ReadOnly = true;
            // 
            // APatronymic
            // 
            this.APatronymic.HeaderText = "Отчество";
            this.APatronymic.Name = "APatronymic";
            this.APatronymic.ReadOnly = true;
            // 
            // Street
            // 
            this.Street.HeaderText = "Улица";
            this.Street.Name = "Street";
            this.Street.ReadOnly = true;
            // 
            // HouseNumb
            // 
            this.HouseNumb.HeaderText = "Номер Дома";
            this.HouseNumb.Name = "HouseNumb";
            this.HouseNumb.ReadOnly = true;
            // 
            // FlatNumb
            // 
            this.FlatNumb.HeaderText = "Номер квартиры";
            this.FlatNumb.Name = "FlatNumb";
            this.FlatNumb.ReadOnly = true;
            // 
            // Number
            // 
            this.Number.HeaderText = "Телефон";
            this.Number.Name = "Number";
            this.Number.ReadOnly = true;
            // 
            // PassData
            // 
            this.PassData.HeaderText = "Данные паспорта";
            this.PassData.Name = "PassData";
            this.PassData.ReadOnly = true;
            // 
            // ShowAgents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 455);
            this.Controls.Add(this.UpdButton);
            this.Controls.Add(this.InsertButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ShowAgents";
            this.Text = "Агенты";
            this.Load += new System.EventHandler(this.ShowAgents_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button InsertButton;
        private System.Windows.Forms.Button UpdButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Agent;
        private System.Windows.Forms.DataGridViewTextBoxColumn ASurname;
        private System.Windows.Forms.DataGridViewTextBoxColumn AName;
        private System.Windows.Forms.DataGridViewTextBoxColumn APatronymic;
        private System.Windows.Forms.DataGridViewTextBoxColumn Street;
        private System.Windows.Forms.DataGridViewTextBoxColumn HouseNumb;
        private System.Windows.Forms.DataGridViewTextBoxColumn FlatNumb;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn PassData;
    }
}

