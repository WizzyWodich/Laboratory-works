using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btConstDef_Click(object sender, EventArgs e)
        {
            Teacher teacher = new Teacher();

            MessageBox.Show("Створено порожній конструктор", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        Teacher teacher2;
        private void btConstParam_Click(object sender, EventArgs e)
        {
            teacher2 = new Teacher("Олег", "Горбачёв", "Ярославович", 23, "Алгебраїчна-Геометрія", new string[] {"Іван","Євген","Микола"}, "Геометрія схем");
            MessageBox.Show("Створені данні", "Информація", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btConstCopy_Click(object sender, EventArgs e)
        {
            Teacher teacher3 = new Teacher(teacher2);
            MessageBox.Show("Створена копія даних.", "Информація", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void ShowInfoTeacher_Click(object sender, EventArgs e)
        {
            try
            {
                teacher2.InfoTeacher();
                MessageBox.Show("Інформація про викладачі заповнена.", "Информація", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Інформація порожння будь ласка заповніть.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ShowInfoStudent_Click(object sender, EventArgs e)
        {
            try
            {
                teacher2.InfoStudent();
                MessageBox.Show("Інформація про студентів заповнена.", "Информація", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Інформація порожння будь ласка заповніть.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EditInfoLeasonsTopic_Click(object sender, EventArgs e)
        {
            try
            {
                teacher2.EditLessonTopic();
                MessageBox.Show("Тема заняття змінена.", "Информація", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Інформація порожння будь ласка заповніть.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EditInfoStudent_Click(object sender, EventArgs e)
        {
            try
            {
                teacher2.EditStudent();
                MessageBox.Show("Імена студентів змінено.", "Информація", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Інформація порожння будь ласка заповніть.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            try
            {
                teacher2.SaveFiles();
                MessageBox.Show("Інформація збережена у файл .txt у корінь проекту.", "Информація", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch 
            {
                MessageBox.Show("Не вдалося зберегти у файл.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btEditTeachers_Click(object sender, EventArgs e)
        {
            try
            {
                teacher2.EditInfoTeachers();
                MessageBox.Show("Інформація про викладача змінена.", "Информація", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Інформація порожння будь ласка заповніть.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
