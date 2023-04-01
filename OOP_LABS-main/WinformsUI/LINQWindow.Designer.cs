namespace WinformsUI
{
    partial class LINQWindow
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
            consoleLog = new TextBox();
            exitButton = new Button();
            Консоль = new GroupBox();
            clearConsoleButton = new Button();
            writeToFileLibCollectionButton = new Button();
            sortLibCollectionButton = new Button();
            libCollectionLINQButton = new Button();
            showLibCollectionButton = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            collectionsLengthNTextBox = new NumericUpDown();
            label7 = new Label();
            stringLengthTextBox = new NumericUpDown();
            executeArrayCollectionOperationsButton = new Button();
            collectionLengthTextBox = new NumericUpDown();
            label6 = new Label();
            arrayLengthTextBox = new NumericUpDown();
            label5 = new Label();
            label2 = new Label();
            toLengthTextBox = new NumericUpDown();
            label1 = new Label();
            label4 = new Label();
            label3 = new Label();
            searchValueTextBox = new TextBox();
            fromLengthTextBox = new NumericUpDown();
            createCollectionArrayButton = new Button();
            showColArrayButton = new Button();
            groupBox3 = new GroupBox();
            Консоль.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)collectionsLengthNTextBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)stringLengthTextBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)collectionLengthTextBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)arrayLengthTextBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)toLengthTextBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fromLengthTextBox).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // consoleLog
            // 
            consoleLog.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            consoleLog.Location = new Point(9, 29);
            consoleLog.Margin = new Padding(3, 4, 3, 4);
            consoleLog.Multiline = true;
            consoleLog.Name = "consoleLog";
            consoleLog.ReadOnly = true;
            consoleLog.ScrollBars = ScrollBars.Both;
            consoleLog.Size = new Size(450, 576);
            consoleLog.TabIndex = 0;
            consoleLog.TextChanged += consoleLog_TextChanged;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(363, 65);
            exitButton.Margin = new Padding(3, 4, 3, 4);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(97, 43);
            exitButton.TabIndex = 1;
            exitButton.Text = "Выход";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // Консоль
            // 
            Консоль.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Консоль.Controls.Add(consoleLog);
            Консоль.Location = new Point(14, 16);
            Консоль.Margin = new Padding(3, 4, 3, 4);
            Консоль.Name = "Консоль";
            Консоль.Padding = new Padding(3, 4, 3, 4);
            Консоль.Size = new Size(466, 629);
            Консоль.TabIndex = 2;
            Консоль.TabStop = false;
            Консоль.Text = "Консоль";
            // 
            // clearConsoleButton
            // 
            clearConsoleButton.Location = new Point(7, 65);
            clearConsoleButton.Margin = new Padding(3, 4, 3, 4);
            clearConsoleButton.Name = "clearConsoleButton";
            clearConsoleButton.Size = new Size(224, 43);
            clearConsoleButton.TabIndex = 3;
            clearConsoleButton.Text = "Очистить консоль";
            clearConsoleButton.UseVisualStyleBackColor = true;
            clearConsoleButton.Click += clearConsoleButton_Click;
            // 
            // writeToFileLibCollectionButton
            // 
            writeToFileLibCollectionButton.Location = new Point(243, 80);
            writeToFileLibCollectionButton.Margin = new Padding(3, 4, 3, 4);
            writeToFileLibCollectionButton.Name = "writeToFileLibCollectionButton";
            writeToFileLibCollectionButton.Size = new Size(224, 43);
            writeToFileLibCollectionButton.TabIndex = 4;
            writeToFileLibCollectionButton.Text = "Сохранить в файл";
            writeToFileLibCollectionButton.UseVisualStyleBackColor = true;
            writeToFileLibCollectionButton.Click += writeToFileLibCollectionButton_Click;
            // 
            // sortLibCollectionButton
            // 
            sortLibCollectionButton.Location = new Point(7, 80);
            sortLibCollectionButton.Margin = new Padding(3, 4, 3, 4);
            sortLibCollectionButton.Name = "sortLibCollectionButton";
            sortLibCollectionButton.Size = new Size(224, 43);
            sortLibCollectionButton.TabIndex = 5;
            sortLibCollectionButton.Text = "Отсортировать";
            sortLibCollectionButton.UseVisualStyleBackColor = true;
            sortLibCollectionButton.Click += sortLibCollectionButton_Click;
            // 
            // libCollectionLINQButton
            // 
            libCollectionLINQButton.Location = new Point(243, 29);
            libCollectionLINQButton.Margin = new Padding(3, 4, 3, 4);
            libCollectionLINQButton.Name = "libCollectionLINQButton";
            libCollectionLINQButton.Size = new Size(224, 43);
            libCollectionLINQButton.TabIndex = 6;
            libCollectionLINQButton.Text = "Выполнить LINQ запросы";
            libCollectionLINQButton.UseVisualStyleBackColor = true;
            libCollectionLINQButton.Click += libCollectionLINQButton_Click;
            // 
            // showLibCollectionButton
            // 
            showLibCollectionButton.Location = new Point(7, 29);
            showLibCollectionButton.Margin = new Padding(3, 4, 3, 4);
            showLibCollectionButton.Name = "showLibCollectionButton";
            showLibCollectionButton.Size = new Size(224, 43);
            showLibCollectionButton.TabIndex = 7;
            showLibCollectionButton.Text = "Вывести коллекцию библиотек";
            showLibCollectionButton.UseVisualStyleBackColor = true;
            showLibCollectionButton.Click += showLibCollectionButton_Click;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            groupBox1.Controls.Add(showLibCollectionButton);
            groupBox1.Controls.Add(sortLibCollectionButton);
            groupBox1.Controls.Add(libCollectionLINQButton);
            groupBox1.Controls.Add(writeToFileLibCollectionButton);
            groupBox1.Location = new Point(502, 16);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(474, 144);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Коллекция объектов библиотеки";
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            groupBox2.Controls.Add(collectionsLengthNTextBox);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(stringLengthTextBox);
            groupBox2.Controls.Add(executeArrayCollectionOperationsButton);
            groupBox2.Controls.Add(collectionLengthTextBox);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(arrayLengthTextBox);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(toLengthTextBox);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(searchValueTextBox);
            groupBox2.Controls.Add(fromLengthTextBox);
            groupBox2.Controls.Add(createCollectionArrayButton);
            groupBox2.Controls.Add(showColArrayButton);
            groupBox2.Location = new Point(502, 181);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(474, 340);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "Массив объектов LinkedList<string>";
            // 
            // collectionsLengthNTextBox
            // 
            collectionsLengthNTextBox.Location = new Point(290, 255);
            collectionsLengthNTextBox.Margin = new Padding(3, 4, 3, 4);
            collectionsLengthNTextBox.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            collectionsLengthNTextBox.Name = "collectionsLengthNTextBox";
            collectionsLengthNTextBox.Size = new Size(137, 27);
            collectionsLengthNTextBox.TabIndex = 21;
            collectionsLengthNTextBox.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(7, 257);
            label7.Name = "label7";
            label7.Size = new Size(303, 20);
            label7.TabIndex = 20;
            label7.Text = "Количество коллекций длины n: введите n";
            // 
            // stringLengthTextBox
            // 
            stringLengthTextBox.Location = new Point(290, 215);
            stringLengthTextBox.Margin = new Padding(3, 4, 3, 4);
            stringLengthTextBox.Name = "stringLengthTextBox";
            stringLengthTextBox.Size = new Size(137, 27);
            stringLengthTextBox.TabIndex = 16;
            // 
            // executeArrayCollectionOperationsButton
            // 
            executeArrayCollectionOperationsButton.Location = new Point(7, 289);
            executeArrayCollectionOperationsButton.Margin = new Padding(3, 4, 3, 4);
            executeArrayCollectionOperationsButton.Name = "executeArrayCollectionOperationsButton";
            executeArrayCollectionOperationsButton.Size = new Size(224, 43);
            executeArrayCollectionOperationsButton.TabIndex = 10;
            executeArrayCollectionOperationsButton.Text = "Выполнить все операции";
            executeArrayCollectionOperationsButton.UseVisualStyleBackColor = true;
            executeArrayCollectionOperationsButton.Click += executeArrayCollectionOperationsButton_Click;
            // 
            // collectionLengthTextBox
            // 
            collectionLengthTextBox.Location = new Point(152, 103);
            collectionLengthTextBox.Margin = new Padding(3, 4, 3, 4);
            collectionLengthTextBox.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            collectionLengthTextBox.Name = "collectionLengthTextBox";
            collectionLengthTextBox.Size = new Size(65, 27);
            collectionLengthTextBox.TabIndex = 19;
            collectionLengthTextBox.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(7, 105);
            label6.Name = "label6";
            label6.Size = new Size(152, 20);
            label6.TabIndex = 18;
            label6.Text = "Длина коллекции до";
            // 
            // arrayLengthTextBox
            // 
            arrayLengthTextBox.Location = new Point(152, 64);
            arrayLengthTextBox.Margin = new Padding(3, 4, 3, 4);
            arrayLengthTextBox.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            arrayLengthTextBox.Name = "arrayLengthTextBox";
            arrayLengthTextBox.Size = new Size(65, 27);
            arrayLengthTextBox.TabIndex = 17;
            arrayLengthTextBox.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(7, 68);
            label5.Name = "label5";
            label5.Size = new Size(136, 20);
            label5.TabIndex = 16;
            label5.Text = "Длина массива до";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 219);
            label2.Name = "label2";
            label2.Size = new Size(267, 20);
            label2.TabIndex = 15;
            label2.Text = "Количество строк длины n: введите n";
            // 
            // toLengthTextBox
            // 
            toLengthTextBox.Location = new Point(254, 25);
            toLengthTextBox.Margin = new Padding(3, 4, 3, 4);
            toLengthTextBox.Name = "toLengthTextBox";
            toLengthTextBox.Size = new Size(65, 27);
            toLengthTextBox.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 180);
            label1.Name = "label1";
            label1.Size = new Size(279, 20);
            label1.TabIndex = 13;
            label1.Text = "Поиск строк: введите значение поиска";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(224, 32);
            label4.Name = "label4";
            label4.Size = new Size(26, 20);
            label4.TabIndex = 14;
            label4.Text = "до";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(7, 32);
            label3.Name = "label3";
            label3.Size = new Size(123, 20);
            label3.TabIndex = 13;
            label3.Text = "Длина строки от";
            // 
            // searchValueTextBox
            // 
            searchValueTextBox.Location = new Point(290, 176);
            searchValueTextBox.Margin = new Padding(3, 4, 3, 4);
            searchValueTextBox.Name = "searchValueTextBox";
            searchValueTextBox.Size = new Size(137, 27);
            searchValueTextBox.TabIndex = 12;
            // 
            // fromLengthTextBox
            // 
            fromLengthTextBox.Location = new Point(152, 25);
            fromLengthTextBox.Margin = new Padding(3, 4, 3, 4);
            fromLengthTextBox.Name = "fromLengthTextBox";
            fromLengthTextBox.Size = new Size(65, 27);
            fromLengthTextBox.TabIndex = 12;
            // 
            // createCollectionArrayButton
            // 
            createCollectionArrayButton.Location = new Point(243, 68);
            createCollectionArrayButton.Margin = new Padding(3, 4, 3, 4);
            createCollectionArrayButton.Name = "createCollectionArrayButton";
            createCollectionArrayButton.Size = new Size(224, 43);
            createCollectionArrayButton.TabIndex = 0;
            createCollectionArrayButton.Text = "Создать массив коллекций";
            createCollectionArrayButton.UseVisualStyleBackColor = true;
            createCollectionArrayButton.Click += createCollectionArrayButton_Click;
            // 
            // showColArrayButton
            // 
            showColArrayButton.Location = new Point(243, 119);
            showColArrayButton.Margin = new Padding(3, 4, 3, 4);
            showColArrayButton.Name = "showColArrayButton";
            showColArrayButton.Size = new Size(224, 43);
            showColArrayButton.TabIndex = 11;
            showColArrayButton.Text = "Вывести массив коллекций";
            showColArrayButton.UseVisualStyleBackColor = true;
            showColArrayButton.Click += showColArrayButton_Click;
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            groupBox3.Controls.Add(clearConsoleButton);
            groupBox3.Controls.Add(exitButton);
            groupBox3.Location = new Point(502, 529);
            groupBox3.Margin = new Padding(3, 4, 3, 4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 4, 3, 4);
            groupBox3.Size = new Size(467, 116);
            groupBox3.TabIndex = 10;
            groupBox3.TabStop = false;
            groupBox3.Text = "Разное";
            // 
            // LINQWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(990, 661);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(Консоль);
            Margin = new Padding(3, 4, 3, 4);
            Name = "LINQWindow";
            Text = "LINQWindow";
            Консоль.ResumeLayout(false);
            Консоль.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)collectionsLengthNTextBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)stringLengthTextBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)collectionLengthTextBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)arrayLengthTextBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)toLengthTextBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)fromLengthTextBox).EndInit();
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TextBox consoleLog;
        private Button exitButton;
        private GroupBox Консоль;
        private Button clearConsoleButton;
        private Button writeToFileLibCollectionButton;
        private Button sortLibCollectionButton;
        private Button libCollectionLINQButton;
        private Button showLibCollectionButton;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button executeArrayCollectionOperationsButton;
        private Button createCollectionArrayButton;
        private Button showColArrayButton;
        private Label label2;
        private Label label1;
        private TextBox searchValueTextBox;
        private NumericUpDown stringLengthTextBox;
        private NumericUpDown collectionLengthTextBox;
        private Label label6;
        private NumericUpDown arrayLengthTextBox;
        private Label label5;
        private NumericUpDown toLengthTextBox;
        private Label label4;
        private Label label3;
        private NumericUpDown fromLengthTextBox;
        private GroupBox groupBox3;
        private NumericUpDown collectionsLengthNTextBox;
        private Label label7;
    }
}