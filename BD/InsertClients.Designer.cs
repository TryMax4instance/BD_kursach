namespace BD
{
    partial class InsertClients
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.IdComboBox = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.RegBox = new System.Windows.Forms.TextBox();
            this.OkButton = new System.Windows.Forms.Button();
            this.Id_Client = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Registration_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_Bet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchButton
            // 
            this.SearchButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.SearchButton.Location = new System.Drawing.Point(12, 60);
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
            this.SearchComboBox.Location = new System.Drawing.Point(12, 24);
            this.SearchComboBox.Name = "SearchComboBox";
            this.SearchComboBox.Size = new System.Drawing.Size(214, 21);
            this.SearchComboBox.TabIndex = 40;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 8);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(309, 13);
            this.label9.TabIndex = 39;
            this.label9.Text = "Выберите регистрационный номер клиента для изменения";
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
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Right;
            this.dataGridView1.Location = new System.Drawing.Point(332, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(365, 333);
            this.dataGridView1.TabIndex = 45;
            // 
            // IdComboBox
            // 
            this.IdComboBox.FormattingEnabled = true;
            this.IdComboBox.Location = new System.Drawing.Point(127, 150);
            this.IdComboBox.Name = "IdComboBox";
            this.IdComboBox.Size = new System.Drawing.Size(121, 21);
            this.IdComboBox.TabIndex = 50;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 153);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 13);
            this.label10.TabIndex = 49;
            this.label10.Text = "Номер ставки";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 118);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(133, 13);
            this.label11.TabIndex = 48;
            this.label11.Text = "Регистрационный номер";
            // 
            // RegBox
            // 
            this.RegBox.Location = new System.Drawing.Point(148, 115);
            this.RegBox.Name = "RegBox";
            this.RegBox.Size = new System.Drawing.Size(100, 20);
            this.RegBox.TabIndex = 47;
            // 
            // OkButton
            // 
            this.OkButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OkButton.Location = new System.Drawing.Point(12, 268);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(93, 47);
            this.OkButton.TabIndex = 46;
            this.OkButton.Text = "ОК";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
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
            // InsertClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 333);
            this.Controls.Add(this.IdComboBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.RegBox);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.SearchComboBox);
            this.Controls.Add(this.label9);
            this.Name = "InsertClients";
            this.Text = "InsertClients";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.ComboBox SearchComboBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox IdComboBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox RegBox;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Client;
        private System.Windows.Forms.DataGridViewTextBoxColumn Registration_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Bet;
    }
}