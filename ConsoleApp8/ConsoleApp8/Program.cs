using System;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            MultiplicationTable(16);
        }

        static string ConvertDecimalToHex(uint decimalNumber)
        {
            // The highest possible hex value in decimal will be bound to int32 at 4 bytes
            // decimal:4294967295
            // hexadecimal: FFFFFFFF
            // from 16^7 to 16^0
            // use recursion for each digit

            // string to hold the new representation of the number
            string hexNumber = "";

            // 8th hex digit
            // decimal: 268435456 - 4294967295
            // hexadecimal: 10000000 - FFFFFFFF
            if (decimalNumber <= 4294967295 && decimalNumber >= 268435456)
            {
                //integer divide for the hex digit
                uint digitValue = decimalNumber / (uint)Math.Pow(16, 7);
                hexNumber += GetHexValue(digitValue);
                //modulus for the remainder
                uint remainder = decimalNumber % (uint)Math.Pow(16, 7);
                hexNumber += ConvertDecimalToHex(remainder);
            }
            else if(decimalNumber < 268435456 && decimalNumber >= 16777216)
            {
                //integer divide for the hex digit
                uint digitValue = decimalNumber / (uint)Math.Pow(16, 6);
                hexNumber += GetHexValue(digitValue);
                //modulus for the remainder
                uint remainder = decimalNumber % (uint)Math.Pow(16, 6);
                hexNumber += ConvertDecimalToHex(remainder);
            }
            else if (decimalNumber < 16777216 && decimalNumber >= 1048576)
            {
                //integer divide for the hex digit
                uint digitValue = decimalNumber / (uint)Math.Pow(16, 5);
                hexNumber += GetHexValue(digitValue);
                //modulus for the remainder
                uint remainder = decimalNumber % (uint)Math.Pow(16, 5);
                hexNumber += ConvertDecimalToHex(remainder);
            }
            else if (decimalNumber < 1048576 && decimalNumber >= 65536)
            {
                //integer divide for the hex digit
                uint digitValue = decimalNumber / (uint)Math.Pow(16, 4);
                hexNumber += GetHexValue(digitValue);
                //modulus for the remainder
                uint remainder = decimalNumber % (uint)Math.Pow(16, 4);
                hexNumber += ConvertDecimalToHex(remainder);
            }
            else if (decimalNumber < 65536 && decimalNumber >= 4096)
            {
                //integer divide for the hex digit
                uint digitValue = decimalNumber / (uint)Math.Pow(16, 3);
                hexNumber += GetHexValue(digitValue);
                //modulus for the remainder
                uint remainder = decimalNumber % (uint)Math.Pow(16, 3);
                hexNumber += ConvertDecimalToHex(remainder);
            }
            else if (decimalNumber < 4096 && decimalNumber >= 256)
            {
                //integer divide for the hex digit
                uint digitValue = decimalNumber / (uint)Math.Pow(16, 2);
                hexNumber += GetHexValue(digitValue);
                //modulus for the remainder
                uint remainder = decimalNumber % (uint)Math.Pow(16, 2);
                hexNumber += ConvertDecimalToHex(remainder);
            }
            else if (decimalNumber < 256 && decimalNumber >= 16)
            {
                //integer divide for the hex digit
                uint digitValue = decimalNumber / (uint)Math.Pow(16, 1);
                hexNumber += GetHexValue(digitValue);
                //modulus for the remainder
                uint remainder = decimalNumber % (uint)Math.Pow(16, 1);
                hexNumber += ConvertDecimalToHex(remainder);
            }
            else
            {
                //Final digit
                hexNumber += GetHexValue(decimalNumber);
            }
            return hexNumber;
        }

        static char GetHexValue(uint number)
        {
            char hexValue = '?';
            switch (number)
            {
                case 0:
                    hexValue = '0';
                    break;
                case 1:
                    hexValue = '1';
                    break;
                case 2:
                    hexValue = '2';
                    break;
                case 3:
                    hexValue = '3';
                    break;
                case 4:
                    hexValue = '4';
                    break;
                case 5:
                    hexValue = '5';
                    break;
                case 6:
                    hexValue = '6';
                    break;
                case 7:
                    hexValue = '7';
                    break;
                case 8:
                    hexValue = '8';
                    break;
                case 9:
                    hexValue = '9';
                    break;
                case 10:
                    hexValue = 'A';
                    break;
                case 11:
                    hexValue = 'B';
                    break;
                case 12:
                    hexValue = 'C';
                    break;
                case 13:
                    hexValue = 'D';
                    break;
                case 14:
                    hexValue = 'E';
                    break;
                case 15:
                    hexValue = 'F';
                    break;
                default:
                    hexValue = '?';
                    break;
            }
            return hexValue;
        }

        static void MultiplicationTable(int numberOfTerms)
        {
            //Create the top of the table
            Console.Write($"| {"0", 3} ");
            for (uint selections = 1; selections < numberOfTerms; selections++) 
            {
                Console.Write($"| {selections, 3} ");
            }
            Console.WriteLine($"|");

            for (uint YMultiplier = 1; YMultiplier < numberOfTerms; YMultiplier++)
            {
                Console.Write($"| {YMultiplier, 3} ");
                for (uint XMultiplier = 1; XMultiplier < numberOfTerms; XMultiplier++)
                {
                    Console.Write($"| {ConvertDecimalToHex(YMultiplier * XMultiplier), 3} ");
                }
                Console.WriteLine($"|");
            }
        }
    }

    
}
