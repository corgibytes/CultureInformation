using System;
using System.Globalization;

namespace Corgibytes.CultureInformation
{
    class CultureInformation
    {
        static void Main(string[] args)
        {
            CultureInfo[] cinfo = CultureInfo.GetCultures(CultureTypes.AllCultures);
            foreach (CultureInfo cul in cinfo)
            {
                CultureInfo.CurrentCulture = cul;
                string culNowString = DateTime.Now.ToString("yyyy/MM/dd");
                Console.WriteLine("Code: {0}, EnglishName: {1}, Native Name: {2}", 
                    CultureInfo.CurrentCulture.Name, CultureInfo.CurrentCulture.EnglishName, CultureInfo.CurrentCulture.NativeName);
                Console.WriteLine("Current Date in yyyy/MM/dd format: {0}\n", culNowString);
            }
        }
    }
}