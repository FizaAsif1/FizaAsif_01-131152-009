using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VP_Assignment_2
{
    class Student_Profile
    {
        private string path;
        private static Student_Profile file;

        public static Student_Profile fileOps
        {
            get
            {
                if (file == null)
                    file = new Student_Profile("profile.txt");
                return file;
            }
        }

        private Student_Profile(string Path)
        {
            this.path = Path;
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
                    MessageBox.Show("Student id should be unique!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    check = false;
                    break;
                }
            }
            file.Close();  //close the file

            if (check == true)
            {
                using (StreamWriter obj = File.AppendText(path)) //write data to file at the end
                {
                    string student_info = id + " " + name + " " + Semester + " " + GPA + " " + department + " " + university + " ";
                    obj.WriteLine(student_info); //write student data to file
                    obj.Close(); //close the file
                }
                MessageBox.Show("Record has been saved successfully", "Save Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /*Search student by ID*/
        public string searchID(string id)
        {
            string line;
            
            bool check = false;
            using (StreamReader data = new StreamReader(path)) //read file
            {
                while ((line = data.ReadLine()) != null)
                {
                    if (line.Contains(id) == true)
                    {
                        check = true;
                        return line;
                    }
                }

                if (check == false)
                {
                    MessageBox.Show("Record does not exist!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return null;
                }
                return null;
            }
        }

        /*Search student by name*/
        public string[] searchName(string name)
        {
            //string line;
            string[] line= File.ReadAllLines(path);
            string[] result = new string[line.Length];
            int count = 0;
            bool check = false;

            for (int i = 0; i < line.Length; i++ )
            {
                if(line[i].Contains(name) == true)
                {
                    result[count] = line[i];
                    check = true;
                    count++;
                }
            }
               
            if (check == false)
            {
                MessageBox.Show("Record does not exist!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return result;
        }

        /*Search student by semester*/
        public string[] searchSemester(int semester)
        {
            string[] line = File.ReadAllLines(path);
            string[] result = new string[line.Length];
            int count = 0;
            int counter = 0; //to check no. of students
            bool check = false;

            for (int i = 0; i < line.Length; i++)
            {
                if (line[i].Contains(" " + semester.ToString() + " ") == true)
                {
                    result[count] = line[i];
                    check = true;
                    counter++;
                    count++;
                }
            }

            if (check == false)
            {
                MessageBox.Show("Record does not exist!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return result;
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
            MessageBox.Show("Record has been deleted successfully", "Delete Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /*list top 3 students based on semester*/
        public string[] listTopStudents(int semester)
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
                    MessageBox.Show("Record does not exist!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                data.Close(); //close file
            }
            string[] result = new string[3];
            for (int i = 0; i < 3; i++ )
            {
                result[i]=gpa.Max();
                gpa.Remove(gpa.Max());
            }
            return result;
        }

        /*Mark attendance of students of selected semester*/
        public void markAttendance(int semester, bool [] attendance)
        {
            //read every line of file into a string array where each element represents one line of file
            string[] list = File.ReadAllLines(path);
            int count = 0;
            bool check = false;

            for (int i = 0; i < list.Length; i++)
            {
                //check if data contains semester
                if (list[i].Contains(" " + semester + " ") == true)
                {
                    check = true;                                        
                    if (attendance[count] == false)
                    {
                        
                        list[i] = list[i] + " Absent"; //concatenate attendance with data
                    }
                    else 
                    {
                        list[i] = list[i] + " Present"; //concatenate attendance with data
                    }
                    count++;               
                }

            }
            MessageBox.Show("Attendance Marked Successfully", "Attendance Status", MessageBoxButtons.OK, MessageBoxIcon.Information);

            
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
        public string [] viewAttendance(int semester)
        {
            //read every line of file into a string array where each element represents one line of file
            string[] list = File.ReadAllLines(path);
            string[] result = new string[list.Length];
            int counter = 0;
            bool check = false;

            for (int i = 0; i < list.Length; i++)
            {
                //check if list has semester and ends with marked attendance
                if (list[i].Contains(" " + semester + " ") == true && (list[i].EndsWith("Absent") || list[i].EndsWith("Present")))
                {
                    result[counter] = list[i];
                    check = true;
                    counter++;
                }
            }
            // if no attendance has been marked
            if (check == false)
            {
                MessageBox.Show("Attendance of this semester has not been marked!", "Attendance Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return result;
        }
    }
}
