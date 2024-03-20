
namespace Laboraatornya9
{
    partial class recordForm
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
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.rbNise = new System.Windows.Forms.RadioButton();
            this.rbBad = new System.Windows.Forms.RadioButton();
            this.btSave = new System.Windows.Forms.Button();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // monthCalendar
            // 
            this.monthCalendar.Location = new System.Drawing.Point(41, 18);
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.TabIndex = 0;
            // 
            // rbNise
            // 
            this.rbNise.AutoSize = true;
            this.rbNise.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.rbNise.ForeColor = System.Drawing.Color.LimeGreen;
            this.rbNise.Location = new System.Drawing.Point(248, 42);
            this.rbNise.Name = "rbNise";
            this.rbNise.Size = new System.Drawing.Size(139, 24);
            this.rbNise.TabIndex = 1;
            this.rbNise.TabStop = true;
            this.rbNise.Text = "Вдалий день";
            this.rbNise.UseVisualStyleBackColor = true;
            // 
            // rbBad
            // 
            this.rbBad.AutoSize = true;
            this.rbBad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.rbBad.ForeColor = System.Drawing.Color.Red;
            this.rbBad.Location = new System.Drawing.Point(248, 91);
            this.rbBad.Name = "rbBad";
            this.rbBad.Size = new System.Drawing.Size(178, 24);
            this.rbBad.TabIndex = 2;
            this.rbBad.TabStop = true;
            this.rbBad.Text = "Жахливий настрій";
            this.rbBad.UseVisualStyleBackColor = true;
            // 
            // btSave
            // 
            this.btSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btSave.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btSave.Location = new System.Drawing.Point(248, 136);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(146, 35);
            this.btSave.TabIndex = 3;
            this.btSave.Text = "Зберегти";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // richTextBox
            // 
            this.richTextBox.Location = new System.Drawing.Point(41, 224);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(386, 133);
            this.richTextBox.TabIndex = 4;
            this.richTextBox.Text = "";
            // 
            // recordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 385);
            this.Controls.Add(this.richTextBox);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.rbBad);
            this.Controls.Add(this.rbNise);
            this.Controls.Add(this.monthCalendar);
            this.Name = "recordForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Додавання запису";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar;
        private System.Windows.Forms.RadioButton rbNise;
        private System.Windows.Forms.RadioButton rbBad;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.RichTextBox richTextBox;
    }
}