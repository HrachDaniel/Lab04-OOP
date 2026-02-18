namespace Lab04_OOP
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            txtArrayResult = new TextBox();
            lblStats = new Label();
            btnCalcTask1 = new Button();
            txtArrayInput = new TextBox();
            label1 = new Label();
            tabPage2 = new TabPage();
            lblRowM = new Label();
            lblCol2 = new Label();
            txtMatrixOutput = new TextBox();
            btnCalcTask2 = new Button();
            numM = new NumericUpDown();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            numCols = new NumericUpDown();
            numRows = new NumericUpDown();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numM).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numCols).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numRows).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(807, 458);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(txtArrayResult);
            tabPage1.Controls.Add(lblStats);
            tabPage1.Controls.Add(btnCalcTask1);
            tabPage1.Controls.Add(txtArrayInput);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(799, 425);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Task1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtArrayResult
            // 
            txtArrayResult.Location = new Point(262, 120);
            txtArrayResult.Multiline = true;
            txtArrayResult.Name = "txtArrayResult";
            txtArrayResult.ScrollBars = ScrollBars.Vertical;
            txtArrayResult.Size = new Size(368, 150);
            txtArrayResult.TabIndex = 4;
            // 
            // lblStats
            // 
            lblStats.AutoSize = true;
            lblStats.Location = new Point(6, 120);
            lblStats.Name = "lblStats";
            lblStats.Size = new Size(50, 20);
            lblStats.TabIndex = 3;
            lblStats.Text = "label2";
            // 
            // btnCalcTask1
            // 
            btnCalcTask1.Location = new Point(6, 74);
            btnCalcTask1.Name = "btnCalcTask1";
            btnCalcTask1.Size = new Size(216, 29);
            btnCalcTask1.TabIndex = 2;
            btnCalcTask1.Text = "Розрахувати та Обробити";
            btnCalcTask1.UseVisualStyleBackColor = true;
            btnCalcTask1.Click += btnCalcTask1_Click;
            // 
            // txtArrayInput
            // 
            txtArrayInput.Location = new Point(262, 15);
            txtArrayInput.Name = "txtArrayInput";
            txtArrayInput.Size = new Size(125, 27);
            txtArrayInput.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 18);
            label1.Name = "label1";
            label1.Size = new Size(216, 20);
            label1.TabIndex = 0;
            label1.Text = "Введіть масив (через пробіл):";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(lblRowM);
            tabPage2.Controls.Add(lblCol2);
            tabPage2.Controls.Add(txtMatrixOutput);
            tabPage2.Controls.Add(btnCalcTask2);
            tabPage2.Controls.Add(numM);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(numCols);
            tabPage2.Controls.Add(numRows);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(799, 425);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Task2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblRowM
            // 
            lblRowM.AutoSize = true;
            lblRowM.Location = new Point(510, 199);
            lblRowM.Name = "lblRowM";
            lblRowM.Size = new Size(50, 20);
            lblRowM.TabIndex = 9;
            lblRowM.Text = "label6";
            // 
            // lblCol2
            // 
            lblCol2.AutoSize = true;
            lblCol2.Location = new Point(281, 199);
            lblCol2.Name = "lblCol2";
            lblCol2.Size = new Size(50, 20);
            lblCol2.TabIndex = 8;
            lblCol2.Text = "label5";
            // 
            // txtMatrixOutput
            // 
            txtMatrixOutput.Location = new Point(6, 185);
            txtMatrixOutput.Multiline = true;
            txtMatrixOutput.Name = "txtMatrixOutput";
            txtMatrixOutput.Size = new Size(186, 76);
            txtMatrixOutput.TabIndex = 7;
            // 
            // btnCalcTask2
            // 
            btnCalcTask2.Location = new Point(6, 139);
            btnCalcTask2.Name = "btnCalcTask2";
            btnCalcTask2.Size = new Size(186, 29);
            btnCalcTask2.TabIndex = 6;
            btnCalcTask2.Text = "Генерувати та Показати";
            btnCalcTask2.UseVisualStyleBackColor = true;
            btnCalcTask2.Click += btnCalcTask2_Click;
            // 
            // numM
            // 
            numM.Location = new Point(181, 83);
            numM.Name = "numM";
            numM.Size = new Size(150, 27);
            numM.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 90);
            label4.Name = "label4";
            label4.Size = new Size(121, 20);
            label4.TabIndex = 4;
            label4.Text = "Номер рядка m:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 13);
            label3.Name = "label3";
            label3.Size = new Size(118, 20);
            label3.TabIndex = 3;
            label3.Text = "Кількість рядків";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 43);
            label2.Name = "label2";
            label2.Size = new Size(134, 20);
            label2.TabIndex = 2;
            label2.Text = "Кількість стовпців";
            // 
            // numCols
            // 
            numCols.Location = new Point(181, 36);
            numCols.Name = "numCols";
            numCols.Size = new Size(150, 27);
            numCols.TabIndex = 1;
            // 
            // numRows
            // 
            numRows.Location = new Point(181, 6);
            numRows.Name = "numRows";
            numRows.Size = new Size(150, 27);
            numRows.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(831, 482);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numM).EndInit();
            ((System.ComponentModel.ISupportInitialize)numCols).EndInit();
            ((System.ComponentModel.ISupportInitialize)numRows).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TextBox txtArrayInput;
        private Label label1;
        private TabPage tabPage2;
        private TextBox txtArrayResult;
        private Label lblStats;
        private Button btnCalcTask1;
        private Label label3;
        private Label label2;
        private NumericUpDown numCols;
        private NumericUpDown numRows;
        private Label lblRowM;
        private Label lblCol2;
        private TextBox txtMatrixOutput;
        private Button btnCalcTask2;
        private NumericUpDown numM;
        private Label label4;
    }
}
