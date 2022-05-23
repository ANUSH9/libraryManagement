using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; 
using Microsoft.VisualBasic;

namespace libraryManagement
{
    public class AvailableBooks
    {
        

        public void CheckBooks()
        {
            FileStream Avlbook = new FileStream(@"F:\New folder\book.txt", FileMode.Open, FileAccess.Read);
            StreamReader Avlbooks = new StreamReader(Avlbook);
            Console.WriteLine("AvailableBookName");
            while (Avlbooks.Peek() > 0)
            {
                string line = Avlbooks.ReadLine(); //studid
                if (line != "")
                    if (!line.StartsWith("Book"))
                    {
                        string[] myStrs = line.Split(',');

                        Console.WriteLine(myStrs[0] + "\t" + myStrs[1]);
                    }
            }

        }
        public void UpdateBook()
        {
            FileStream fd = new FileStream(@"F:\New folder\book.txt", FileMode.Create, FileAccess.Write);
            StreamWriter sd = new StreamWriter(fd);
            Console.Write("Enter BookName");
            sd.Write(Console.ReadLine());

            sd.Close();
            fd.Close();
            Console.WriteLine("Completely Updated");
        }
        public void findBook()
        {
            String[] words = File.ReadAllText("F:\\New folder\\book.txt").Split(',');
            Console.Write("Write a Book To search in Library");
            string booksearch = Console.ReadLine();
            bool condition = false;
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Contains(booksearch)==true)
                {
                    condition = true;
                    break;
                }
                else
                {
                    condition=false;
                }
            }
            if (condition == true)
            {
                Console.WriteLine("Book Found", booksearch);
            }
            else
            {
                Console.WriteLine("Book Not Found", booksearch);
            }

        }
        public void BorrowBook()
        {
            FileStream Borrow = new FileStream("F:\\New folder\\issue.txt", FileMode.Open, FileAccess.Read);
            StreamReader BorrowD = new StreamReader(Borrow);
            Console.WriteLine("ID" + "\t" + "Name" + "\t" + "BookName"+"\t" + "IssueDate");
            while (BorrowD.Peek() > 0)
            {
                string line = BorrowD.ReadLine(); //studid
                if (line != "")
                    if (!line.EndsWith("Date"))
                    {
                        string[] myStrs = line.Split(',');

                        Console.WriteLine(myStrs[0] + "\t" + myStrs[1] + "\t" + myStrs[2]+"\t\t"+ myStrs[3]);
                    }
            }
        }
        public void issueBook()
        {
            {
                FileStream fd = new FileStream(@"F:\New folder\issue.txt", FileMode.Create, FileAccess.Write);
                StreamWriter sd = new StreamWriter(fd);
                Console.Write("Enter StudentID:");
                sd.Write(Console.ReadLine());
                Console.Write("Enter Student Name:");
                sd.Write(Console.ReadLine());
                Console.Write("Enter Book Name:");
                sd.Write(Console.ReadLine());
                Console.Write("Enter issueDate:");
                sd.Write(Console.ReadLine());
                sd.Close();
                fd.Close();
                Console.WriteLine("Completely Updated");
            }

        }



    }
}
