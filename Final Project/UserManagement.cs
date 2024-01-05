using ConsoleTables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml;

namespace Final_Project
{
    internal class UserManagement
    {
        public static int[] Id;
        public static string[] Name;
        public static string[] Gender;
        public static string[] password;
        public static int n;

        public void ManuItem()
        {
            start:
            Console.WriteLine("---------------------------------User Management--------------------------------");
            Console.WriteLine("1.1. Add User");
            Console.WriteLine("1.2. Show User");
            Console.WriteLine("1.3. Update User");
            Console.WriteLine("1.4. Delete User");
            Console.WriteLine("1.5. Search User");
            Console.WriteLine("1.6. Exit");
            Console.WriteLine("---------------------------------------------------------------------------------");
            double option;
            Console.Write("Please select option:");
            option = double.Parse(Console.ReadLine());
            switch (option)
            {
                case 1.1:
                    UserManagement userManagement = new UserManagement();
                    userManagement.Add();
                    break;
                case 1.2:
                    userManagement = new UserManagement();
                    userManagement.Show();
                    break;
                case 1.3:
                    userManagement = new UserManagement();
                    userManagement.Update();
                    break;
                case 1.4:
                    userManagement = new UserManagement();
                    userManagement.Delete();
                    break;
                case 1.5:
                    userManagement = new UserManagement();
                    userManagement.search();
                    break;
                case 1.6:
                    userManagement = new UserManagement();
                    userManagement.Exit();
                    break;
                default:
                    break;
            }
            goto start;
        }
        public void Add()
        {
            Console.WriteLine("-------------------------------------Add User-----------------------------------");
            
            Console.Write("Enter N: ");
            n = int.Parse(Console.ReadLine());
            Id = new int[n];
            Name = new string[n];
            Gender = new string[n];
            password = new string[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter Id: ");
                Id[i] = int.Parse(Console.ReadLine());
                Console.Write("Enter Name: ");
                Name[i] = Console.ReadLine();
                Console.Write("Enter Gender: ");
                Gender[i] = Console.ReadLine();
                Console.Write("Enter Password: ");
                password[i] = Console.ReadLine();
                Console.WriteLine("---------------------------------------------------------------------------------");
            }
        }
        
        public void Show()
        {
            if (n == 0)
            {
                Console.WriteLine("No Data To Show!");
                Console.WriteLine("---------------------------------------------------------------------------------");
            }
            else
            {
                Console.WriteLine("-----------------------------------Show User-------------------------------------");
                Console.WriteLine("---------------------------------------------------------------------------------");
                Console.WriteLine("|\tId\t|\tUser's Name\t  |\tGender\t|\tPassword\t|");
                Console.WriteLine("---------------------------------------------------------------------------------");
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine("---------------------------------------------------------------------------------");
                    Console.WriteLine("|\t" + Id[i] + "\t|\t" + Name[i] + "\t          |\t" + Gender[i] + "\t|\t" + password[i] + "\t        |");
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
                        Console.Write("Enter Password: ");
                        password[j] = Console.ReadLine();
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
                Console.WriteLine("No Data To Delete!");
                Console.WriteLine("--------------------------------------------------------------------------------");
            }
            else
            {
                bool deleted = false;
                Console.Write("Enter Id To Delete: ");
                int deleteById = Convert.ToInt32(Console.ReadLine());
                int i = 0;
                while (i < n)
                {
                    if (Id[i] == deleteById)
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
                    Console.WriteLine("Id:" + Id[i] + " Deleted Successfully");
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
                        Console.WriteLine("-----------------------------------Show User-------------------------------------");
                        Console.WriteLine("---------------------------------------------------------------------------------");
                        Console.WriteLine("|\tId\t|\tUser's Name\t  |\tGender\t|\tPassword\t|");
                        Console.WriteLine("---------------------------------------------------------------------------------");
                        Console.WriteLine("---------------------------------------------------------------------------------");
                        Console.WriteLine("|\t" + Id[j] + "\t|\t" + Name[j] + "\t          |\t" + Gender[j] + "\t|\t" + password[j] + "\t        |");
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
        public void Exit()
        {
            Program program = new Program();
            program.MenuItem();
        }
        public static void Main()
        {
            UserManagement userManagement = new UserManagement();
            userManagement.ManuItem();
            Console.ReadKey();
        }
    }
}
