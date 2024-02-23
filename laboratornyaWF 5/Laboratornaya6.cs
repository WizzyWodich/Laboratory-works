using System;
using System.Windows.Forms;

namespace laboratornya_6
{
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
        }

        private void ExitButtonProgram_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void EqualsButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(tbVarX.Text) || string.IsNullOrEmpty(tbVarY.Text))
                {
                    tbResult.Text = "Поля пусті будь-ласка введіть данні.";
                    return;
                }
                else
                {
                    double var_1 = double.Parse(tbVarX.Text);
                    double var_2 = double.Parse(tbVarY.Text);
                    double result = var_1 * var_2;
                    tbResult.Text = result.ToString();
                }
            }
            catch (FormatException)
            {
                Console.WriteLine($"Будь-ласка введіть цифри.");                
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Помилка: {ex}");
            }

        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            try
            {
                tbVarX.Text = string.Empty;
                tbVarY.Text = string.Empty;
                tbResult.Text = string.Empty;

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Помилка: {ex}");
            }
        }
    }
}
