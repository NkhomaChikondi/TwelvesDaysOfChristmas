using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwelveDaysOfChristmas.Data;
using TwelveDaysOfChristmas.Interfaces;

namespace TwelveDaysOfChristmas.Controllers
{
    public class verseGeneratorService : IVerseGenerator
    {
        public void generateVerse(int verseNumber)
        {
            
            //create a new data manager object
            var dataManager = new DataManager();
            // get the list of gifts the days
            var giftLists  = dataManager.GetGifts();
            var dayList  = dataManager.GetDays();
            
            for (int i = 1; i <= verseNumber; i++)
            {
                //Console.WriteLine($"{i}");
                // get the day at position i
                var day = dayList.Where(g => g.Value == i).FirstOrDefault();
                Console.WriteLine($"{day.Key} day output:\tOn the {day.Key} day of christmas");
                Console.WriteLine("                  \tMy true love gave to me");
                
                // assign the value of i to another
                var d = i;
                for (int j = d; j <= i && j > 0; j--)
                {
                    
                    // get the gift for the day
                    var gift = giftLists.FirstOrDefault(g => g.Value == j);
                    Console.WriteLine($"                      \t{gift.Key}");
                }
                Console.WriteLine();
            }

        }
        public void generateVerse(int verseNumber, string filePath)
        {            
            // Create a new data manager object
            var dataManager = new DataManager();
            // Get the list of gifts and the days
            var giftLists = dataManager.GetGifts();
            var dayList = dataManager.GetDays();

            string song = ""; // Create a string to store the entire song
            
            for (int i = 1; i <= verseNumber; i++)
            {
                var day = dayList.FirstOrDefault(g => g.Value == i);

                // Create the verse for the current day
                string verse = $"{day.Key} day output:\tOn the {day.Key} day of christmas\n                  \tMy true love gave to me \n ";

                // Initialize verse2 for this day
                string verse2 = "";

                // Assign the value of i to another variable
                var d = i;

                for (int j = d; j <= i && j > 0; j--)
                {
                    var gift = giftLists.FirstOrDefault(g => g.Value == j);
                    verse2 += $"                      \t{gift.Key}\n";
                }

                // Combine verse and verse2 for this day
                string combinedVerse = $"{verse}{verse2}\n";

                // Append the current day's verse to the entire song
                song += combinedVerse;
            }            
            // Save the entire song to the file
            dataManager.SaveFile(filePath, song);

            Console.WriteLine("Song has been saved to the file.");
            // Open the saved file with the default associated program
        Process.Start(filePath);
        }
    }
}
