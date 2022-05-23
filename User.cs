using libraryManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Management
{
    public class User
    {
        public void loginAs()
        {
        loginmenu:
            Console.WriteLine("-------------------------------------");
            Console.WriteLine(" Lonin As Librarian Press 1");
            Console.WriteLine(" Login As Student Press 2");

            Console.WriteLine(" Exit Press 3");

            Console.WriteLine("______________________________________");
            int user = Convert.ToInt32(Console.ReadLine());
            switch (user)
            {
                case 1:
                    {
                    mainmenu:
                        mainMenu();
                        AvailableBooks Librarian = new AvailableBooks();
                        int input = Convert.ToInt32(Console.ReadLine());
                        switch (input)
                        {
                            case 1:
                                Librarian.CheckBooks();
                                goto mainmenu;
                            case 2:
                                Librarian.BorrowBook();
                                goto mainmenu;
                            case 3:
                                Librarian.UpdateBook();
                                goto mainmenu;

                            case 4:
                                Librarian.issueBook();
                                goto mainmenu;

                            case 5:
                                Environment.Exit(0);
                                break;
                            default:
                                Console.WriteLine("Invalid Choise ");
                                goto mainmenu;






                        }
                    }
                    break;
                case 2:
                StudentMainMenu:
                    StudentMainMenu();
                    AvailableBooks Student = new AvailableBooks();
                    int choise = Convert.ToInt32(Console.ReadLine());
                    switch (choise)
                    {
                        case 1:
                            Student.CheckBooks();
                            goto StudentMainMenu;
                        case 2:
                            Student.issueBook();
                            goto StudentMainMenu;
                        case 3:
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("Invalid Choise ");
                            goto StudentMainMenu; ;
                    }
                    break;
                    case 3:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine(" bad Input ");
                    Console.WriteLine("try Again");
                    goto loginmenu;


            }
                

        }


        private void mainMenu()
        {
            Console.WriteLine("----------------Main Menu ----------------");
            Console.WriteLine("Show All Books Press-          : 1");
            Console.WriteLine("Show All Borrowed  Books Press-: 2");
            Console.WriteLine("Add New  Books Press-          : 3");
            Console.WriteLine("Show Issue book Press          : 4");

            Console.WriteLine("Exit Press 5");
        }
        private void StudentMainMenu()
        {



            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Show All Books Press          :1");
            Console.WriteLine("Issue Book Press              :2");
            Console.WriteLine("Exit Press 3                  :3");
        }
    }



}

