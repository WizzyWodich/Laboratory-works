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
            this.btEditTeacherInfo = new System.Windows.Forms.Button();
            this.tbSave = new System.Windows.Forms.Button();
            this.btConstDef = new System.Windows.Forms.Button();
            this.btConstParam = new System.Windows.Forms.Button();
            this.btConstCopy = new System.Windows.Forms.Button();
            this.tbEditInfoStudent = new System.Windows.Forms.Button();
            this.tbEditInfoLeasonsTopic = new System.Windows.Forms.Button();
            this.tbShowInfoTeacher = new System.Windows.Forms.Button();
            this.tbShowInfoStudent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btEditTeacherInfo
            // 
            this.btEditTeacherInfo.Location = new System.Drawing.Point(394, 54);
            this.btEditTeacherInfo.Name = "btEditTeacherInfo";
            this.btEditTeacherInfo.Size = new System.Drawing.Size(111, 37);
            this.btEditTeacherInfo.TabIndex = 0;
            this.btEditTeacherInfo.Text = "Редагувати дані викладача";
            this.btEditTeacherInfo.UseVisualStyleBackColor = true;
            this.btEditTeacherInfo.Click += new System.EventHandler(this.btEditTeachers_Click);
            // 
            // tbSave
            // 
            this.tbSave.Location = new System.Drawing.Point(277, 164);
            this.tbSave.Name = "tbSave";
            this.tbSave.Size = new System.Drawing.Size(111, 37);
            this.tbSave.TabIndex = 0;
            this.tbSave.Text = "Зберегти";
            this.tbSave.UseVisualStyleBackColor = true;
            this.tbSave.Click += new System.EventHandler(this.Save_Click);
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
            // tbEditInfoStudent
            // 
            this.tbEditInfoStudent.Location = new System.Drawing.Point(394, 107);
            this.tbEditInfoStudent.Name = "tbEditInfoStudent";
            this.tbEditInfoStudent.Size = new System.Drawing.Size(111, 37);
            this.tbEditInfoStudent.TabIndex = 0;
            this.tbEditInfoStudent.Text = "Редагувати данні студентів";
            this.tbEditInfoStudent.UseVisualStyleBackColor = true;
            this.tbEditInfoStudent.Click += new System.EventHandler(this.EditInfoStudent_Click);
            // 
            // tbEditInfoLeasonsTopic
            // 
            this.tbEditInfoLeasonsTopic.Location = new System.Drawing.Point(394, 164);
            this.tbEditInfoLeasonsTopic.Name = "tbEditInfoLeasonsTopic";
            this.tbEditInfoLeasonsTopic.Size = new System.Drawing.Size(111, 37);
            this.tbEditInfoLeasonsTopic.TabIndex = 0;
            this.tbEditInfoLeasonsTopic.Text = "Редагувати тему";
            this.tbEditInfoLeasonsTopic.UseVisualStyleBackColor = true;
            this.tbEditInfoLeasonsTopic.Click += new System.EventHandler(this.EditInfoLeasonsTopic_Click);
            // 
            // tbShowInfoTeacher
            // 
            this.tbShowInfoTeacher.Location = new System.Drawing.Point(277, 54);
            this.tbShowInfoTeacher.Name = "tbShowInfoTeacher";
            this.tbShowInfoTeacher.Size = new System.Drawing.Size(111, 37);
            this.tbShowInfoTeacher.TabIndex = 0;
            this.tbShowInfoTeacher.Text = "Вивести данні";
            this.tbShowInfoTeacher.UseVisualStyleBackColor = true;
            this.tbShowInfoTeacher.Click += new System.EventHandler(this.ShowInfoTeacher_Click);
            // 
            // tbShowInfoStudent
            // 
            this.tbShowInfoStudent.Location = new System.Drawing.Point(277, 107);
            this.tbShowInfoStudent.Name = "tbShowInfoStudent";
            this.tbShowInfoStudent.Size = new System.Drawing.Size(111, 37);
            this.tbShowInfoStudent.TabIndex = 1;
            this.tbShowInfoStudent.Text = "Вивести данні студентів";
            this.tbShowInfoStudent.UseVisualStyleBackColor = true;
            this.tbShowInfoStudent.Click += new System.EventHandler(this.ShowInfoStudent_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 279);
            this.Controls.Add(this.tbShowInfoStudent);
            this.Controls.Add(this.tbSave);
            this.Controls.Add(this.tbEditInfoLeasonsTopic);
            this.Controls.Add(this.tbEditInfoStudent);
            this.Controls.Add(this.tbShowInfoTeacher);
            this.Controls.Add(this.btEditTeacherInfo);
            this.Controls.Add(this.btConstCopy);
            this.Controls.Add(this.btConstParam);
            this.Controls.Add(this.btConstDef);
            this.Name = "Form1";
            this.Text = "Сонін Кирило К-31 \"Викладач коледжу\"";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btEditTeacherInfo;
        private System.Windows.Forms.Button tbSave;
        private System.Windows.Forms.Button btConstDef;
        private System.Windows.Forms.Button btConstParam;
        private System.Windows.Forms.Button btConstCopy;
        private System.Windows.Forms.Button tbEditInfoStudent;
        private System.Windows.Forms.Button tbEditInfoLeasonsTopic;
        private System.Windows.Forms.Button tbShowInfoTeacher;
        private System.Windows.Forms.Button tbShowInfoStudent;
    }
}

