namespace Laboratornay_7
{
    partial class GeneralForm
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
            this.TypeVariable = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.ListFiles = new System.Windows.Forms.Label();
            this.GroupBoxParameters = new System.Windows.Forms.GroupBox();
            this.PatchToFile = new System.Windows.Forms.Label();
            this.SelectFiles = new System.Windows.Forms.Label();
            this.SelectFilesButton = new System.Windows.Forms.Button();
            this.TypeVariableComboBox = new System.Windows.Forms.ComboBox();
            this.SearchVariableComboBox = new System.Windows.Forms.ComboBox();
            this.LableTypeSelection = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ResulTextBox = new System.Windows.Forms.TextBox();
            this.ShowTextBox = new System.Windows.Forms.TextBox();
            this.TypeVariable.SuspendLayout();
            this.GroupBoxParameters.SuspendLayout();
            this.SuspendLayout();
            // 
            // TypeVariable
            // 
            this.TypeVariable.BackColor = System.Drawing.Color.MediumPurple;
            this.TypeVariable.Controls.Add(this.label3);
            this.TypeVariable.Controls.Add(this.ListFiles);
            this.TypeVariable.Controls.Add(this.GroupBoxParameters);
            this.TypeVariable.Controls.Add(this.ResulTextBox);
            this.TypeVariable.Controls.Add(this.ShowTextBox);
            this.TypeVariable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TypeVariable.Location = new System.Drawing.Point(0, 0);
            this.TypeVariable.Name = "TypeVariable";
            this.TypeVariable.Size = new System.Drawing.Size(723, 450);
            this.TypeVariable.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(607, 384);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Знайденно:";
            // 
            // ListFiles
            // 
            this.ListFiles.AutoSize = true;
            this.ListFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ListFiles.Location = new System.Drawing.Point(262, 210);
            this.ListFiles.Name = "ListFiles";
            this.ListFiles.Size = new System.Drawing.Size(100, 17);
            this.ListFiles.TabIndex = 9;
            this.ListFiles.Text = "Вміст файлу";
            // 
            // GroupBoxParameters
            // 
            this.GroupBoxParameters.Controls.Add(this.PatchToFile);
            this.GroupBoxParameters.Controls.Add(this.SelectFiles);
            this.GroupBoxParameters.Controls.Add(this.SelectFilesButton);
            this.GroupBoxParameters.Controls.Add(this.TypeVariableComboBox);
            this.GroupBoxParameters.Controls.Add(this.SearchVariableComboBox);
            this.GroupBoxParameters.Controls.Add(this.LableTypeSelection);
            this.GroupBoxParameters.Controls.Add(this.label1);
            this.GroupBoxParameters.Location = new System.Drawing.Point(43, 33);
            this.GroupBoxParameters.Name = "GroupBoxParameters";
            this.GroupBoxParameters.Size = new System.Drawing.Size(668, 174);
            this.GroupBoxParameters.TabIndex = 4;
            this.GroupBoxParameters.TabStop = false;
            this.GroupBoxParameters.Text = "Параметри для пошуку";
            // 
            // PatchToFile
            // 
            this.PatchToFile.AutoSize = true;
            this.PatchToFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PatchToFile.Location = new System.Drawing.Point(8, 154);
            this.PatchToFile.Name = "PatchToFile";
            this.PatchToFile.Size = new System.Drawing.Size(59, 17);
            this.PatchToFile.TabIndex = 8;
            this.PatchToFile.Text = "PATCH";
            // 
            // SelectFiles
            // 
            this.SelectFiles.AutoSize = true;
            this.SelectFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SelectFiles.Location = new System.Drawing.Point(6, 112);
            this.SelectFiles.Name = "SelectFiles";
            this.SelectFiles.Size = new System.Drawing.Size(174, 26);
            this.SelectFiles.TabIndex = 7;
            this.SelectFiles.Text = "Оберіть файл:";
            // 
            // SelectFilesButton
            // 
            this.SelectFilesButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectFilesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SelectFilesButton.Location = new System.Drawing.Point(493, 114);
            this.SelectFilesButton.Name = "SelectFilesButton";
            this.SelectFilesButton.Size = new System.Drawing.Size(149, 26);
            this.SelectFilesButton.TabIndex = 6;
            this.SelectFilesButton.Text = "Огляд...";
            this.SelectFilesButton.UseVisualStyleBackColor = true;
            this.SelectFilesButton.Click += new System.EventHandler(this.SelectFilesButton_Click);
            // 
            // TypeVariableComboBox
            // 
            this.TypeVariableComboBox.FormattingEnabled = true;
            this.TypeVariableComboBox.Location = new System.Drawing.Point(493, 52);
            this.TypeVariableComboBox.Name = "TypeVariableComboBox";
            this.TypeVariableComboBox.Size = new System.Drawing.Size(156, 21);
            this.TypeVariableComboBox.TabIndex = 5;
            // 
            // SearchVariableComboBox
            // 
            this.SearchVariableComboBox.FormattingEnabled = true;
            this.SearchVariableComboBox.Items.AddRange(new object[] {
            "Пошук цифри",
            "Пошук літери",
            "Пошук символа"});
            this.SearchVariableComboBox.Location = new System.Drawing.Point(493, 19);
            this.SearchVariableComboBox.Name = "SearchVariableComboBox";
            this.SearchVariableComboBox.Size = new System.Drawing.Size(156, 21);
            this.SearchVariableComboBox.TabIndex = 4;
            this.SearchVariableComboBox.SelectedIndexChanged += new System.EventHandler(this.SearchVariableComboBox_SelectedIndexChanged);
            // 
            // LableTypeSelection
            // 
            this.LableTypeSelection.AutoSize = true;
            this.LableTypeSelection.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LableTypeSelection.Location = new System.Drawing.Point(6, 16);
            this.LableTypeSelection.Name = "LableTypeSelection";
            this.LableTypeSelection.Size = new System.Drawing.Size(241, 26);
            this.LableTypeSelection.TabIndex = 2;
            this.LableTypeSelection.Text = "Оберіть тип аналізу:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(6, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "Оберіть значення:";
            // 
            // ResulTextBox
            // 
            this.ResulTextBox.Location = new System.Drawing.Point(607, 404);
            this.ResulTextBox.Name = "ResulTextBox";
            this.ResulTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ResulTextBox.Size = new System.Drawing.Size(104, 20);
            this.ResulTextBox.TabIndex = 1;
            // 
            // ShowTextBox
            // 
            this.ShowTextBox.Location = new System.Drawing.Point(43, 237);
            this.ShowTextBox.Multiline = true;
            this.ShowTextBox.Name = "ShowTextBox";
            this.ShowTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ShowTextBox.Size = new System.Drawing.Size(558, 187);
            this.ShowTextBox.TabIndex = 0;
            // 
            // GeneralForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 450);
            this.Controls.Add(this.TypeVariable);
            this.Name = "GeneralForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Аналізатор тексту";
            this.TypeVariable.ResumeLayout(false);
            this.TypeVariable.PerformLayout();
            this.GroupBoxParameters.ResumeLayout(false);
            this.GroupBoxParameters.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TypeVariable;
        private System.Windows.Forms.TextBox ShowTextBox;
        private System.Windows.Forms.TextBox ResulTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LableTypeSelection;
        private System.Windows.Forms.GroupBox GroupBoxParameters;
        private System.Windows.Forms.Label PatchToFile;
        private System.Windows.Forms.Label SelectFiles;
        private System.Windows.Forms.Button SelectFilesButton;
        private System.Windows.Forms.ComboBox TypeVariableComboBox;
        private System.Windows.Forms.ComboBox SearchVariableComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label ListFiles;
    }
}

