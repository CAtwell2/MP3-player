
using MP3Tracker;
using System;

namespace MP3Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to MP3 Tracker");
            Console.Write("Please enter your name:");
            string userName = Console.ReadLine();

            MP3 mp3 = null;

            while (true)
            {
                Console.WriteLine("---------------Main Menu---------------");
                Console.WriteLine("1. Create a new MP3");
                Console.WriteLine("2. Display existing MP3");
                Console.WriteLine("3. Exit");
                Console.WriteLine("Enter your choice (1-3):");

                int menuChoice = Convert.ToInt32(Console.ReadLine());
                if (menuChoice == 1)
                {
                    mp3 = new MP3();
                    Console.Write("Enter song title:");
                    mp3.SongTitle = Console.ReadLine();
                    Console.Write("Enter artist name:");
                    mp3.Artist = Console.ReadLine();
                    Console.Write("Enter song release date:");
                    mp3.SongReleaseDate = Console.ReadLine();
                    Console.Write("Enter playback time in minutes:");
                    mp3.PlaybackTime = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter genre (Rock, Pop, Jazz, Country, Classical, Other):");
                    string genre = Console.ReadLine();
                    mp3.Genre = (Genre)Enum.Parse(typeof(Genre), genre);
                    Console.Write("Enter download cost:");
                    mp3.DownloadCost = Convert.ToDecimal(Console.ReadLine());
                    Console.Write("Enter file size in MBs:");
                    mp3.FileSize = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter path of album cover photo:");
                    mp3.AlbumCoverPath = Console.ReadLine();
                }
                else if (menuChoice == 2)
                {
                    if (mp3 != null)
                    {
                        Console.WriteLine(mp3.ToString());
                    }
                    else
                    {
                        Console.Write("No MP3 exists. Please create a new MP3 first.");
                    }
                }
                else if (menuChoice == 3)
                {
                    Console.WriteLine($"Goodbye {userName}! Thank you for using MP3 Tracker");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please try again.");
                }
            }
        }
    }
}
