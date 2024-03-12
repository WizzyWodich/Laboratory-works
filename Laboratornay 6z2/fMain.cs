using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratornay_6z2
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
                    double var_1 = double.Parse(tbVarX1.Text);
                    double var_2 = double.Parse(tbVarX2.Text);
                    double result = var_1 * var_2;
                    double avg = (var_1 + var_2) / 2;
                    tbAvg.Text = avg.ToString();
                    tbResult.Text = result.ToString();

                    bool resultMore = var_1 > var_2 ? true : false;
                    tbX1MOREX2.Text = resultMore.ToString();
                    bool resultless = var_1 < var_2 ? true : false;
                    tbX1LESSX2.Text = resultless.ToString();

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
                tbAvg.Text = string.Empty;
                tbX1LESSX2.Text = string.Empty;
                tbX1MOREX2.Text = string.Empty;

            }
            catch (Exception ex)
            {
                tbResult.Text = $"Помилка: {ex}";
            }
        }
    }
}
