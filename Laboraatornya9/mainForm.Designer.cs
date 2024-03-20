
namespace Laboraatornya9
{
    partial class mainForm
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
            this.btAdded = new System.Windows.Forms.Button();
            this.btShow = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btAdded
            // 
            this.btAdded.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btAdded.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btAdded.Location = new System.Drawing.Point(157, 169);
            this.btAdded.Name = "btAdded";
            this.btAdded.Size = new System.Drawing.Size(202, 47);
            this.btAdded.TabIndex = 1;
            this.btAdded.Text = "Додати запис";
            this.btAdded.UseVisualStyleBackColor = true;
            this.btAdded.Click += new System.EventHandler(this.btAdded_Click);
            // 
            // btShow
            // 
            this.btShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btShow.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btShow.Location = new System.Drawing.Point(157, 244);
            this.btShow.Name = "btShow";
            this.btShow.Size = new System.Drawing.Size(202, 47);
            this.btShow.TabIndex = 2;
            this.btShow.Text = "Переглянути запис";
            this.btShow.UseVisualStyleBackColor = true;
            this.btShow.Click += new System.EventHandler(this.btShow_Click);
            // 
            // btExit
            // 
            this.btExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btExit.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btExit.Location = new System.Drawing.Point(157, 320);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(202, 47);
            this.btExit.TabIndex = 2;
            this.btExit.Text = "Вихід";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Laboraatornya9.Properties.Resources.pictures;
            this.pictureBox1.Location = new System.Drawing.Point(116, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(301, 132);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 450);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btShow);
            this.Controls.Add(this.btAdded);
            this.Controls.Add(this.pictureBox1);
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Програма \"Щоденик\"";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btAdded;
        private System.Windows.Forms.Button btShow;
        private System.Windows.Forms.Button btExit;
    }
}

