namespace OOStepByStep
{
    using System;
    using System.Collections.Generic;

    public class SchoolClass
    {
        private string name;
        private Teacher teacher = null;
        private List<Student> students = new List<Student>();
        public SchoolClass(string name)
        {
            this.name = name;
        }

        public string AddStudent(Student student)
        {
            this.students.Add(student);
            student.SchoolClass = this.name;
            return WelcomeMessage(student);
        }

        public void AddTeacher(Teacher teacher)
        {
            this.teacher = teacher;
            teacher.SchoolClass = this.name;
        }

        public string WelcomeMessage(Student newStudent)
        {
            string studentsWelcome = string.Empty;
            string teacherWelcome = teacher == null ? string.Empty : $"{this.teacher.WelcomeNewStudent(newStudent)}\n";
            if (students.Count - 1 != 0)
            {
                foreach (Student oldStudent in students)
                {
                    studentsWelcome += $"{oldStudent.WelcomeNewStudent(newStudent)}\n";
                }
            }

            return teacherWelcome + studentsWelcome;
        }
    }

    public class Person
    {
        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name { get; set; }
        public int Age { get; set; }

        public virtual string Introduce()
        {
            return $"My name is {this.Name},I am {this.Age} years old.";
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

        public string WelcomeNewStudent(Student newStudent)
        {
            string welcomeMessage = $"{base.Introduce()}I am a {profession} of {SchoolClass}.Welcome {newStudent.Name} join in {SchoolClass}.";
            return welcomeMessage;
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

        public string WelcomeNewStudent(Student newStudent)
        {
            string welcomeMessage = $"{base.Introduce()}I am a {profession} of {SchoolClass}.Welcome {newStudent.Name} join in {SchoolClass}.";
            return welcomeMessage;
        }

        public void AddToClass(SchoolClass schoolClass)
        {
            schoolClass.AddTeacher(this);
        }
    }
}
