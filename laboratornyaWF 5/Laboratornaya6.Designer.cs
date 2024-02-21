
namespace laboratornya_6
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
            this.ClearButton = new System.Windows.Forms.Button();
            this.EqualsButton = new System.Windows.Forms.Button();
            this.ExitButtonProgram = new System.Windows.Forms.Button();
            this.iVariableX = new System.Windows.Forms.Label();
            this.LVariableX = new System.Windows.Forms.Label();
            this.LVariableY = new System.Windows.Forms.Label();
            this.tbVarX = new System.Windows.Forms.TextBox();
            this.tbVarY = new System.Windows.Forms.TextBox();
            this.tbResult = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ClearButton
            // 
            this.ClearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClearButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ClearButton.Location = new System.Drawing.Point(32, 259);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(108, 23);
            this.ClearButton.TabIndex = 1;
            this.ClearButton.Text = "Очистити";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // EqualsButton
            // 
            this.EqualsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EqualsButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.EqualsButton.Location = new System.Drawing.Point(160, 259);
            this.EqualsButton.Name = "EqualsButton";
            this.EqualsButton.Size = new System.Drawing.Size(108, 23);
            this.EqualsButton.TabIndex = 2;
            this.EqualsButton.Text = "Обчислити";
            this.EqualsButton.UseVisualStyleBackColor = true;
            this.EqualsButton.Click += new System.EventHandler(this.EqualsButton_Click);
            // 
            // ExitButtonProgram
            // 
            this.ExitButtonProgram.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitButtonProgram.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ExitButtonProgram.Location = new System.Drawing.Point(290, 259);
            this.ExitButtonProgram.Name = "ExitButtonProgram";
            this.ExitButtonProgram.Size = new System.Drawing.Size(108, 23);
            this.ExitButtonProgram.TabIndex = 3;
            this.ExitButtonProgram.Text = "Вихід";
            this.ExitButtonProgram.UseVisualStyleBackColor = true;
            this.ExitButtonProgram.Click += new System.EventHandler(this.ExitButtonProgram_Click);
            // 
            // iVariableX
            // 
            this.iVariableX.AutoSize = true;
            this.iVariableX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iVariableX.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.iVariableX.Location = new System.Drawing.Point(86, 63);
            this.iVariableX.Name = "iVariableX";
            this.iVariableX.Size = new System.Drawing.Size(84, 20);
            this.iVariableX.TabIndex = 4;
            this.iVariableX.Text = "Змінна X";
            // 
            // LVariableX
            // 
            this.LVariableX.AutoSize = true;
            this.LVariableX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LVariableX.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.LVariableX.Location = new System.Drawing.Point(86, 105);
            this.LVariableX.Name = "LVariableX";
            this.LVariableX.Size = new System.Drawing.Size(84, 20);
            this.LVariableX.TabIndex = 5;
            this.LVariableX.Text = "Змінна Y";
            // 
            // LVariableY
            // 
            this.LVariableY.AutoSize = true;
            this.LVariableY.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LVariableY.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.LVariableY.Location = new System.Drawing.Point(72, 175);
            this.LVariableY.Name = "LVariableY";
            this.LVariableY.Size = new System.Drawing.Size(98, 20);
            this.LVariableY.TabIndex = 6;
            this.LVariableY.Text = "Результат";
            // 
            // tbVarX
            // 
            this.tbVarX.Location = new System.Drawing.Point(199, 63);
            this.tbVarX.Name = "tbVarX";
            this.tbVarX.Size = new System.Drawing.Size(176, 20);
            this.tbVarX.TabIndex = 7;
            // 
            // tbVarY
            // 
            this.tbVarY.Location = new System.Drawing.Point(199, 105);
            this.tbVarY.Name = "tbVarY";
            this.tbVarY.Size = new System.Drawing.Size(176, 20);
            this.tbVarY.TabIndex = 8;
            // 
            // tbResult
            // 
            this.tbResult.Location = new System.Drawing.Point(199, 175);
            this.tbResult.Name = "tbResult";
            this.tbResult.Size = new System.Drawing.Size(176, 20);
            this.tbResult.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.tbResult);
            this.panel1.Controls.Add(this.tbVarY);
            this.panel1.Controls.Add(this.tbVarX);
            this.panel1.Controls.Add(this.LVariableY);
            this.panel1.Controls.Add(this.LVariableX);
            this.panel1.Controls.Add(this.iVariableX);
            this.panel1.Controls.Add(this.ExitButtonProgram);
            this.panel1.Controls.Add(this.EqualsButton);
            this.panel1.Controls.Add(this.ClearButton);
            this.panel1.Location = new System.Drawing.Point(1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(422, 313);
            this.panel1.TabIndex = 10;
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 314);
            this.Controls.Add(this.panel1);
            this.Name = "fMain";
            this.Text = "Лабораторна 5";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button EqualsButton;
        private System.Windows.Forms.Button ExitButtonProgram;
        private System.Windows.Forms.Label iVariableX;
        private System.Windows.Forms.Label LVariableX;
        private System.Windows.Forms.Label LVariableY;
        private System.Windows.Forms.TextBox tbVarX;
        private System.Windows.Forms.TextBox tbVarY;
        private System.Windows.Forms.TextBox tbResult;
        private System.Windows.Forms.Panel panel1;
    }
}

