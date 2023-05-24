using System.Collections.Generic;
using TestAppBootcamp;

internal class Program
{
    public static void Main(string[] args)
    {
       
        List<LibraryItem> library = new List<LibraryItem>();

        string userChoice;
        do
        {
 
            Console.WriteLine("Enter 1 to add Book, 2 to add Dvd or 0 to exit program and show all Library items");
            userChoice   = Console.ReadLine();

            switch (userChoice) {

                case "1":
                    Book newBook = new Book();
                    Console.WriteLine("Enter Author's Name: ");
                    newBook.AuthorName = Console.ReadLine();

                    newBook.IdLibraryItem = Guid.NewGuid();

                    Console.WriteLine("Enter Publication Year: ");
                    newBook.PublicationYear = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter Page Numbers: ");
                    newBook.Pages = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter Isbn: ");
                    newBook.Isbn = Console.ReadLine();

                    library.Add(newBook);
                    break;

                case "2":
                    Dvd newDvd = new Dvd();
                    Console.WriteLine("Enter Authors Name: ");
                    newDvd.AuthorName = Console.ReadLine();

                    newDvd.IdLibraryItem = Guid.NewGuid();

                    Console.WriteLine("Enter Publication Year: ");
                    newDvd.PublicationYear = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter Dutration Minutes: ");
                    newDvd.DurationMinutes = float.Parse(Console.ReadLine());

                    Console.WriteLine("Does the DVD have a blank cover? (true/false): ");
                    newDvd.BlankCover = Convert.ToBoolean(Console.ReadLine());

                    library.Add(newDvd);
                    break;

                case "0":
                    break;

                default:
                    Console.WriteLine("You enter invalid number. Please try again.");
                    break;
            }

        } while (userChoice != "0");

        

        foreach (LibraryItem item in library) {
            Console.WriteLine(item.ToString());
            Console.WriteLine("-------------");
      
        }


        Console.ReadLine();



    }
}