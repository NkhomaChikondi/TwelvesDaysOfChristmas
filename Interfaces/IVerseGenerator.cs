using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwelveDaysOfChristmas.Interfaces
{
    public interface IVerseGenerator
    {
        void generateVerse(int verseNumber);
        void generateVerse(int verseNumber, string filePath);
    }
}
