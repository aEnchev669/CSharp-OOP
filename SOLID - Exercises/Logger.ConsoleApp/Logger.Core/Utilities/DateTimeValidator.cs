using System;
using System.Globalization;

namespace Logger.Core.Utilities
{
    public static class DateTimeValidator
    {
        private static ICollection<string> allowedDateTimeFormats =
        new HashSet<string>
        {
            "MM/dd/yyyy HH:mm;ss tt",
            "MM/dd/yyyy HH:mm;ss"
        };
        public static bool IsDateTimeValid(string dateTime)
        {
            bool isFormatValid = false;
            foreach (string currFormat in allowedDateTimeFormats)
            {
                bool isCurrFormat = DateTime.TryParseExact(dateTime, currFormat, CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime result);

                if (isCurrFormat)
                {
                    isFormatValid = true;
                    break;
                }
            }
                return isFormatValid;
        }

        /// <summary>
        /// Using this method you can add custom DateTime formats. 
        /// Be careful to add only valid formats!
        /// </summary>
        /// <param name="newFormat"></param>
        public static void RegisterNewFormat(string newFormat)
        {
            allowedDateTimeFormats.Add(newFormat);
        }
    }
}
