using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    public class People
    {
        protected string name;

        public string Name
        {
            get => this.name;
        }

        public People(string name)
        {
            Validate.isString(name);
            this.name = name;
        }

        public override string ToString()
        {
            return this.Name;
        }
    }

    public class Student : People
    {
        private int number;

        public int Number
        {
            get => this.number;
        }

        public Student(string name, int number) : base(name)
        {
            Validate.isPositive(number);
            this.number = number;
        }

        public override string ToString()
        {
            return "Student " + this.Name + " " + this.Number.ToString();

        }
    }

    public class Discipline
    {
        private string name;
        private int lectures;
        private int exercises;

        public string Name
        {
            get => this.name;
        }

        public int Lectures
        {
            get => this.lectures;
        }

        public int Exercises
        {
            get => this.exercises;
        }

        public Discipline(string name, int lectures, int exercises)
        {
            this.name = name;
            this.lectures = lectures;
            this.exercises = exercises;
        }
        public override string ToString()
        {
            return "Discipline " + this.Name + " " + this.Lectures.ToString()+ " " + this.Exercises.ToString();
        }
    }

    public class Teacher : People
    {
        private List<Discipline> disciplines;
        public Teacher(string name, List<Discipline> disciplines) : base(name)
        {
            Validate.isNull(disciplines);
            this.disciplines = disciplines;
        }

        public override string ToString()
        {
            string output = "";

            for (int i = 0; i < disciplines.Count; i++)
            {
                output += disciplines[i].ToString() + "\n";
            }

            return "Teacher " + this.Name + "\n" +  output;
        }
    }

    public class Class
    {
        private List<Student> students;
        private List<Teacher> teachers;

        public Class(string name, List<Student> students, List<Teacher> teachers)
        {
            Validate.isNull(students);
            Validate.isNull(teachers);
            this.students = students;
            this.teachers = teachers;
        }

        public override string ToString()
        {
            string output = "";

            for (int i = 0; i < students.Count; i++)
            {
                output += students[i].ToString() + "\n";
            }

            string output2 = "";

            for (int i = 0; i < teachers.Count; i++)
            {
                output2 += teachers[i].ToString() + "\n";
            }

            return "Teachers " + output2 + "\n" + "Students " + output;
        }
    }

    public class School
    {
        private List<Class> classes;
        public School(List<Class> classes)
        {
            Validate.isNull(classes);
            this.classes = classes;
        }

        public override string ToString()
        {
            string output = "";

            for (int i = 0; i < classes.Count; i++)
            {
                output += classes[i].ToString() + "\n";
            }

            return  output;
        }
    }
}
