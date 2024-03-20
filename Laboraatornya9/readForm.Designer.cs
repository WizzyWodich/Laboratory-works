
namespace Laboraatornya9
{
    partial class readForm
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
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.btOpenhText = new System.Windows.Forms.Button();
            this.richTextBoxShow = new System.Windows.Forms.RichTextBox();
            this.lbTiketDay = new System.Windows.Forms.Label();
            this.lbDayWeak = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(56, 53);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(173, 20);
            this.dateTimePicker.TabIndex = 0;
            // 
            // btOpenhText
            // 
            this.btOpenhText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btOpenhText.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btOpenhText.Location = new System.Drawing.Point(388, 53);
            this.btOpenhText.Name = "btOpenhText";
            this.btOpenhText.Size = new System.Drawing.Size(147, 36);
            this.btOpenhText.TabIndex = 1;
            this.btOpenhText.Text = "Відкрити запис";
            this.btOpenhText.UseVisualStyleBackColor = true;
            this.btOpenhText.Click += new System.EventHandler(this.btOpenhText_Click);
            // 
            // richTextBoxShow
            // 
            this.richTextBoxShow.Location = new System.Drawing.Point(56, 144);
            this.richTextBoxShow.Name = "richTextBoxShow";
            this.richTextBoxShow.Size = new System.Drawing.Size(479, 217);
            this.richTextBoxShow.TabIndex = 2;
            this.richTextBoxShow.Text = "";
            // 
            // lbTiketDay
            // 
            this.lbTiketDay.AutoSize = true;
            this.lbTiketDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lbTiketDay.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.lbTiketDay.Location = new System.Drawing.Point(53, 111);
            this.lbTiketDay.Name = "lbTiketDay";
            this.lbTiketDay.Size = new System.Drawing.Size(77, 13);
            this.lbTiketDay.TabIndex = 3;
            this.lbTiketDay.Text = "Мітка дня : ";
            // 
            // lbDayWeak
            // 
            this.lbDayWeak.AutoSize = true;
            this.lbDayWeak.Location = new System.Drawing.Point(136, 111);
            this.lbDayWeak.Name = "lbDayWeak";
            this.lbDayWeak.Size = new System.Drawing.Size(71, 13);
            this.lbDayWeak.TabIndex = 4;
            this.lbDayWeak.Text = "оберіть день";
            // 
            // readForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 397);
            this.Controls.Add(this.lbDayWeak);
            this.Controls.Add(this.lbTiketDay);
            this.Controls.Add(this.richTextBoxShow);
            this.Controls.Add(this.btOpenhText);
            this.Controls.Add(this.dateTimePicker);
            this.Name = "readForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Перегляд запису щоденика";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Button btOpenhText;
        private System.Windows.Forms.RichTextBox richTextBoxShow;
        private System.Windows.Forms.Label lbTiketDay;
        private System.Windows.Forms.Label lbDayWeak;
    }
}