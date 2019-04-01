using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinishLine.Core
{
    public class Country
    {
        public string CountryCode { get; private set; }
        public string SlovakShortName { get; private set; }
        public string EnglishShortName { get; private set; }
        public string OfficialShortName { get; private set; }

        public Country(string countryCode, string slovakShortName, string englishShortName, string officialShortName)
        {
            CountryCode = countryCode;
            SlovakShortName = slovakShortName;
            EnglishShortName = englishShortName;
            OfficialShortName = officialShortName;
        }

    }
}
