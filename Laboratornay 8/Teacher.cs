using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratornay_8
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

        public Teacher(string NameTeachers, string FirstName,string SurName, int Age, string Discipline, string[] NameStudent, string LeasonsTopic)
        {
            this.NameTeachers = NameTeachers;
            this.FirstName = FirstName;
            this.NameStudent = NameStudent;
            this.LessonTopic = LeasonsTopic;
            this.SurName = SurName;
            this.Age = Age;
            this.Discipline = Discipline;
        }

        public Teacher(Teacher teacher) {

            this.NameTeachers = teacher.NameTeachers;
            this.FirstName = teacher.FirstName;
            this.NameStudent = teacher.NameStudent;
            this.LessonTopic = teacher.LessonTopic;
            this.SurName = teacher.SurName;
            this.Age = teacher.Age;
            this.Discipline = teacher.Discipline;
        }


        public void InfoTeacher()
        {
            MessageBox.Show($"Ім'я: {NameTeachers}\n" +
                            $" Прізвище: {FirstName}\n" +
                            $" По-батькові: {SurName}\n " +
                            $"Вік: {Age}\n, " +
                            $"Дисципліна: {Discipline}",
                            "Дані викладача", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void 
    }
}
