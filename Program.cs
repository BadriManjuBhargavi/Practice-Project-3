using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRACTICE_PROJECT_3
{


        // Base class for school personnel
        class Person
        {
            public string Name { get; set; }
            public string ClassSection { get; set; }
        }

        // Student class inheriting from Person
        class Student : Person { }

        // Teacher class inheriting from Person
        class Teacher : Person { }

        // Subject class
        class Subject
        {
            public string Name { get; set; }
            public string SubjectCode { get; set; }
            public Teacher Teacher { get; set; }
        }

        class SchoolData
        {
            // Lists to store students, teachers, and subjects
            private List<Student> students;
            private List<Teacher> teachers;
            private List<Subject> subjects;

            public SchoolData()
            {
                students = new List<Student>();
                teachers = new List<Teacher>();
                subjects = new List<Subject>();
            }

            // Method to add students to the list
            public void AddStudent(Student student)
            {
                students.Add(student);
            }

            // Method to add teachers to the list
            public void AddTeacher(Teacher teacher)
            {
                teachers.Add(teacher);
            }

            // Method to add subjects to the list
            public void AddSubject(Subject subject)
            {
                subjects.Add(subject);
            }

            // Method to display students in a given class and section
            public void DisplayStudentsInClassSection(string classSection)
            {
                Console.WriteLine($"Students in Class {classSection}:");
                foreach (var student in students)
                {
                    if (student.ClassSection == classSection)
                    {
                        Console.WriteLine($"- {student.Name}");
                    }
                }
            }

            // Method to display subjects taught by a given teacher
            public void DisplaySubjectsByTeacher(string teacherName)
            {
                Console.WriteLine($"Subjects taught by {teacherName}:");
                foreach (var subject in subjects)
                {
                    if (subject.Teacher.Name == teacherName)
                    {
                        Console.WriteLine($"- {subject.Name} (Code: {subject.SubjectCode})");
                    }
                }
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                SchoolData schoolData = new SchoolData();

                // Filling up the lists with dummy data
                Student student1 = new Student { Name = "John", ClassSection = "10A" };
                Student student2 = new Student { Name = " Smith", ClassSection = "9B" };
                schoolData.AddStudent(student1);
                schoolData.AddStudent(student2);

                Teacher teacher1 = new Teacher { Name = "Mr. Johnson", ClassSection = "10A" };
                Teacher teacher2 = new Teacher { Name = "Mrs. Anderson", ClassSection = "9B" };
                schoolData.AddTeacher(teacher1);
                schoolData.AddTeacher(teacher2);

                Subject subject1 = new Subject { Name = "Mathematics", SubjectCode = "MATH101", Teacher = teacher1 };
                Subject subject2 = new Subject { Name = "Science", SubjectCode = "SCI101", Teacher = teacher2 };
                schoolData.AddSubject(subject1);
                schoolData.AddSubject(subject2);

                // Displaying the lists
                schoolData.DisplayStudentsInClassSection("10A");
                schoolData.DisplaySubjectsByTeacher("Mr. Johnson");
            }
        }

    }

