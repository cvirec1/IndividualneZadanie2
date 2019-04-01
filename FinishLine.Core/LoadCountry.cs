using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using KBCsv;

namespace FinishLine.Core
{
    public static class LoadCountry
    {
        
        public static List<Country> LoadCoutries(string path)
        {
            List<Country> ret = new List<Country>(250);
            StreamReader reader = new StreamReader(path);
            using (CsvReader cswReader = new CsvReader(reader))
            {
                cswReader.ValueSeparator = ';';
                var headerRow = cswReader.ReadHeaderRecord();
                while (cswReader.HasMoreRecords)
                {
                    var dataRecord = cswReader.ReadDataRecord();
                    ret.Add(new Country(dataRecord["CountryCode"], dataRecord["SlovakShortName"], dataRecord["EnglishShortName"], dataRecord["OfficialShortName"]));                
                }
            }
            return ret;
        }
    }
}
