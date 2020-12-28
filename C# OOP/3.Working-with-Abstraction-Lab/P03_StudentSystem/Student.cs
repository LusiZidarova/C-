namespace P03_StudentSystem
{
    using System;
    using System.Collections.Generic;

    public class StudentSystem
    {
        private Dictionary<string, Student> repo;

        public StudentSystem()
        {
            this.Repo = new Dictionary<string, Student>();
        }

        public Dictionary<string, Student> Repo
        {
            get { return repo; }
            private set { repo = value; }
        }

        public void ParseCommand()
        {
            string[] args = Console.ReadLine().Split();

            if (args[0] == "Create")
            {
                var name = args[1];
                var age = int.Parse(args[2]);
                var grade = double.Parse(args[3]);
                if (!repo.ContainsKey(name))
                {
                    var student = new Student(name, age, grade);
                    Repo[name] = student;
                }
            }
            else if (args[0] == "Show")
            {
                var name = args[1];
                if (Repo.ContainsKey(name))
                {
                    var student = Repo[name];
                    string view = $"{student.Name} is {student.Age} years old.";

                    if (student.Grade >= 5.00)
                    {
                        view += " Excellent student.";
                    }
                    else if (student.Grade < 5.00 && student.Grade >= 3.50)
                    {
                        view += " Average student.";
                    }
                    else
                    {
                        view += " Very nice person.";
                    }

                    Console.WriteLine(view);
                }

            }
            else if (args[0] == "Exit")
            {
                Environment.Exit(0);
            }
        }
    }

    public class Student
    {
        private string name;
        private int age;
        private double grade;

        public double Grade
        {
            get { return grade; }
            set { grade = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Student(string name, int age, double grade)
        {
            this.Name = name;
            this.Age = age;
            this.grade = grade;
        }
    }
}
/*
 * Student System
You are given a working project for a small Student System, but the code is very poorly organized. Break up the code logically into smaller functional units – methods and classes and don’t break the functionality.
The program supports the following commands:
"Create {studentName} {studentAge} {studentGrade}" – creates a new student and adds them to the repository.
"Show {studentName}" – prints on the console information about a student in the format:
"{studentName} is {studentAge} years old. {commentary}", where the commentary is based on the student’s grade.
"Exit" – closes the program.
Following the next rules will help you to easily solve the problem:
You should have only one class in only one file!
You should remove any unnecessary data (usings, fields, properties, constants, etc.)!
You can use auto-properties if you don’t have any validation or encapsulation inside this property!
Most collections used inside the class should not be exposed to public because of its vulnerability!
You should break the code into smaller units (methods with appropriate return type)!
You should be consistent with the naming and the ordering of the elements of the class!
Do not add any extra validation or functionality to the app!
Examples
input	output
Create Pesho 20 5.50
Create Mimi 18 4.50
Create Gosho 25 3
Show Pesho
Show Mimi
Exit	

Output
Pesho is 20 years old. Excellent student.
Mimi is 18 years old. Average student.

 * */
