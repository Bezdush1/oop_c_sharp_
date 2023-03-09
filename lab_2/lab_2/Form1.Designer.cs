
namespace lab_2
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
            this.components = new System.ComponentModel.Container();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.CreateObject = new System.Windows.Forms.Button();
            this.CloseProject = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Change = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.NewName = new System.Windows.Forms.TextBox();
            this.SecondName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Country = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Age = new System.Windows.Forms.NumericUpDown();
            this.Height = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.NumberOfChildren = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Weight = new System.Windows.Forms.NumericUpDown();
            this.NumberOfObjects = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.CreateException = new System.Windows.Forms.Button();
            this.SeeObject = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Age)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Height)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfChildren)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Weight)).BeginInit();
            this.SuspendLayout();
            // 
            // CreateObject
            // 
            this.CreateObject.Location = new System.Drawing.Point(598, 332);
            this.CreateObject.Name = "CreateObject";
            this.CreateObject.Size = new System.Drawing.Size(190, 43);
            this.CreateObject.TabIndex = 0;
            this.CreateObject.Text = "Создать обьект";
            this.CreateObject.UseVisualStyleBackColor = true;
            this.CreateObject.Click += new System.EventHandler(this.CreateObject_Click);
            // 
            // CloseProject
            // 
            this.CloseProject.Location = new System.Drawing.Point(598, 402);
            this.CloseProject.Name = "CloseProject";
            this.CloseProject.Size = new System.Drawing.Size(190, 36);
            this.CloseProject.TabIndex = 4;
            this.CloseProject.Text = "Закрыть проект";
            this.CloseProject.UseVisualStyleBackColor = true;
            this.CloseProject.Click += new System.EventHandler(this.CloseProject_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(420, 332);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(102, 24);
            this.comboBox1.TabIndex = 5;
            // 
            // Change
            // 
            this.Change.Location = new System.Drawing.Point(12, 387);
            this.Change.Name = "Change";
            this.Change.Size = new System.Drawing.Size(169, 51);
            this.Change.TabIndex = 6;
            this.Change.Text = "Изменить";
            this.Change.UseVisualStyleBackColor = true;
            this.Change.Click += new System.EventHandler(this.Change_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(575, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Имя";
            // 
            // NewName
            // 
            this.NewName.Location = new System.Drawing.Point(665, 22);
            this.NewName.Name = "NewName";
            this.NewName.Size = new System.Drawing.Size(100, 22);
            this.NewName.TabIndex = 8;
            // 
            // SecondName
            // 
            this.SecondName.Location = new System.Drawing.Point(665, 50);
            this.SecondName.Name = "SecondName";
            this.SecondName.Size = new System.Drawing.Size(100, 22);
            this.SecondName.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(575, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Фамилия";
            // 
            // Country
            // 
            this.Country.Location = new System.Drawing.Point(665, 78);
            this.Country.Name = "Country";
            this.Country.Size = new System.Drawing.Size(100, 22);
            this.Country.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(575, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Город";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(530, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Количество детей";
            // 
            // Age
            // 
            this.Age.Location = new System.Drawing.Point(665, 107);
            this.Age.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Age.Name = "Age";
            this.Age.Size = new System.Drawing.Size(120, 22);
            this.Age.TabIndex = 14;
            this.Age.Value = new decimal(new int[] {
            33,
            0,
            0,
            0});
            // 
            // Height
            // 
            this.Height.Location = new System.Drawing.Point(665, 135);
            this.Height.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.Height.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Height.Name = "Height";
            this.Height.Size = new System.Drawing.Size(120, 22);
            this.Height.TabIndex = 16;
            this.Height.Value = new decimal(new int[] {
            176,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(575, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Рост";
            // 
            // NumberOfChildren
            // 
            this.NumberOfChildren.Location = new System.Drawing.Point(665, 163);
            this.NumberOfChildren.Name = "NumberOfChildren";
            this.NumberOfChildren.Size = new System.Drawing.Size(120, 22);
            this.NumberOfChildren.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(561, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "Возраст";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(575, 198);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 17);
            this.label7.TabIndex = 19;
            this.label7.Text = "Вес";
            // 
            // Weight
            // 
            this.Weight.Location = new System.Drawing.Point(665, 196);
            this.Weight.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.Weight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Weight.Name = "Weight";
            this.Weight.Size = new System.Drawing.Size(120, 22);
            this.Weight.TabIndex = 20;
            this.Weight.Value = new decimal(new int[] {
            76,
            0,
            0,
            0});
            // 
            // NumberOfObjects
            // 
            this.NumberOfObjects.AutoSize = true;
            this.NumberOfObjects.Location = new System.Drawing.Point(530, 281);
            this.NumberOfObjects.Name = "NumberOfObjects";
            this.NumberOfObjects.Size = new System.Drawing.Size(146, 17);
            this.NumberOfObjects.TabIndex = 21;
            this.NumberOfObjects.Text = "Добавлено обьектов";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 17);
            this.label8.TabIndex = 22;
            // 
            // CreateException
            // 
            this.CreateException.Location = new System.Drawing.Point(396, 387);
            this.CreateException.Name = "CreateException";
            this.CreateException.Size = new System.Drawing.Size(182, 51);
            this.CreateException.TabIndex = 23;
            this.CreateException.Text = "Не нажимать";
            this.CreateException.UseVisualStyleBackColor = true;
            this.CreateException.Click += new System.EventHandler(this.CreateException_Click);
            // 
            // SeeObject
            // 
            this.SeeObject.Location = new System.Drawing.Point(206, 387);
            this.SeeObject.Name = "SeeObject";
            this.SeeObject.Size = new System.Drawing.Size(169, 51);
            this.SeeObject.TabIndex = 24;
            this.SeeObject.Text = "Показать";
            this.SeeObject.UseVisualStyleBackColor = true;
            this.SeeObject.Click += new System.EventHandler(this.SeeObject_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SeeObject);
            this.Controls.Add(this.CreateException);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.NumberOfObjects);
            this.Controls.Add(this.Weight);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.NumberOfChildren);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Height);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Age);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Country);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SecondName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NewName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Change);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.CloseProject);
            this.Controls.Add(this.CreateObject);
            this.Name = "Form1";
            this.Text = "Лабораторная работа№2 Жигалов Бобков";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Age)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Height)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfChildren)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Weight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button CreateObject;
        private System.Windows.Forms.Button CloseProject;
        public System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button Change;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NewName;
        private System.Windows.Forms.TextBox SecondName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Country;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown Age;
        private System.Windows.Forms.NumericUpDown Height;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown NumberOfChildren;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown Weight;
        private System.Windows.Forms.Label NumberOfObjects;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button CreateException;
        private System.Windows.Forms.Button SeeObject;
    }
}

