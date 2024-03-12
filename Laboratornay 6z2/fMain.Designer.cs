namespace Laboratornay_6z2
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
            this.tbVarX1 = new System.Windows.Forms.TextBox();
            this.tbVarX2 = new System.Windows.Forms.TextBox();
            this.tbResult = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbAvg = new System.Windows.Forms.TextBox();
            this.lbAvg = new System.Windows.Forms.Label();
            this.tbX1LESSX2 = new System.Windows.Forms.TextBox();
            this.LX1sX2 = new System.Windows.Forms.Label();
            this.tbX1MOREX2 = new System.Windows.Forms.TextBox();
            this.X1bX2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ClearButton
            // 
            this.ClearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClearButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ClearButton.Location = new System.Drawing.Point(24, 346);
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
            this.EqualsButton.Location = new System.Drawing.Point(160, 346);
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
            this.ExitButtonProgram.Location = new System.Drawing.Point(289, 346);
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
            this.iVariableX.Size = new System.Drawing.Size(94, 20);
            this.iVariableX.TabIndex = 4;
            this.iVariableX.Text = "Змінна X1";
            // 
            // LVariableX
            // 
            this.LVariableX.AutoSize = true;
            this.LVariableX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LVariableX.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.LVariableX.Location = new System.Drawing.Point(86, 105);
            this.LVariableX.Name = "LVariableX";
            this.LVariableX.Size = new System.Drawing.Size(94, 20);
            this.LVariableX.TabIndex = 5;
            this.LVariableX.Text = "Змінна X2";
            // 
            // LVariableY
            // 
            this.LVariableY.AutoSize = true;
            this.LVariableY.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LVariableY.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.LVariableY.Location = new System.Drawing.Point(72, 156);
            this.LVariableY.Name = "LVariableY";
            this.LVariableY.Size = new System.Drawing.Size(98, 20);
            this.LVariableY.TabIndex = 6;
            this.LVariableY.Text = "Результат";
            // 
            // tbVarX1
            // 
            this.tbVarX1.Location = new System.Drawing.Point(199, 63);
            this.tbVarX1.Name = "tbVarX1";
            this.tbVarX1.Size = new System.Drawing.Size(176, 20);
            this.tbVarX1.TabIndex = 7;
            // 
            // tbVarX2
            // 
            this.tbVarX2.Location = new System.Drawing.Point(199, 105);
            this.tbVarX2.Name = "tbVarX2";
            this.tbVarX2.Size = new System.Drawing.Size(176, 20);
            this.tbVarX2.TabIndex = 8;
            // 
            // tbResult
            // 
            this.tbResult.Location = new System.Drawing.Point(199, 156);
            this.tbResult.Name = "tbResult";
            this.tbResult.Size = new System.Drawing.Size(176, 20);
            this.tbResult.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.tbAvg);
            this.panel1.Controls.Add(this.lbAvg);
            this.panel1.Controls.Add(this.tbX1LESSX2);
            this.panel1.Controls.Add(this.LX1sX2);
            this.panel1.Controls.Add(this.tbX1MOREX2);
            this.panel1.Controls.Add(this.X1bX2);
            this.panel1.Controls.Add(this.tbResult);
            this.panel1.Controls.Add(this.tbVarX2);
            this.panel1.Controls.Add(this.tbVarX1);
            this.panel1.Controls.Add(this.LVariableY);
            this.panel1.Controls.Add(this.LVariableX);
            this.panel1.Controls.Add(this.iVariableX);
            this.panel1.Controls.Add(this.ExitButtonProgram);
            this.panel1.Controls.Add(this.EqualsButton);
            this.panel1.Controls.Add(this.ClearButton);
            this.panel1.Location = new System.Drawing.Point(1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(422, 393);
            this.panel1.TabIndex = 10;
            // 
            // tbAvg
            // 
            this.tbAvg.Location = new System.Drawing.Point(230, 209);
            this.tbAvg.Name = "tbAvg";
            this.tbAvg.Size = new System.Drawing.Size(86, 20);
            this.tbAvg.TabIndex = 15;
            // 
            // lbAvg
            // 
            this.lbAvg.AutoSize = true;
            this.lbAvg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbAvg.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.lbAvg.Location = new System.Drawing.Point(3, 209);
            this.lbAvg.Name = "lbAvg";
            this.lbAvg.Size = new System.Drawing.Size(206, 20);
            this.lbAvg.TabIndex = 14;
            this.lbAvg.Text = "Середнє арифметичне";
            // 
            // tbX1LESSX2
            // 
            this.tbX1LESSX2.Location = new System.Drawing.Point(199, 258);
            this.tbX1LESSX2.Name = "tbX1LESSX2";
            this.tbX1LESSX2.Size = new System.Drawing.Size(86, 20);
            this.tbX1LESSX2.TabIndex = 13;
            // 
            // LX1sX2
            // 
            this.LX1sX2.AutoSize = true;
            this.LX1sX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LX1sX2.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.LX1sX2.Location = new System.Drawing.Point(86, 256);
            this.LX1sX2.Name = "LX1sX2";
            this.LX1sX2.Size = new System.Drawing.Size(63, 20);
            this.LX1sX2.TabIndex = 12;
            this.LX1sX2.Text = "X1<X2";
            // 
            // tbX1MOREX2
            // 
            this.tbX1MOREX2.Location = new System.Drawing.Point(199, 294);
            this.tbX1MOREX2.Name = "tbX1MOREX2";
            this.tbX1MOREX2.Size = new System.Drawing.Size(86, 20);
            this.tbX1MOREX2.TabIndex = 11;
            // 
            // X1bX2
            // 
            this.X1bX2.AutoSize = true;
            this.X1bX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.X1bX2.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.X1bX2.Location = new System.Drawing.Point(86, 292);
            this.X1bX2.Name = "X1bX2";
            this.X1bX2.Size = new System.Drawing.Size(63, 20);
            this.X1bX2.TabIndex = 10;
            this.X1bX2.Text = "X1>X2";
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 393);
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
            private System.Windows.Forms.TextBox tbVarX1;
            private System.Windows.Forms.TextBox tbVarX2;
            private System.Windows.Forms.TextBox tbResult;
            private System.Windows.Forms.Panel panel1;
            private System.Windows.Forms.TextBox tbX1LESSX2;
            private System.Windows.Forms.Label LX1sX2;
            private System.Windows.Forms.TextBox tbX1MOREX2;
            private System.Windows.Forms.Label X1bX2;
            private System.Windows.Forms.TextBox tbAvg;
            private System.Windows.Forms.Label lbAvg;
        }
    }


