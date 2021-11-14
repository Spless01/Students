using System;
using System.Collections.Generic;
using System.Text;

namespace Students
{
    class Teacher : Human
    {

        private List<Student> CourseWorkStudents;
        private int MaxNumberOfCourseWorks;
        private int salary;
        public Teacher(int MaxNumberOfCourseWorks, int salary, string name, string surname, int age, Adress adress) : base(name, surname, age, adress)
        {
            this.salary = salary;
            this.MaxNumberOfCourseWorks = MaxNumberOfCourseWorks;
            CourseWorkStudents = new List<Student>(MaxNumberOfCourseWorks);

        }
        public int getMaxNumberOfCourseWorks() { return this.MaxNumberOfCourseWorks; }
        public void setMaxNumberOfCourseWorks(int maxNum) { this.MaxNumberOfCourseWorks = maxNum; }
        public List<Student> getCourseWorkStudents() { return this.CourseWorkStudents; }
        public void setCourseWorkStudents(List<Student> students) { this.CourseWorkStudents = students; }
        public void AddCourseWorkStudent(Student student)
        {
            if (CourseWorkStudents.Count == MaxNumberOfCourseWorks) throw new IndexOutOfRangeException("Max num of students!");
            else CourseWorkStudents.Add(student);
        }
        public string GetInfoTeacher()
        {
            return base.GetInfo() + salary.ToString();
        }
    }
}
