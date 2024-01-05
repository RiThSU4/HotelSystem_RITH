using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Final_Project
{
    internal class Program
    {
        int Login()
        {
            string UserName, Password;
            Console.WriteLine("---------------------------------System Login-----------------------------------");
            Console.Write("Username:");
            UserName = Console.ReadLine();
            Console.Write("Password:");
            Password = Console.ReadLine();
            if(UserName.Equals("rith") && Password.Equals("123"))
            {
                return 1;
            }
            return 0;
        }
        public void MenuItem()
        {
            start:
            Console.WriteLine("-----------------------------Scool Management System----------------------------");
            Console.WriteLine("1.User Management");
            Console.WriteLine("2.Teacher Management");
            Console.WriteLine("3.Student Management");
            Console.WriteLine("--------------------------------------------------------------------------------");
            int option;
            Console.Write("Please select option: ");
            option = int.Parse(Console.ReadLine());
            switch(option)
            {
                case 1:
                    UserManagement userManagement = new UserManagement();
                    userManagement.ManuItem();
                    break;
                case 2:
                    TeacherManagement teacherManagement = new TeacherManagement();
                    teacherManagement.manuItem();
                    break;
                case 3:
                    StudentManagement studentManagement = new StudentManagement();
                    studentManagement.Manuitem();

                    break;
                default:
                    break;
            }
            goto start;
        }
        public static void Main()
        {
            Program program = new Program();
            //int checkLogin = program.Login();
            again:
            if(program.Login() == 1)
            {
                Console.WriteLine("Login Successfull");
                program.MenuItem();
                
            }
            else
            {
                Console.WriteLine("Login Fail");
            }
            goto again;

            Console.ReadKey();
        }
    }
}
