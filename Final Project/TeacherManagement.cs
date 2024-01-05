using ConsoleTables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Final_Project
{
    internal class TeacherManagement
    {
        public static int[] Id;
        public static string[] Name;
        public static string[] Gender;
        public static string[] Subject;
        public static int n;
        public void manuItem()
        {
            start:
            Console.WriteLine("------------------------------Teacher Management-------------------------------");
            Console.WriteLine("2.1. Add Teacher");
            Console.WriteLine("2.2. Show Teacher");
            Console.WriteLine("2.3. Update Teacher");
            Console.WriteLine("2.4. Delete Teacher");
            Console.WriteLine("2.5. Search Teacher");
            Console.WriteLine("2.6. Exit");
            Console.WriteLine("--------------------------------------------------------------------------------");
            double option;
            Console.Write("Please select option: ");
            option = double.Parse(Console.ReadLine());
            switch (option)
            {
                case 2.1:
                    TeacherManagement teacherManagement = new TeacherManagement();
                    teacherManagement.AddTeacher();
                    break;
                case 2.2:
                    teacherManagement = new TeacherManagement();
                    teacherManagement.show();
                    break;
                case 2.3:
                    teacherManagement = new TeacherManagement();
                    teacherManagement.Update();
                    break;
                case 2.4:
                    teacherManagement = new TeacherManagement();
                    teacherManagement.Delete();
                    break;
                case 2.5:
                    teacherManagement = new TeacherManagement();
                    teacherManagement.search();
                    break;
                case 2.6:
                    teacherManagement = new TeacherManagement();
                    teacherManagement.exit();
                    break;
                default:
                    break;
            }
            goto start;
        }
        public void AddTeacher()
        {
            Console.WriteLine("---------------------------------Add Teacher---------------------------------");
            
            Console.Write("Enter N: ");
            n = int.Parse(Console.ReadLine());
            Id = new int[n];
            Name = new string[n];
            Gender = new string[n];
            Subject = new string[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter ID: ");
                Id[i] = int.Parse(Console.ReadLine());
                Console.Write("Enter Name: ");
                Name[i] = Console.ReadLine();
                Console.Write("Enter Gender: ");
                Gender[i] = Console.ReadLine();
                Console.Write("Enter Subject: ");
                Subject[i] = Console.ReadLine();
                Console.WriteLine("--------------------------------------------------------------------------------");
            }
        }
        
        public void show()
        {
            if (n == 0)
            {
                Console.WriteLine("No Data to show!");
                Console.WriteLine("--------------------------------------------------------------------------------");
            }
            else
            {
                Console.WriteLine("-----------------------------------Show Teacher----------------------------------");
                Console.WriteLine("---------------------------------------------------------------------------------");
                Console.WriteLine("|\tId\t|\tTeacher's Name\t  |\tGender\t|\tSubject\t        |");
                Console.WriteLine("---------------------------------------------------------------------------------");
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine("---------------------------------------------------------------------------------");
                    Console.WriteLine("|\t" + Id[i] + "\t|\t" + Name[i] + "\t          |\t" + Gender[i] + "\t|\t" + Subject[i] + "\t        |");
                    Console.WriteLine("---------------------------------------------------------------------------------");
                }
            }
        }
        public void Update()
        {
            if (n == 0)
            {
                Console.WriteLine("No Data To Update!");
                Console.WriteLine("--------------------------------------------------------------------------------");
            }
            else
            {
                bool checking = false;
                Console.Write("Enter Id for update: ");
                int update = Convert.ToInt32(Console.ReadLine());
                for (int j = 0; j < n; j++)
                {
                    if (Id[j] == update)
                    {
                        Console.Write("Enter Name: ");
                        Name[j] = Console.ReadLine();
                        Console.Write("Enter Gender: ");
                        Gender[j] = Console.ReadLine();
                        Console.Write("Enter Subject: ");
                        Subject[j] = Console.ReadLine();
                        checking = true;
                    }
                }
                if (checking == true)
                {
                    Console.WriteLine("Update Successfully");
                }
            }
        }
        public void Delete()
        {
            if (n == 0)
            {
                Console.WriteLine("No Data to deleted!");
                Console.WriteLine("--------------------------------------------------------------------------------");
            }
            else
            {
                bool deleted = false;
                Console.Write("Enter Id to deleted: ");
                int DeleteById = Convert.ToInt32(Console.ReadLine());
                int i = 0;
                while (i < n)
                {
                    if (Id[i] == DeleteById)
                    {
                        if (i < (n - 1))
                        {
                            for (int j = i; j < n - 1; j++)
                            {
                                Id[j] = Id[j + 1];
                                Name[j] = Name[j + 1];
                                deleted = true;
                            }
                        }
                        n--;
                    }
                    else
                    {
                        i++;
                    }
                }
                if (deleted == true)
                {
                    Console.WriteLine("Id: " + Id[i] + "Deleted Successfully");
                }
            }
        }
        public void search()
        {
            if (n == 0)
            {
                Console.WriteLine("No Data To Search!");
                Console.WriteLine("--------------------------------------------------------------------------------");
            }
            else
            {
                Console.Write("Enter Id for searching: ");
                int check = Convert.ToInt32(Console.ReadLine());
                bool checking = false;
                for (int j = 0; j < n; j++)
                {
                    if (Id[j] == check)
                    {
                        Console.WriteLine("-----------------------------------Show Teacher----------------------------------");
                        Console.WriteLine("---------------------------------------------------------------------------------");
                        Console.WriteLine("|\tId\t|\tTeacher's Name\t  |\tGender\t|\tSubject\t|");
                        Console.WriteLine("---------------------------------------------------------------------------------");
                        Console.WriteLine("---------------------------------------------------------------------------------");
                        Console.WriteLine("|\t" + Id[j] + "\t|\t" + Name[j] + "\t          |\t" + Gender[j] + "\t|\t" + Subject[j] + "\t        |");
                        Console.WriteLine("---------------------------------------------------------------------------------");
                        checking = true;
                    }
                }
                if (checking == true)
                {
                    Console.WriteLine("Search Successfully");
                }
                else
                {
                    Console.WriteLine("Search not found");
                }
            }
        }
        public void exit()
        {
            Program program = new Program();
            program.MenuItem();
        }
        public static void Main()
        {
            TeacherManagement teacherManagement = new TeacherManagement();
            teacherManagement.manuItem();
            Console.ReadKey();
        }
    }
}
