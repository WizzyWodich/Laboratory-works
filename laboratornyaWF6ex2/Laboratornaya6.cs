using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace laboratornya_6ex2
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
                if (string.IsNullOrEmpty(tbVarX1.Text) || string.IsNullOrEmpty(tbVarX2.Text))
                {
                    tbResult.Text = "Поля пусті будь-ласка введіть данні.";
                    return;
                }
                else
                {
                    double x1 = double.Parse(tbVarX1.Text);
                    double x2 = double.Parse(tbVarX2.Text);
                    double part1 = 45 * x1 * Math.Sin(x2);
                    double part2 = Math.Sqrt(9 * x2 * Math.Pow(x1, 3));
                    double result = part1 + part2;
                    tbResult.Text = result.ToString();
                }
            }
            catch (FormatException)
            {
                tbResult.Text = "Будь-ласка введіть цифри.";                
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            try
            {
                tbVarX1.Text = string.Empty;
                tbVarX2.Text = string.Empty;
                tbResult.Text = string.Empty;

            }
            catch (Exception ex)
            {
                tbResult.Text = $"Помилка: {ex}";
            }
        }
    }
}
