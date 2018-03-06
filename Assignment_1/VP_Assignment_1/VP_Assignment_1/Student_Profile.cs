/*VP Assignment # 1
 * Name: Fiza Asif
 *Enrollment ID: 01-131152-009
 *Class: BSE-6A*/

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VP_Assignment_1
{
    class Student_Profile
    {
        private string path;

        public Student_Profile()
        {
            path = null;
        }

        public Student_Profile(string Path)
        {
            path = Path;
        }

        /* create file */
        public void createFile()
        {
            if (File.Exists(path) != true)
            {
                using (StreamWriter obj = File.CreateText(path)) //create the file 
                {
                    //write data to file
                    obj.WriteLine("01-131152-009 fiza 6 3.85 BSE Bahria");
                    obj.WriteLine("01-131152-001 hamza 6 3.7 BSE Bahria");
                    obj.WriteLine("01-131152-002 maryam 6 3.8 BSE Bahria");
                    obj.WriteLine("01-131152-013 sana 6 3.9 BSE Bahria");
                    obj.WriteLine("01-131152-015 fiza 5 3.78 BCE Bahria");
                    obj.WriteLine("01-131152-016 rabia 5 3.92 BSE Bahria");
                    obj.WriteLine("01-131152-020 rida 5 4.0 BCE Bahria");
                    obj.WriteLine("01-131152-006 sana 5 2.5 BSE Bahria");
                    obj.WriteLine("01-131152-019 mishal 4 3.5 BCE Bahria");
                    obj.WriteLine("01-131152-023 urooj 4 3.87 BSE Bahria");
                    obj.WriteLine("01-131152-010 arooj 4 2.6 BCE Bahria");
                    obj.WriteLine("01-131152-024 nawehya 4 4.0 BSE Bahria");
                }
            }
        }

        /* Write data to file*/

        public void WriteToFile(string id, string name, int Semester, float GPA, string department, string university)
        {
            StreamReader file = new StreamReader(path); //read file
            string line;
            bool check = true;
            while ((line = file.ReadLine()) != null) //read file till end
            {
                // If ID already exists don't write to file
                if (line.Contains(id) == true)
                {
                    Console.WriteLine("\n\tStudent id should be unique!!!");
                    check = false;
                    break;
                }
            }
            file.Close();  //close the file

            if (check == true)
            {
                using (StreamWriter obj = File.AppendText(path)) //write data to file at the end
                {
                    //obj.AutoFlush = true;
                    string student_info = id + " " + name + " " + Semester + " " + GPA + " " + department + " " + university + " ";
                    obj.WriteLine(student_info); //write student data to file
                    obj.Close(); //close the file
                }
            }
        }

        /*Search student by ID*/
        public void searchID(string id)
        {
            string line;
            bool check = false;
            using (StreamReader data = new StreamReader(path)) //read file
            {
                while ((line = data.ReadLine()) != null)
                {
                    if (line.Contains(id) == true)
                    {
                        Console.WriteLine(line);
                        check = true;
                    }
                }

                if (check == false)
                {
                    Console.WriteLine("\n\tRecord does not exist!!!");
                }
                data.Close(); //close file
            }
        }

        /*Search student by name*/
        public void searchName(string name)
        {
            string line;
            bool check = false;
            using (StreamReader data = new StreamReader(path)) //read file
            {
                
                while ((line = data.ReadLine()) != null)
                {
                    if (line.Contains(name) == true)
                    {
                        Console.WriteLine(line);
                        check = true;
                    }
                }
                if (check == false)
                {
                    Console.WriteLine("\tRecord does not exist!!!");
                }
                data.Close(); //close file
            }
        }

        /*Search student by semester*/
        public void searchSemester(int semester)
        {
            string line;
            bool check = false;
            int counter = 0;
            using (StreamReader data = new StreamReader(path)) //read file
            {
                while ((line = data.ReadLine()) != null)
                {
                    if (line.Contains(" " + semester.ToString() + " ") == true)
                    {
                        Console.WriteLine(line);
                        counter++;
                        check = true;
                    }
                }
                if (check == false)
                {
                    Console.WriteLine("\n\tRecord does not exist!!!");
                }
                //displays total number of students
                Console.WriteLine("\n\tTotal number of students: " + counter);
                data.Close(); //close file
            }
        }

        /*delete student record based on enrollment ID*/
        public void deleteData(string id)
        {
            //read every line of file into a string array where each element represents one line of file
            string[] list = File.ReadAllLines(path);

            using (StreamWriter file = new StreamWriter(path)) //write to file
            {
                for (int i = 0; i < list.Length; i++)
                {
                    //check if list contains ID skip it and continue other writing  lines
                    if (list[i].Contains(id) == true) 
                    {
                        continue;
                    }
                    else
                    {
                        file.WriteLine(list[i]); //write data to file
                    }
                }
                file.Close(); //close file
            }
        }

        /*list top 3 students based on semester*/
        public void listTopStudents(int semester)
        {
            string line;
            bool check = false;
            //creates a list of string values
            List<string> gpa = new List<string>();

            using (StreamReader data = new StreamReader(path))
            {

                while ((line = data.ReadLine()) != null)
                {
                    if (line.Contains(" " + semester + " ") == true) 
                    {
                        gpa.Add(line); //add values to list
                        check = true;
                    }
                }
                if (check == false)
                {
                    Console.WriteLine("\n\tRecord does not exist!!!");
                }
                data.Close(); //close file
            }
            Console.WriteLine(gpa.Max());
            gpa.Remove(gpa.Max());
            Console.WriteLine(gpa.Max());
            gpa.Remove(gpa.Max());
            Console.WriteLine(gpa.Max());
        }

        /*Mark attendance of students of selected semester*/
        public void markAttendance(int semester)
        {
            //read every line of file into a string array where each element represents one line of file
            string[] list = File.ReadAllLines(path);
            string attendance = null;
            char mark;
            bool check = false;

            for (int i = 0; i < list.Length; i++)
            {
                //check if data contains semester
                if (list[i].Contains(" " + semester + " ") == true)
                {
                    check = true;
                    Console.WriteLine(list[i]);
                    Console.Write("\tAbsent / Present (A/P): ");
                    mark = Convert.ToChar(Console.ReadLine());
                    if(mark=='a' || mark=='A')
                    {
                        attendance = "Absent";
                        list[i] = list[i] + " " + attendance; //concatenate attendance with data
                    }
                    else if (mark=='p' || mark=='P')
                    {
                        attendance = "Present";
                        list[i] = list[i] + " " + attendance; //concatenate attendance with data
                    }
                    else
                    {
                        Console.WriteLine("\n\tInvalid! attendance can only be marked as A/a or P/p ");
                        break;
                    }
                }
            }
            if (check == false)
            {
                Console.WriteLine("\n\tNo record found");
            }

            //writing new record to file with attendance

            using (StreamWriter file = new StreamWriter(path))
            {
                for (int i = 0; i < list.Length; i++)
                {
                        file.WriteLine(list[i]); //write data to file

                }
                file.Close(); //close file
            }
        }

        /*view marked attendance of students*/
        public void viewAttendance(int semester)
        {
            //read every line of file into a string array where each element represents one line of file
            string[] list = File.ReadAllLines(path);
            bool check = false;

            for (int i = 0; i < list.Length; i++)
            {
                //check if list has semester and ends with marked attendance
                if (list[i].Contains(" " + semester + " ") == true && (list[i].EndsWith("Absent") || list[i].EndsWith("Present")))
                {
                    Console.WriteLine(list[i]); //display marked attendance
                    check = true;
                }
            }
            // if no attendance has been marked
            if(check==false)
            {
                Console.WriteLine("\n\tAttendance of this semester has not been marked!");
            }

        }
    }
}

