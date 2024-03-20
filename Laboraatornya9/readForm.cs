using System;
using System.Windows.Forms;
using System.IO;
using System.Globalization;

namespace Laboraatornya9
{
    public partial class readForm : Form
    {
        public readForm()
        {
            InitializeComponent();
        }

        private void btOpenhText_Click(object sender, EventArgs e)
        {
            richTextBoxShow.Clear();
            string date;
            date = Convert.ToString(dateTimePicker.Value);
            string filename = date.Substring(0, 10);
            try
            {
                StreamReader streamReader = new StreamReader("C://Users//aud50//Desktop//Сонін Кирило К-31//Laboratory-works//Laboraatornya9//TextFiles/" + filename + ".txt");

                richTextBoxShow.Text = filename;
                while (!streamReader.EndOfStream)
                {
                    string line = streamReader.ReadLine();
                    richTextBoxShow.Text = richTextBoxShow.Text + Environment.NewLine + line;
                }
                lbDayWeak.Text = dateTimePicker.Value.ToString("dddd", CultureInfo.GetCultureInfo("uk-UA")); 
                streamReader.Close();
            }
            catch
            {
                string message = "Запис відсутній";
                string title = "Помилка вілкриття";
                MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

}
