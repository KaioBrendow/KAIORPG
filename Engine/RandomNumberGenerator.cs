using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public static class RandomNumberGenerator
    {
        /* versao antiga com biblioteca velha
        private static readonly RSACryptoServiceProvider _generator = new RNGCryptoServiceProvider();

        public static int NumberBetween(int minimumvalue, int maximumvalue)
        {
            byte[] randomNumber = new byte[1];

            _generator.GetBytes(randomNumber);

            double asciiValueOfRandomCharacter = Convert.ToDouble(randomNumber[0]);

            // We are using Math.Max, and substracting 0.00000000001,
            // to ensure "multiplier" will always be between 0.0 and .99999999999
            // Otherwise, it's possible for it to be "1", which causes problems in our rounding.
            double multiplier = Math.Max(0, (asciiValueOfRandomCharacter / 255d) - 0.00000000001d);


            int range = maximumvalue - minimumvalue + 1;

            // We need to add one to the range, to allow for the rounding done with Math.Floor
            double randomValueInRande = Math.Floor(multiplier * range);
        }*/
        // Simple version, with less randomness.
        //
        // If you want to use this version, 
        // you can delete (or comment out) the NumberBetween function above,
        // and rename this from SimpleNumberBetween to NumberBetween
        private static readonly Random _simpleGenerator = new Random();
        public static int NumberBetween(int minimumValue, int maximumValue)
        {
            return _simpleGenerator.Next(minimumValue, maximumValue + 1);
        }
    }
}
