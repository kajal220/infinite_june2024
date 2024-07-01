using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Assignment5
    {


        public class Books
        {

            public string BookName { get; set; }
            public string AuthorName { get; set; }


            public Books(string bookName, string authorName)
            {
                BookName = bookName;
                AuthorName = authorName;
            }


            public void Display()
            {
                Console.WriteLine($"Book Name: {BookName}");
                Console.WriteLine($"Author: {AuthorName}");
                Console.WriteLine();
            }
        }


        public class BookShelf
        {

            private Books[] arr = new Books[5];


            public Books this[int index]
            {
                get
                {
                    if (index >= 0 && index < 5)
                    {
                        return arr[index];
                    }
                    return null;
                }
                set
                {
                    if (index >= 0 && index < 5)
                    {
                        arr[index] = value;
                    }

                }
            }


            class Program
            {
                static void Main(string[] args)
                {

                    BookShelf shelf = new BookShelf();


                    for (int i = 0; i < 5; i++)
                    {
                        Console.WriteLine($"Enter details for book {i + 1}:");
                        Console.Write("Book Name: ");
                        string bookName = Console.ReadLine();
                        Console.Write("Author Name: ");
                        string authorName = Console.ReadLine();


                        shelf[i] = new Books(bookName, authorName);
                    }


                    for (int i = 0; i < 5; i++)
                    {
                        Console.WriteLine($"Details of book {i + 1}:");
                        shelf[i].Display();
                    }

                    Console.WriteLine("==========DIMENSIONS OF BOX============");
                    Test.dimensions_of_box();
                    Console.WriteLine("=========EMPLOYEE DETAILS============");
                    Employee_Details.details();
                    Console.WriteLine("===========STUDENT DETAILS============");
                    Student.student();
                    Console.Read();
                }
            }
        }
    }
