namespace lab_8
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
            this.textBoxMin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxTime = new System.Windows.Forms.TextBox();
            this.ButtonSearchMin = new System.Windows.Forms.Button();
            this.ButtonCloseForm = new System.Windows.Forms.Button();
            this.numericSearchMin = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numericSizeBubleSort = new System.Windows.Forms.NumericUpDown();
            this.ButtonBubleSort = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxTimeBuble = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericSearchMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericSizeBubleSort)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxMin
            // 
            this.textBoxMin.Location = new System.Drawing.Point(186, 87);
            this.textBoxMin.Name = "textBoxMin";
            this.textBoxMin.Size = new System.Drawing.Size(182, 22);
            this.textBoxMin.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Поиск минимального";
            // 
            // textBoxTime
            // 
            this.textBoxTime.Location = new System.Drawing.Point(184, 145);
            this.textBoxTime.Name = "textBoxTime";
            this.textBoxTime.Size = new System.Drawing.Size(182, 22);
            this.textBoxTime.TabIndex = 2;
            // 
            // ButtonSearchMin
            // 
            this.ButtonSearchMin.Location = new System.Drawing.Point(417, 51);
            this.ButtonSearchMin.Name = "ButtonSearchMin";
            this.ButtonSearchMin.Size = new System.Drawing.Size(133, 39);
            this.ButtonSearchMin.TabIndex = 7;
            this.ButtonSearchMin.Text = "Найти";
            this.ButtonSearchMin.UseVisualStyleBackColor = true;
            this.ButtonSearchMin.Click += new System.EventHandler(this.ButtonSearchMin_Click);
            // 
            // ButtonCloseForm
            // 
            this.ButtonCloseForm.Location = new System.Drawing.Point(655, 399);
            this.ButtonCloseForm.Name = "ButtonCloseForm";
            this.ButtonCloseForm.Size = new System.Drawing.Size(133, 39);
            this.ButtonCloseForm.TabIndex = 8;
            this.ButtonCloseForm.Text = "Закрыть";
            this.ButtonCloseForm.UseVisualStyleBackColor = true;
            this.ButtonCloseForm.Click += new System.EventHandler(this.ButtonCloseForm_Click);
            // 
            // numericSearchMin
            // 
            this.numericSearchMin.Location = new System.Drawing.Point(186, 49);
            this.numericSearchMin.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numericSearchMin.Minimum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericSearchMin.Name = "numericSearchMin";
            this.numericSearchMin.Size = new System.Drawing.Size(180, 22);
            this.numericSearchMin.TabIndex = 9;
            this.numericSearchMin.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Колличество элементов";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Ответ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 272);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "Время сортировки";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "Колличество элементов";
            // 
            // numericSizeBubleSort
            // 
            this.numericSizeBubleSort.Location = new System.Drawing.Point(184, 234);
            this.numericSizeBubleSort.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numericSizeBubleSort.Minimum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericSizeBubleSort.Name = "numericSizeBubleSort";
            this.numericSizeBubleSort.Size = new System.Drawing.Size(180, 22);
            this.numericSizeBubleSort.TabIndex = 15;
            this.numericSizeBubleSort.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // ButtonBubleSort
            // 
            this.ButtonBubleSort.Location = new System.Drawing.Point(415, 236);
            this.ButtonBubleSort.Name = "ButtonBubleSort";
            this.ButtonBubleSort.Size = new System.Drawing.Size(133, 39);
            this.ButtonBubleSort.TabIndex = 14;
            this.ButtonBubleSort.Text = "Отсортировать";
            this.ButtonBubleSort.UseVisualStyleBackColor = true;
            this.ButtonBubleSort.Click += new System.EventHandler(this.ButtonBubleSort_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 208);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(219, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Сортировка пузырьком массива";
            // 
            // textBoxTimeBuble
            // 
            this.textBoxTimeBuble.Location = new System.Drawing.Point(184, 272);
            this.textBoxTimeBuble.Name = "textBoxTimeBuble";
            this.textBoxTimeBuble.Size = new System.Drawing.Size(182, 22);
            this.textBoxTimeBuble.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericSizeBubleSort);
            this.Controls.Add(this.ButtonBubleSort);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxTimeBuble);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numericSearchMin);
            this.Controls.Add(this.ButtonCloseForm);
            this.Controls.Add(this.ButtonSearchMin);
            this.Controls.Add(this.textBoxTime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxMin);
            this.Name = "Form1";
            this.Text = "lab_8_Zhigalov_Bobkov";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericSearchMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericSizeBubleSort)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxMin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxTime;
        private System.Windows.Forms.Button ButtonSearchMin;
        private System.Windows.Forms.Button ButtonCloseForm;
        private System.Windows.Forms.NumericUpDown numericSearchMin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericSizeBubleSort;
        private System.Windows.Forms.Button ButtonBubleSort;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxTimeBuble;
    }
}

