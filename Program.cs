using System;
namespace movies
{
    class Program
    {
        enum Genre
        {
            PopRock,
            Singing,
            Folk,
            Popular,
            Jazz
        }
        struct Music
        {
            private string Title;
            private string Artist;
            private double Length;
            private Genre? Genre;

            public Music(string title, string artist, double length, Genre genre)
            {
                Title = title;
                Artist = artist;
                Length = length;
                Genre = genre;
            }
            public string Display()
            {
                return "Title: " + Title + "\nDescription: " + Artist +
                    "\nLength: " + Length + "\nGenre: " + Genre + "\n";
            }
            public void setTitle(string title)
            {
                Title = title;
            }
            public void setArtist(string artist)
            {
                Artist = artist;
            }
            public void setLength(double length)
            {
                Length = length;
            }
            public void setGenre(Genre genre)
            {
                Genre = genre;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("What is the title of your favorite song?");
            string tempTitle = Console.ReadLine();
            Console.WriteLine("What is the artist's name?");
            string tempArtist = Console.ReadLine();
            Console.WriteLine("What is the length of the song?");
            double tempLength = double.Parse(Console.ReadLine());
            Console.WriteLine("What is the genre?");
            Console.WriteLine("P - PopRock\nS - Singing\nF - Folk Music\nU - Popular\nJ - Jazz");
            Genre tempGenre = Genre.PopRock;
            char g = char.Parse(Console.ReadLine());
            switch (g)
            {
                case 'P':
                    tempGenre = Genre.PopRock;
                    break;
                case 'S':
                    tempGenre = Genre.Singing;
                    break;
                case 'F':
                    tempGenre = Genre.Folk;
                    break;
                case 'U':
                    tempGenre = Genre.Popular;
                    break;
                case 'J':
                    tempGenre = Genre.Jazz;
                    break;
            }
            Music music = new Music(tempTitle, tempArtist, tempLength, tempGenre);
            
            Music moreMusic = new Music();
            moreMusic.setTitle("Stars");
            moreMusic.setArtist("Skillet");
            moreMusic.setLength(3.47);
            moreMusic.setGenre(Genre.PopRock);
            
            Console.WriteLine($"{music.Display()}");
            Console.WriteLine($"{moreMusic.Display()}");
        }
    }
}