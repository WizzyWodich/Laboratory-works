using System;
using System.Windows.Forms;

namespace Laboraatornya9
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void btAdded_Click(object sender, EventArgs e)
        {
            this.Hide();
            recordForm recordForm = new recordForm();
            recordForm.FormClosed += (object s, FormClosedEventArgs ev) => { this.Show(); };
            recordForm.Show();
        }

        private void btShow_Click(object sender, EventArgs e)
        {
            this.Hide();
            readForm readForm = new readForm();
            readForm.FormClosed += (object s, FormClosedEventArgs ev) => { this.Show(); };
            readForm.Show();
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
