using System;
namespace TestAppBootcamp
{
	public class Dvd: LibraryItem, ISubtitle
	{
        public float DurationMinutes { get; set; }
        public bool BlankCover { get; set;  }


        public string Subtitle()
        {
            string subtitleExample = "This is subtitles for DVD";
            return subtitleExample;
        }

        public override string ToString()
        {
            return $"Dvd id: {IdLibraryItem} \nDvd Author: {AuthorName} \nPublication Year: {PublicationYear} \nDration: {DurationMinutes} \nBlank Cover: {BlankCover}";
        }

    }
}

