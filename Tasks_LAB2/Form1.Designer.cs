namespace Tasks_LAB2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelFunc = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBoxA = new TextBox();
            textBoxB = new TextBox();
            textBoxN = new TextBox();
            label5 = new Label();
            textBoxThreadNumber = new TextBox();
            buttonOnetask = new Button();
            buttonMultitask = new Button();
            buttonClear = new Button();
            comboBox1 = new ComboBox();
            label6 = new Label();
            labelResult = new Label();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // labelFunc
            // 
            labelFunc.AutoSize = true;
            labelFunc.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelFunc.Location = new Point(12, 9);
            labelFunc.Name = "labelFunc";
            labelFunc.Size = new Size(301, 28);
            labelFunc.TabIndex = 0;
            labelFunc.Text = "Функция: 𝑓(𝑥) = sin(𝑥) ∙ 𝑒^(−𝑥/5)\r\n";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 229);
            label1.Name = "label1";
            label1.Size = new Size(244, 20);
            label1.TabIndex = 2;
            label1.Text = "Выберите метод интегрирования";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 59);
            label2.Name = "label2";
            label2.Size = new Size(20, 20);
            label2.TabIndex = 3;
            label2.Text = "a:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 98);
            label3.Name = "label3";
            label3.Size = new Size(21, 20);
            label3.TabIndex = 4;
            label3.Text = "b:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 139);
            label4.Name = "label4";
            label4.Size = new Size(23, 20);
            label4.TabIndex = 5;
            label4.Text = "N:";
            // 
            // textBoxA
            // 
            textBoxA.Location = new Point(38, 56);
            textBoxA.Name = "textBoxA";
            textBoxA.Size = new Size(121, 27);
            textBoxA.TabIndex = 6;
            // 
            // textBoxB
            // 
            textBoxB.Location = new Point(38, 95);
            textBoxB.Name = "textBoxB";
            textBoxB.Size = new Size(121, 27);
            textBoxB.TabIndex = 7;
            // 
            // textBoxN
            // 
            textBoxN.Location = new Point(38, 136);
            textBoxN.Name = "textBoxN";
            textBoxN.Size = new Size(121, 27);
            textBoxN.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 189);
            label5.Name = "label5";
            label5.Size = new Size(116, 20);
            label5.TabIndex = 9;
            label5.Text = "Число потоков:";
            // 
            // textBoxThreadNumber
            // 
            textBoxThreadNumber.Location = new Point(134, 186);
            textBoxThreadNumber.Name = "textBoxThreadNumber";
            textBoxThreadNumber.Size = new Size(52, 27);
            textBoxThreadNumber.TabIndex = 10;
            // 
            // buttonOnetask
            // 
            buttonOnetask.Font = new Font("Segoe UI", 8F);
            buttonOnetask.Location = new Point(12, 308);
            buttonOnetask.Name = "buttonOnetask";
            buttonOnetask.Size = new Size(116, 60);
            buttonOnetask.TabIndex = 11;
            buttonOnetask.Text = "Вычислить однопоточно";
            buttonOnetask.UseVisualStyleBackColor = true;
            buttonOnetask.Click += buttonOnetask_Click;
            // 
            // buttonMultitask
            // 
            buttonMultitask.Font = new Font("Segoe UI", 8F);
            buttonMultitask.Location = new Point(140, 308);
            buttonMultitask.Name = "buttonMultitask";
            buttonMultitask.Size = new Size(116, 60);
            buttonMultitask.TabIndex = 12;
            buttonMultitask.Text = "Вычислить многопоточно";
            buttonMultitask.UseVisualStyleBackColor = true;
            buttonMultitask.Click += buttonMultitask_Click;
            // 
            // buttonClear
            // 
            buttonClear.Location = new Point(939, 409);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(109, 29);
            buttonClear.TabIndex = 13;
            buttonClear.Text = "Очистить всё";
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += buttonClear_Click;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Метод прямоугольников", "Метод трапеций", "Метод Монте-Карло" });
            comboBox1.Location = new Point(12, 252);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(227, 28);
            comboBox1.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(12, 395);
            label6.Name = "label6";
            label6.Size = new Size(108, 28);
            label6.TabIndex = 15;
            label6.Text = "Результат: ";
            // 
            // labelResult
            // 
            labelResult.AutoSize = true;
            labelResult.Font = new Font("Segoe UI", 12F);
            labelResult.Location = new Point(112, 395);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(0, 28);
            labelResult.TabIndex = 16;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(366, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(685, 356);
            dataGridView1.TabIndex = 17;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1060, 450);
            Controls.Add(dataGridView1);
            Controls.Add(labelResult);
            Controls.Add(label6);
            Controls.Add(comboBox1);
            Controls.Add(buttonClear);
            Controls.Add(buttonMultitask);
            Controls.Add(buttonOnetask);
            Controls.Add(textBoxThreadNumber);
            Controls.Add(label5);
            Controls.Add(textBoxN);
            Controls.Add(textBoxB);
            Controls.Add(textBoxA);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(labelFunc);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelFunc;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBoxA;
        private TextBox textBoxB;
        private TextBox textBoxN;
        private Label label5;
        private TextBox textBoxThreadNumber;
        private Button buttonOnetask;
        private Button buttonMultitask;
        private Button buttonClear;
        private ComboBox comboBox1;
        private Label label6;
        private Label labelResult;
        private DataGridView dataGridView1;
    }
}
