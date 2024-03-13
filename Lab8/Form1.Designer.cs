namespace Lab8
{
    partial class Form1
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
            this.btEditTeachers = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.btConstDef = new System.Windows.Forms.Button();
            this.btConstParam = new System.Windows.Forms.Button();
            this.btConstCopy = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btEditTeachers
            // 
            this.btEditTeachers.Location = new System.Drawing.Point(394, 54);
            this.btEditTeachers.Name = "btEditTeachers";
            this.btEditTeachers.Size = new System.Drawing.Size(111, 37);
            this.btEditTeachers.TabIndex = 0;
            this.btEditTeachers.Text = "Редагувати дані викладача";
            this.btEditTeachers.UseVisualStyleBackColor = true;
            this.btEditTeachers.Click += new System.EventHandler(this.btEditTeachers_Click);
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(277, 164);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(111, 37);
            this.Save.TabIndex = 0;
            this.Save.Text = "Зберегти";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // btConstDef
            // 
            this.btConstDef.Location = new System.Drawing.Point(43, 54);
            this.btConstDef.Name = "btConstDef";
            this.btConstDef.Size = new System.Drawing.Size(120, 37);
            this.btConstDef.TabIndex = 0;
            this.btConstDef.Text = "Конструктор за замовчуванням";
            this.btConstDef.UseVisualStyleBackColor = true;
            this.btConstDef.Click += new System.EventHandler(this.btConstDef_Click);
            // 
            // btConstParam
            // 
            this.btConstParam.Location = new System.Drawing.Point(43, 107);
            this.btConstParam.Name = "btConstParam";
            this.btConstParam.Size = new System.Drawing.Size(120, 37);
            this.btConstParam.TabIndex = 0;
            this.btConstParam.Text = "Конструктор з параметрами";
            this.btConstParam.UseVisualStyleBackColor = true;
            this.btConstParam.Click += new System.EventHandler(this.btConstParam_Click);
            // 
            // btConstCopy
            // 
            this.btConstCopy.Location = new System.Drawing.Point(43, 164);
            this.btConstCopy.Name = "btConstCopy";
            this.btConstCopy.Size = new System.Drawing.Size(120, 37);
            this.btConstCopy.TabIndex = 0;
            this.btConstCopy.Text = "Конструктор копіювання";
            this.btConstCopy.UseVisualStyleBackColor = true;
            this.btConstCopy.Click += new System.EventHandler(this.btConstCopy_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(394, 107);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 37);
            this.button1.TabIndex = 0;
            this.button1.Text = "Редагувати данні студентів";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(394, 164);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(111, 37);
            this.button3.TabIndex = 0;
            this.button3.Text = "Редагувати тему";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(277, 54);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 37);
            this.button2.TabIndex = 0;
            this.button2.Text = "Вивести данні";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(277, 107);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(111, 37);
            this.button4.TabIndex = 1;
            this.button4.Text = "Вивести данні студентів";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 279);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btEditTeachers);
            this.Controls.Add(this.btConstCopy);
            this.Controls.Add(this.btConstParam);
            this.Controls.Add(this.btConstDef);
            this.Name = "Form1";
            this.Text = "Сонін Кирило К-31";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btEditTeachers;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button btConstDef;
        private System.Windows.Forms.Button btConstParam;
        private System.Windows.Forms.Button btConstCopy;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
    }
}

