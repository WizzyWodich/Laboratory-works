using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Laboratornay_8
{
    internal class Teachers
    {
        private string name;
        private string sname;
        private string fathername;
        private string discipline;
        private string[] subject;

        private int x;


        public Teachers(string name, string sname, string discipline, string[] subject)
        {
            this.name = name;
            this.sname = sname;
            this.fathername = fathername;
            this.discipline = discipline;
            this.subject = subject;
        }
        public Teachers(Teachers teachers)
        {
            this.name = teachers.name;
            this.sname = teachers.sname;
            this.discipline = teachers.discipline;
            this.subject = teachers.subject;
            this.fathername = teachers.fathername;
        }

        public void getInfo()
        {
            MessageBox.Show($"Дані викладача:" +
                $"Ім'я: {name}\n" +
                $"Фамілія: {sname}" +
            $"По батькові");

            Form1 form = new Form1();
            x = int.Parse(form.ProfileLabelText);

        }


    }
    
}
