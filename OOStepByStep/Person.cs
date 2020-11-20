﻿namespace OOStepByStep
{
    using System;
    public interface IIntroduce
    {
        public string Introduce();
    }

    public class Person : IIntroduce
    {
        private string name;
        private int age;
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public string Introduce()
        {
            return $"My name is {this.name},I am {this.age} years old.";
        }
    }

    public class Student : Person, IIntroduce
    {
        private string name;
        private int age;
        //private string profession;
        public Student(string name, int age) : base(name, age)
        {
            this.name = name;
            this.age = age;
        }

        public string Introduce()
        {
            return $"My name is {name},I am {age} years old.I am a student.";
        }
    }

    public class Teacher : Person, IIntroduce
    {
        private string name;
        private int age;
        public Teacher(string name, int age) : base(name, age)
        {
            this.name = name;
            this.age = age;
        }

        public string Introduce()
        {
            return $"My name is {name},I am {age} years old.I am a teacher.";
        }
    }
}
