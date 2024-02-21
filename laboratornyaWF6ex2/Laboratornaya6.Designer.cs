
namespace laboratornya_6ex2
{
    partial class fMain
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
            ClearButton = new Button();
            EqualsButton = new Button();
            ExitButtonProgram = new Button();
            iVariableX = new Label();
            LVariableX = new Label();
            LVariableY = new Label();
            tbVarX1 = new TextBox();
            tbVarX2 = new TextBox();
            tbResult = new TextBox();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // ClearButton
            // 
            ClearButton.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            ClearButton.ForeColor = SystemColors.ControlText;
            ClearButton.Location = new Point(37, 299);
            ClearButton.Margin = new Padding(4, 3, 4, 3);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(126, 27);
            ClearButton.TabIndex = 1;
            ClearButton.Text = "Очистити";
            ClearButton.UseVisualStyleBackColor = true;
            ClearButton.Click += ClearButton_Click;
            // 
            // EqualsButton
            // 
            EqualsButton.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            EqualsButton.ForeColor = SystemColors.ControlText;
            EqualsButton.Location = new Point(187, 299);
            EqualsButton.Margin = new Padding(4, 3, 4, 3);
            EqualsButton.Name = "EqualsButton";
            EqualsButton.Size = new Size(126, 27);
            EqualsButton.TabIndex = 2;
            EqualsButton.Text = "Обчислити";
            EqualsButton.UseVisualStyleBackColor = true;
            EqualsButton.Click += EqualsButton_Click;
            // 
            // ExitButtonProgram
            // 
            ExitButtonProgram.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            ExitButtonProgram.ForeColor = SystemColors.ControlText;
            ExitButtonProgram.Location = new Point(338, 299);
            ExitButtonProgram.Margin = new Padding(4, 3, 4, 3);
            ExitButtonProgram.Name = "ExitButtonProgram";
            ExitButtonProgram.Size = new Size(126, 27);
            ExitButtonProgram.TabIndex = 3;
            ExitButtonProgram.Text = "Вихід";
            ExitButtonProgram.UseVisualStyleBackColor = true;
            ExitButtonProgram.Click += ExitButtonProgram_Click;
            // 
            // iVariableX
            // 
            iVariableX.AutoSize = true;
            iVariableX.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            iVariableX.ForeColor = SystemColors.InactiveBorder;
            iVariableX.Location = new Point(100, 73);
            iVariableX.Margin = new Padding(4, 0, 4, 0);
            iVariableX.Name = "iVariableX";
            iVariableX.Size = new Size(84, 20);
            iVariableX.TabIndex = 4;
            iVariableX.Text = "Змінна X";
            // 
            // LVariableX
            // 
            LVariableX.AutoSize = true;
            LVariableX.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            LVariableX.ForeColor = SystemColors.InactiveBorder;
            LVariableX.Location = new Point(100, 121);
            LVariableX.Margin = new Padding(4, 0, 4, 0);
            LVariableX.Name = "LVariableX";
            LVariableX.Size = new Size(84, 20);
            LVariableX.TabIndex = 5;
            LVariableX.Text = "Змінна Y";
            // 
            // LVariableY
            // 
            LVariableY.AutoSize = true;
            LVariableY.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            LVariableY.ForeColor = SystemColors.InactiveBorder;
            LVariableY.Location = new Point(84, 202);
            LVariableY.Margin = new Padding(4, 0, 4, 0);
            LVariableY.Name = "LVariableY";
            LVariableY.Size = new Size(98, 20);
            LVariableY.TabIndex = 6;
            LVariableY.Text = "Результат";
            // 
            // tbVarX1
            // 
            tbVarX1.Location = new Point(232, 73);
            tbVarX1.Margin = new Padding(4, 3, 4, 3);
            tbVarX1.Name = "tbVarX1";
            tbVarX1.Size = new Size(205, 23);
            tbVarX1.TabIndex = 7;
            // 
            // tbVarX2
            // 
            tbVarX2.Location = new Point(232, 121);
            tbVarX2.Margin = new Padding(4, 3, 4, 3);
            tbVarX2.Name = "tbVarX2";
            tbVarX2.Size = new Size(205, 23);
            tbVarX2.TabIndex = 8;
            // 
            // tbResult
            // 
            tbResult.Location = new Point(232, 202);
            tbResult.Margin = new Padding(4, 3, 4, 3);
            tbResult.Name = "tbResult";
            tbResult.Size = new Size(205, 23);
            tbResult.TabIndex = 9;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GradientInactiveCaption;
            panel1.Controls.Add(tbResult);
            panel1.Controls.Add(tbVarX2);
            panel1.Controls.Add(tbVarX1);
            panel1.Controls.Add(LVariableY);
            panel1.Controls.Add(LVariableX);
            panel1.Controls.Add(iVariableX);
            panel1.Controls.Add(ExitButtonProgram);
            panel1.Controls.Add(EqualsButton);
            panel1.Controls.Add(ClearButton);
            panel1.Location = new Point(1, 2);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(492, 361);
            panel1.TabIndex = 10;
            // 
            // fMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(492, 362);
            Controls.Add(panel1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "fMain";
            Text = "Лабораторна 5";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button EqualsButton;
        private System.Windows.Forms.Button ExitButtonProgram;
        private System.Windows.Forms.Label iVariableX;
        private System.Windows.Forms.Label LVariableX;
        private System.Windows.Forms.Label LVariableY;
        private System.Windows.Forms.TextBox tbVarX1;
        private System.Windows.Forms.TextBox tbVarX2;
        private System.Windows.Forms.TextBox tbResult;
        private System.Windows.Forms.Panel panel1;
    }
}

