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
    public class Class
    {
        private Teacher teacher;
        private List<Student> students;
        public Class()
        {
        }

        public void AddStudent(Student student)
        {
            this.students.Add(student);
            student.Class = $"{this}";
        }

        public void AddTeacher(Student student)
        {
            this.teacher = teacher;
            teacher.Class = $"{this}";
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

        public string Class { get; set; }

        public new string Introduce()
        {
            return $"{base.Introduce()}I am a {profession}.";
        }
    }

    public class Teacher : Person
    {
        private string profession;
        public Teacher(string name, int age) : base(name, age)
        {
            this.profession = "teacher";
        }

        public string Class { get; set; }

        public new string Introduce()
        {
            return $"{base.Introduce()}I am a {profession}.";
        }
    }
}
