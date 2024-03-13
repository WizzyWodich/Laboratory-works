using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab8
{
    internal class Teacher
    {
        private string NameTeachers;
        private string FirstName;
        private string SurName;
        private int Age;
        private string Discipline;
        private string[] NameStudent;
        private string LessonTopic;

        public Teacher() { }

        public Teacher(string NameTeachers, string FirstName, string SurName, int Age, string Discipline, string[] NameStudent, string LessonTopic)
        {
            this.NameTeachers = NameTeachers;
            this.FirstName = FirstName;
            this.SurName = SurName;
            this.Age = Age;
            this.Discipline = Discipline;
            this.NameStudent = NameStudent;
            this.LessonTopic = LessonTopic;
        }
        public Teacher(Teacher teacher)
        {
            NameTeachers = teacher.NameTeachers;
            FirstName = teacher.FirstName;
            SurName = teacher.SurName;
            Age = teacher.Age;
            Discipline = teacher.Discipline;
            NameStudent = teacher.NameStudent;
            LessonTopic = teacher.LessonTopic;
        }

        public void InfoTeacher()
        {
            MessageBox.Show($"Ім'я: {NameTeachers}\n" +
                            $" Прізвище: {FirstName}\n" +
                            $" По-батькові: {SurName}\n " +
                            $"Вік: {Age}\n" +
                            $"Дисципліна: {Discipline}\n" +
                            $"Тема заняття: {LessonTopic}",
                            "Дані викладача", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void EditInfoTeachers()
        {
            this.NameTeachers = "Олег";
            this.FirstName = "Михайловський";
            this.SurName = "Евгенійович";
            this.Age = 17;
            this.Discipline = "Програмування мовою `Prolog`";
            MessageBox.Show("Дані викладача змінено.", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void InfoStudent()
        {
            string message = "";
            foreach (var item in NameStudent)
            {
                message += item + "\n";
            }
            MessageBox.Show(message, "Ім'я студентів", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public string GetStudents()
        {
            string message = "";
            foreach (var item in NameStudent)
            {
                message += item + "\n";
            }
            return message;
        }

        public void EditStudent()
        {
            this.NameStudent = new string[] { "Петро", "Славік", "Олег"};
        }

        public void EditLessonTopic()
        {
            this.LessonTopic = "Програмування мовою `Java`";
        }

        public void SaveFiles()
        {
            try
            {
                string filePatch = "C:/Users/kirya/Desktop/Programing/Работы/Лабораторные/Lab8/Test.txt";
                StreamWriter sw = new StreamWriter(filePatch);
                sw.WriteLine($"Данні викладача \n" +
                    $"Ім'я викладача: {NameTeachers}\n" +
                    $"Призвище: {FirstName}\n" +
                    $"По батькові {SurName} \n" +
                    $"Вік викладача {Age}\n" +
                    $"Дисципліна {Discipline}\n" +
                    $"Тема заннятя {LessonTopic}\n" +
                    $"Информація про студентів:\n" +
                    $"Студенти {GetStudents()}\n");
                sw.Close();
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Файл не існує.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Об'єкт не існує.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
