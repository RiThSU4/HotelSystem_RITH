using ConsoleTables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Final_Project
{
    internal class StudentManagement
    {
        public static int[] Id;
        public static string[] Name;
        public static string[] Gender;
        public static string[] Address;
        public static int n;
        public void Manuitem()
        {
            start:
            Console.WriteLine("---------------------------Student Management----------------------------");
            Console.WriteLine("3.1. Add Student");
            Console.WriteLine("3.2. Show Student");
            Console.WriteLine("3.3. Update Student");
            Console.WriteLine("3.4. Delete Student");
            Console.WriteLine("3.5. Search Student");
            Console.WriteLine("3.6. Exit");
            Console.WriteLine("-------------------------------------------------------------------------");
            double option;
            Console.Write("Please select option: ");
            option = double.Parse(Console.ReadLine());
            switch (option)
            {
                case 3.1:
                    StudentManagement studentManagement = new StudentManagement();
                    studentManagement.Addstudent();
                    break;
                case 3.2:
                    studentManagement = new StudentManagement();
                    studentManagement.Show();
                    break;
                case 3.3:
                    studentManagement = new StudentManagement();
                    studentManagement.Update();
                    break;
                case 3.4:
                    studentManagement = new StudentManagement();
                    studentManagement.Delete();
                    break;
                case 3.5:
                    studentManagement = new StudentManagement();
                    studentManagement.search();
                    break;
                case 3.6:
                    studentManagement = new StudentManagement();
                    studentManagement.exit();
                    break;
                default:
                    break;
            }
            goto start;
        }
        public void Addstudent()
        {
            Console.WriteLine("-----------------------------Add Student------------------------------");
            
            Console.Write("Enter N: ");
            n = int.Parse(Console.ReadLine());
            Id = new int[n];
            Name = new string[n];
            Gender = new string[n];
            Address = new string[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter Id: ");
                Id[i] = int.Parse(Console.ReadLine());
                Console.Write("Enter Name: ");
                Name[i] = Console.ReadLine();
                Console.Write("Enter Gender: ");
                Gender[i] = Console.ReadLine();
                Console.Write("Enter Address: ");
                Address[i] = Console.ReadLine();
                Console.WriteLine("-----------------------------------------------------------------------");
            }
        }
        public void Show()
        {
            if (n == 0)
            {
                Console.WriteLine("No Data to show!");
                Console.WriteLine("-----------------------------------------------------------------------");
            }
            else
            {
                Console.WriteLine("-----------------------------------Show Student----------------------------------");
                Console.WriteLine("---------------------------------------------------------------------------------");
                Console.WriteLine("|\tId\t|\tStudent's Name\t  |\tGender\t|\tAddress\t        |");
                Console.WriteLine("---------------------------------------------------------------------------------");
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine("---------------------------------------------------------------------------------");
                    Console.WriteLine("|\t" + Id[i] + "\t|\t" + Name[i] + "\t          |\t" + Gender[i] + "\t|\t" + Address[i] + "\t        |");
                    Console.WriteLine("---------------------------------------------------------------------------------");
                }
            }
        }
        public void Update()
        {
            if (n == 0)
            {
                Console.WriteLine("No Data To Update!");
                Console.WriteLine("-----------------------------------------------------------------------");
            }
            else
            {
                bool checking = false;
                Console.WriteLine("Enter Id for update: ");
                int update = Convert.ToInt32(Console.ReadLine());
                for (int j = 0; j < n; j++)
                {
                    if (Id[j] == update)
                    {
                        Console.Write("Enter Name: ");
                        Name[j] = Console.ReadLine();
                        Console.Write("Enter Gender: ");
                        Gender[j] = Console.ReadLine();
                        Console.Write("Enter Address: ");
                        Address[j] = Console.ReadLine();
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
                Console.WriteLine("-----------------------------------------------------------------------");
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
                Console.WriteLine("-----------------------------------------------------------------------");
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
                        Console.WriteLine("-----------------------------------Show Student----------------------------------");
                        Console.WriteLine("---------------------------------------------------------------------------------");
                        Console.WriteLine("|\tId\t|\tStudent's Name\t  |\tGender\t|\tAddress\t|");
                        Console.WriteLine("---------------------------------------------------------------------------------");
                        Console.WriteLine("---------------------------------------------------------------------------------");
                        Console.WriteLine("|\t" + Id[j] + "\t|\t" + Name[j] + "\t          |\t" + Gender[j] + "\t|\t" + Address[j] + "\t        |");
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
            StudentManagement studentManagement = new StudentManagement();
            studentManagement.Manuitem();
            Console.ReadKey();
        }
    }
}
