using System;
namespace TestAppBootcamp
{
	public class Book: LibraryItem
	{
        public int Pages  { set; get; }

        public string Isbn  { get; set; }


        public override string ToString()
        {
            return $"Book id: {IdLibraryItem} \nBook Author: {AuthorName} \nPublication Year: {PublicationYear} " +
                $"\nNumber of Pages: {Pages} \nIsbn: {Isbn}";
        }
    }
}

