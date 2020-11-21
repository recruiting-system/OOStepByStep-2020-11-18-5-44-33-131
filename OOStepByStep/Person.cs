namespace OOStepByStep
{
    using System;
    using System.Collections.Generic;

    /*
public interface IIntroduce
{
public string Introduce();
}
*/
    public class SchoolClass
    {
        private string name;
        private Teacher teacher;
        private List<Student> students = new List<Student>();
        public SchoolClass(string name)
        {
            this.name = name;
        }

        public void AddStudent(Student student)
        {
            this.students.Add(student);
            student.SchoolClass = this.name;
        }

        public void AddTeacher(Teacher teacher)
        {
            this.teacher = teacher;
            teacher.SchoolClass = this.name;
        }

        public string KnowTheClass()
        {
            return this.name;
        }
    }

    public class Person
    {
        private string name;
        private int age;
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public virtual string Introduce()
        {
            return $"My name is {this.name},I am {this.age} years old.";
        }
    }

    public class Student : Person
    {
        private string profession;
        public Student(string name, int age) : base(name, age)
        {
            this.profession = "student";
        }

        public string SchoolClass { get; set; } = string.Empty;

        public new string Introduce()
        {
            string introduceMessage = (this.SchoolClass != string.Empty) ?
                $"{base.Introduce()}I am a {profession} of {SchoolClass}."
                : $"{base.Introduce()}I am a {profession}.";
            return introduceMessage;
        }

        public void AddToClass(SchoolClass schoolClass)
        {
            schoolClass.AddStudent(this);
        }
    }

    public class Teacher : Person
    {
        private string profession;
        public Teacher(string name, int age) : base(name, age)
        {
            this.profession = "teacher";
        }

        public string SchoolClass { get; set; } = string.Empty;

        public new string Introduce()
        {
            string introduceMessage = (this.SchoolClass != string.Empty) ?
                $"{base.Introduce()}I am a {profession} of {SchoolClass}."
                : $"{base.Introduce()}I am a {profession}.";
            return introduceMessage;
        }

        public void AddToClass(SchoolClass schoolClass)
        {
            schoolClass.AddTeacher(this);
        }
    }
}
