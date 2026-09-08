namespace c_.assig3
{

class Program
    {
        static void Main()
        {
            #region Question 1

            /* Given string title = "Refactoring",
             write a switch statement
            that prints "Great choice!" if the title is "Clean Code",
            "Nice pick!" if it's "Refactoring", 
            "Never heard of it" for anything else.*/


            //string title = "Refactoring";

            //switch (title)
            //{
            //    case "Clean Code":
            //        Console.WriteLine("Great choice!");
            //        break;

            //    case "Refactoring":
            //        Console.WriteLine("Nice pick!");
            //        break;

            //    default:
            //        Console.WriteLine("Never heard of it");
            //        break;
            //}

            #endregion



            #region Question 2

            // Given int pages = 464;, use the ternary operator to store
            // "Long Book" or "Short Book" into a variable sizeLabel
            // (same rule as question 8: long if pages > 300).

            //int pages = 464;
            //string sizeLabel = pages > 300 ? "Long Book" : "Short Book";
            //Console.WriteLine(sizeLabel);

            #endregion


            #region Question 3

            // Given string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" },
            // use a for loop to print each book with its position number,
            // like 1. Clean Code.

            //string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };

            //for (int i = 0; i < books.Length; i++)
            //{
            //    Console.WriteLine((i + 1) + "=>" + books[i]);
            //}

            #endregion


            #region Question 4

            // Using the same books array, use a while loop to print every book title.

            //string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };

            //int i = 0;

            //while (i < books.Length)
            //{
            //    Console.WriteLine((i+1 +"=>"+ books[i]) );
            //    i++;
            //}

            #endregion



            #region Question 5

            // Write a do-while loop that prints "Checking book..." exactly 3 times.

            //int i = 0;

            //do
            //{
            //    Console.WriteLine("Checking book...");
            //    i++;
            //}
            //while (i < 3);

            #endregion



            #region Question 6

            // Using the same books array, use a foreach loop to print every book title.

            //string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };

            //foreach (string book in books)
            //{
            //    Console.WriteLine(book);
            //}

            #endregion


            #region Question 7

            // Using the same books array, loop through it and print each title,
            // but stop completely (break) once you reach "Refactoring".

            //string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };

            //foreach (string book in books)
            //{
            //    Console.WriteLine(book);

            //    if (book == "Refactoring")
            //    {
            //        break;
            //    }
            //}

            #endregion



            #region Question 8

            // Using the same books array, print every title except
            // "The Pragmatic Programmer" (skip it with continue, don't stop the loop).

            string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };

            foreach (string book in books)
            {
                if (book == "The Pragmatic Programmer")
                {
                    continue;
                }

                Console.WriteLine(book);
            }

            #endregion


















        }
    }



}
