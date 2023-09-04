using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TwelveDaysOfChristmas.Interfaces
{
    internal interface IDataManager
    {
        Dictionary<string, int> GetDays();
        Dictionary<string,int> GetGifts();
        void SaveFile(string fileName, string songContent);
    }
}
