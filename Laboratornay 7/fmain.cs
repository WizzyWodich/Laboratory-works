using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Laboratornay_7
{
    public partial class GeneralForm : Form
    {
        public GeneralForm()
        {
            InitializeComponent();
            PatchToFile.Text = String.Empty;
        }

        private void SearchVariableComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (SearchVariableComboBox.SelectedIndex == 0)
                {
                    TypeVariableComboBox.Items.Clear();
                    string[] myitem = new string[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
                    TypeVariableComboBox.Items.AddRange(myitem);
                }
                else if (SearchVariableComboBox.SelectedIndex == 1)
                {
                    TypeVariableComboBox.Items.Clear();
                    string[] myitem = new string[] { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j",
                "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z"};
                    TypeVariableComboBox.Items.AddRange(myitem);
                }
                else if (SearchVariableComboBox.SelectedIndex == 2)
                {
                    TypeVariableComboBox.Items.Clear();
                    string[] myitem = new string[] { "@", "#", "+", "*" };
                    TypeVariableComboBox.Items.AddRange(myitem);
                }
            }
            catch (Exception msg)
            {
                Console.WriteLine($"Виникла помилка: {msg.Message}");
                MessageBox.Show($"Виникла помилка {msg.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void SelectFilesButton_Click(object sender, EventArgs e)
        {
            try
            {
                ShowTextBox.Clear();

                OpenFileDialog ofd = new OpenFileDialog();

                if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    StreamReader streamReader = new StreamReader(ofd.FileName);
                    PatchToFile.Text = ofd.FileName;
                    int counter = 0;
                    char searchSumbol = char.Parse(TypeVariableComboBox.Text);

                    while (!streamReader.EndOfStream)
                    {
                        String myline = streamReader.ReadLine();
                        ShowTextBox.Text = ShowTextBox.Text + Environment.NewLine + myline;
                        for (int i = 0; i < myline.Length; i++)
                        {
                            if (myline[i] == searchSumbol)
                                counter++;
                        }
                    }
                    ResulTextBox.Text = counter.ToString();
                    streamReader.Close();
                }
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show($"Файл не знайдено: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (IOException ex)
            {
                MessageBox.Show($"Сталася помилка введення-виведення: {ex.Message} ", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
    
            catch (Exception msg)
            {
                Console.WriteLine($"Виникла помилка: {msg.Message}");
                MessageBox.Show($"Виникла помилка {msg.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
