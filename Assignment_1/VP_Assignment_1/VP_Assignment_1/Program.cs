/*VP Assignment # 1
 * Name: Fiza Asif
 *Enrollment ID: 01-131152-009
 *Class: BSE-6A*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VP_Assignment_1
{
    class Program
    {
        static void Main(string[] args)
        {
            char choice, option, selection;
            string id, name, department, university;
            float gpa;
            int semester;

            string path = args[0];

            Student_Profile obj = new Student_Profile(path);
            obj.createFile();

            do
            {
                Console.WriteLine("\n\t\t*********************");
                Console.WriteLine("\t\t** STUDENT PROFILE **");
                Console.WriteLine("\t\t*********************\n");
                Console.WriteLine("\t1. Create Student Profile");
                Console.WriteLine("\t2. Search Student Record");
                Console.WriteLine("\t3. Delete Student Record");
                Console.WriteLine("\t4. List top 3 students");
                Console.WriteLine("\t5. Mark Student attendance");
                Console.WriteLine("\t6. View Student attendance");
                Console.Write("\n\tPlease enter your choice: ");
                choice = Convert.ToChar(Console.ReadLine());
                if (choice == '1')
                {
                    // get student information from user
                    Console.Write("\tEnter ID: ");
                    id = Convert.ToString(Console.ReadLine());
                    Console.Write("\n\tEnter Name: ");
                    name = Convert.ToString(Console.ReadLine());
                    Console.Write("\n\tEnter Semester: ");
                    semester = int.Parse(Console.ReadLine());
                    Console.Write("\n\tEnter GPA(0.0-4.0): ");
                    gpa = float.Parse(Console.ReadLine());
                    //check that gpa is not negative or greater than 4.0
                    if (gpa < 0.0 || gpa > 4.0)
                    {
                        Console.Write("\tGPA cannot be negative or greater than 4.0\n");
                        break;
                    }
                    Console.Write("\n\tEnter Department: ");
                    department = Convert.ToString(Console.ReadLine());
                    Console.Write("\n\tEnter University: ");
                    university = Convert.ToString(Console.ReadLine());
                    // write entered student information to file
                    obj.WriteToFile(id, name, semester, gpa, department, university);
                }
                else if (choice == '2')
                {
                    Console.WriteLine("\t1. Search by ID");
                    Console.WriteLine("\t2. Search by Name");
                    Console.WriteLine("\t3. Search by Semester");
                    Console.Write("\n\tPlease enter your choice: ");
                    selection = Convert.ToChar(Console.ReadLine());
                    switch (selection)
                    {
                        case '1':      //search student by ID 
                            Console.Write("\n\tEnter Student ID: ");
                            id = Convert.ToString(Console.ReadLine());
                            Console.WriteLine("");
                            obj.searchID(id);
                            break;
                        case '2':    //search student by Name
                            Console.Write("\n\tEnter Student Name: ");
                            name = Convert.ToString(Console.ReadLine());
                            Console.WriteLine("");
                            obj.searchName(name);
                            break;
                        case '3':    //search student by Semester
                            Console.Write("\n\tEnter Semester: ");
                            semester = int.Parse(Console.ReadLine());
                            Console.WriteLine("");
                            obj.searchSemester(semester);
                            break;
                        default:
                            Console.WriteLine("\n\tInvalid choice!!");
                            break;
                    }
                }
                else if (choice == '3')
                {
                    //search id and delete record of given id
                    Console.Write("\n\tEnter Student ID: ");
                    id = Convert.ToString(Console.ReadLine());
                    Console.WriteLine("");
                    obj.deleteData(id);
                }
                else if (choice == '4')
                {
                    //list top 3 students of a semester based on highest gpa
                    Console.Write("\n\tEnter Semester Number: ");
                    semester = int.Parse(Console.ReadLine());
                    Console.WriteLine("\n\tTop 3 students are:\n");
                    obj.listTopStudents(semester);
                }
                else if (choice == '5')
                {
                    //mark student attendance
                    Console.Write("\n\tEnter Semester Number: ");
                    semester = int.Parse(Console.ReadLine());
                    Console.WriteLine("");
                    obj.markAttendance(semester);
                }
                else if (choice == '6')
                {
                    //view marked student attendance
                    Console.Write("\n\tEnter Semester Number: ");
                    semester = int.Parse(Console.ReadLine());
                    Console.WriteLine("");
                    obj.viewAttendance(semester);
                }
                else
                {
                    Console.WriteLine("\tInvalid key. Try again");
                }
                Console.Write("\n\tDo you want to continue? (Y/N): ");
                option = Convert.ToChar(Console.ReadLine());
                Console.Clear(); //clears the screen
            }while (option != 'N' && option != 'n');
            Console.WriteLine("\n\t\t*********************");
            Console.WriteLine("\t\t      THANKYOU    ");
            Console.WriteLine("\t\t*********************\n");
        }
    }
}