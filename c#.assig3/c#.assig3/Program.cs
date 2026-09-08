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


            string title = "Refactoring";

            switch (title)
            {
                case "Clean Code":
                    Console.WriteLine("Great choice!");
                    break;

                case "Refactoring":
                    Console.WriteLine("Nice pick!");
                    break;

                default:
                    Console.WriteLine("Never heard of it");
                    break;
            }

            #endregion


















        }
    }



}
