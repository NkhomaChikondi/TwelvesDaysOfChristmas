using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwelveDaysOfChristmas.Interfaces;

namespace TwelvesDaysOfChristmas.Services
{
    public class DataManagerService : IDataManager
    {

        public Dictionary<string, int> GetDays()
        {
            var days = new Dictionary<string, int>();
            days["First"] = 1;
            days["Second"] = 2;
            days["Third"] = 3;
            days["Fourth"] = 4;
            days["Fifth"] = 5;
            days["Sixth"] = 6;
            days["Seventh"] = 7;
            days["Eighth"] = 8;
            days["Nineth"] = 9;
            days["Tenth"] = 10;
            days["Eleventh"] = 11;
            days["Twelfth"] = 12;
            return days;
        }

        public Dictionary<string, int> GetGifts()
        {
            var list = new Dictionary<string, int>();
            list["A partridge in a pear tree,"] = 1;
            list["Two turtle doves,"] = 2;
            list["Three french hens,"] = 3;
            list["Four calling birds,"] = 4;
            list["Five golden rings,"] = 5;
            list["Six geese a-laying,"] = 6;
            list["Seven swans a-swimming,"] = 7;
            list["Eight maids a-milking,"] = 8;
            list["Nine ladies dancing,"] = 9;
            list["Ten lords a-leaping,"] = 10;
            list["Eleven pipers piping,"] = 11;
            list["Twelve drummers drumming,"] = 12;

            return list;
        }

        public void SaveFile(string fileName, string songContent)
        {
            try
            {
                // Write the content to a text file
                File.WriteAllText(fileName, songContent);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
