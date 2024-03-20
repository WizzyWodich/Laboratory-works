using System;
using System.IO;
using System.Windows.Forms;

namespace Laboraatornya9
{
    public partial class recordForm : Form
    {
        public recordForm()
        {
            InitializeComponent();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(richTextBox.Text))
                {
                    string addr, date;
                    date = Convert.ToString(monthCalendar.SelectionStart);
                    string day = date.Substring(0, 10);
                    addr = "C://Users//aud50//Desktop//Сонін Кирило К-31//Laboratory-works//Laboraatornya9//TextFiles/" + day + ".txt";
                    StreamWriter streamWriter = new StreamWriter(addr);

                    if (rbBad.Checked)
                    {
                        streamWriter.WriteLine(rbBad.Text);
                        streamWriter.WriteLine(richTextBox.Text);
                        streamWriter.Close();
                    }
                    else if (rbNise.Checked)
                    {
                        streamWriter.WriteLine(rbNise.Text);
                        streamWriter.WriteLine(richTextBox.Text);
                        streamWriter.Close();
                    }
                    else
                    {
                        MessageBox.Show($"Оберіть варіант настрою", "Информація", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    
                    this.Close();
                }
                else
                {
                    string message = "Поле порожнеє";
                    string title = "Помилка відкриття";
                    MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Виникла помилка {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
