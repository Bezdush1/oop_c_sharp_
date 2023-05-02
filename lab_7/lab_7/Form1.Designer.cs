namespace lab_7
{
    partial class Form1
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
            this.ButtonClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ButtonCreateObject = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.numericNumberTrain = new System.Windows.Forms.NumericUpDown();
            this.textBoxToilet = new System.Windows.Forms.TextBox();
            this.textBoxBuffet = new System.Windows.Forms.TextBox();
            this.textBoxCargoComponents = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ButtonClearDataGridView = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericNumberTrain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonClose
            // 
            this.ButtonClose.Location = new System.Drawing.Point(1010, 380);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new System.Drawing.Size(175, 58);
            this.ButtonClose.TabIndex = 0;
            this.ButtonClose.Text = "Закрыть";
            this.ButtonClose.UseVisualStyleBackColor = true;
            this.ButtonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Наличие туалета";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Наличие буфета";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Наличие грузового отсека";
            // 
            // ButtonCreateObject
            // 
            this.ButtonCreateObject.Location = new System.Drawing.Point(72, 212);
            this.ButtonCreateObject.Name = "ButtonCreateObject";
            this.ButtonCreateObject.Size = new System.Drawing.Size(209, 45);
            this.ButtonCreateObject.TabIndex = 7;
            this.ButtonCreateObject.Text = "Обработать и добавить поезд";
            this.ButtonCreateObject.UseVisualStyleBackColor = true;
            this.ButtonCreateObject.Click += new System.EventHandler(this.ButtonCreateObject_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Номер поезда";
            // 
            // numericNumberTrain
            // 
            this.numericNumberTrain.Location = new System.Drawing.Point(224, 18);
            this.numericNumberTrain.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericNumberTrain.Name = "numericNumberTrain";
            this.numericNumberTrain.Size = new System.Drawing.Size(99, 22);
            this.numericNumberTrain.TabIndex = 9;
            this.numericNumberTrain.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // textBoxToilet
            // 
            this.textBoxToilet.Location = new System.Drawing.Point(224, 74);
            this.textBoxToilet.Name = "textBoxToilet";
            this.textBoxToilet.Size = new System.Drawing.Size(94, 22);
            this.textBoxToilet.TabIndex = 10;
            // 
            // textBoxBuffet
            // 
            this.textBoxBuffet.Location = new System.Drawing.Point(224, 111);
            this.textBoxBuffet.Name = "textBoxBuffet";
            this.textBoxBuffet.Size = new System.Drawing.Size(94, 22);
            this.textBoxBuffet.TabIndex = 11;
            // 
            // textBoxCargoComponents
            // 
            this.textBoxCargoComponents.Location = new System.Drawing.Point(224, 154);
            this.textBoxCargoComponents.Name = "textBoxCargoComponents";
            this.textBoxCargoComponents.Size = new System.Drawing.Size(94, 22);
            this.textBoxCargoComponents.TabIndex = 12;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnNumber,
            this.ColumnType});
            this.dataGridView1.Location = new System.Drawing.Point(633, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(484, 241);
            this.dataGridView1.TabIndex = 13;
            // 
            // ColumnNumber
            // 
            this.ColumnNumber.HeaderText = "Номер вагона";
            this.ColumnNumber.MinimumWidth = 6;
            this.ColumnNumber.Name = "ColumnNumber";
            this.ColumnNumber.Width = 125;
            // 
            // ColumnType
            // 
            this.ColumnType.HeaderText = "Тип";
            this.ColumnType.MinimumWidth = 6;
            this.ColumnType.Name = "ColumnType";
            this.ColumnType.Width = 125;
            // 
            // ButtonClearDataGridView
            // 
            this.ButtonClearDataGridView.Location = new System.Drawing.Point(810, 272);
            this.ButtonClearDataGridView.Name = "ButtonClearDataGridView";
            this.ButtonClearDataGridView.Size = new System.Drawing.Size(175, 58);
            this.ButtonClearDataGridView.TabIndex = 14;
            this.ButtonClearDataGridView.Text = "Очистить таблицу";
            this.ButtonClearDataGridView.UseVisualStyleBackColor = true;
            this.ButtonClearDataGridView.Click += new System.EventHandler(this.ButtonClearDataGridView_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1197, 450);
            this.Controls.Add(this.ButtonClearDataGridView);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBoxCargoComponents);
            this.Controls.Add(this.textBoxBuffet);
            this.Controls.Add(this.textBoxToilet);
            this.Controls.Add(this.numericNumberTrain);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ButtonCreateObject);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ButtonClose);
            this.Name = "Form1";
            this.Text = "lab_7_Bobkov_Zhigalov";
            ((System.ComponentModel.ISupportInitialize)(this.numericNumberTrain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ButtonCreateObject;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericNumberTrain;
        private System.Windows.Forms.TextBox textBoxToilet;
        private System.Windows.Forms.TextBox textBoxBuffet;
        private System.Windows.Forms.TextBox textBoxCargoComponents;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnType;
        private System.Windows.Forms.Button ButtonClearDataGridView;
    }
}

