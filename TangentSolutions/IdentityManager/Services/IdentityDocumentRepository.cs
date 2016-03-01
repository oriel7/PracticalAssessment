using System;
using System.Linq;

namespace IdentityManager.Services
{
    public class IdentityDocumentRepository
    {
        /// <summary>
        /// Generates random RSA ID
        /// </summary>
        /// <returns></returns>
        public string GetRandomRsaId()
        {
            const int maxYear = 100;
            const int maxMonth = 13;
            const int maxDay = 32;
            const int maxGender = 100;
            const int maxIsSouthAfrican = 2;
            const int minSecondLastNumber = 8;
            const int maxSecondLastNumber = 10;

            var rand = new Random(Guid.NewGuid().GetHashCode());

            var birthDate = FormatDate(rand.Next(0, maxYear), rand.Next(1, maxMonth), rand.Next(1, maxDay));

            var gender = FormatDigit(rand.Next(0, maxGender));

            var isSouthAfrican = rand.Next(0, maxIsSouthAfrican);

            var secondLastNumber = rand.Next(minSecondLastNumber, maxSecondLastNumber);

            var result = birthDate + gender + isSouthAfrican + secondLastNumber;

            result = GenerateCheckDigit(result);

            return result;
        }

        private static string GenerateCheckDigit(string result)
        {
            const int maxLength = 12;

            if (result.Length != maxLength)
                return result;

            try
            {
                var oddSum = 0;

                for (var i = 0; i < 6; i++)
                {
                    oddSum += int.Parse(result[2*i].ToString());
                }

                var evenProduct = 0;
                for (var i = 0; i < 6; i++)
                {
                    evenProduct = evenProduct*10 + int.Parse(result[2*i + 1].ToString());
                }

                evenProduct *= 2;
                var sEvenProduct = evenProduct.ToString();
                var evenSum = sEvenProduct.Sum(t => Convert.ToInt32(t));

                var sum = oddSum + evenSum;
                var checkDigit = 10 - (sum%10);

                if (checkDigit == 10) checkDigit = 0;

                result += checkDigit;
            }
            catch
            {
                // ignored
            }

            return result;
        }

        /// <summary>
        /// Appends zeroes
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        private static string FormatDigit(int value)
        {
            return value.ToString().PadLeft(4, '0');
        }

        /// <summary>
        /// Valid format for date YYMMDD
        /// </summary>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <param name="day"></param>
        /// <returns></returns>
        private static string FormatDate(int year, int month, int day)
        {
            if (month == 2 && day > 28)
                day = 28;

            return (year < 10
                ? "0" + year
                : year.ToString())
                   + (month < 10
                       ? "0" + month
                       : month.ToString())
                   + (day < 10
                       ? "0" + day
                       : day.ToString());
        }
    }
}