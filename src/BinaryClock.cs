using System;

namespace Assignments
{
    public class BinaryClock
    {
        static readonly string timeLength = "434342";
        static int lengthIndex = 0;
        static string reversedString = "";
        public static string[] CreateBinaryClock(string source)
        {
            string[] binaryStrings = new string[6];
            char[ , ] clockMatrix = new char[6 , 4];

            for(int index = source.Length - 1; index >= 0; index--)
                binaryStrings[index] = ConvertToBinary(source[index] - '0');
            
            for (int row = 0; row < 6; row++)
            {
                string toBePush = binaryStrings[row];
                for(int col = 0; col < 4; col++)
                {
                    clockMatrix[row, col] = toBePush[col];
                }
            }

            string[] resultantArray = new string[4];
            int arrayIndex = 0;
            for (int col = 3; col >= 0; col--)
            {
                string binaryString = "";
                for (int row = 0; row < 6; row++)
                {
                    binaryString += clockMatrix[row, col];
                }
                resultantArray[arrayIndex++] = binaryString.Replace('*', ' ') + ",";
            }

            return resultantArray;
        }
        private static string ConvertToBinary(int input)
        {
            int remainder;
            int length = (int)(timeLength[lengthIndex] - '0');
            string outputString;
            string result = string.Empty;

            while (input > 0)
            {
                remainder = input % 2;
                input /= 2;
                result = remainder.ToString() + result;
            }

            if (result.Length != length)
                outputString = result.PadLeft(length, '0');

            else
                outputString = result;

            reversedString = "";
            outputString = Reverse(outputString);
            lengthIndex++;

            if (outputString.Length != 4)
                outputString = outputString.PadRight(4, '*');
            return outputString;
        }

        private static string Reverse(string input)
        {
            for (int i = input.Length - 1; i >= 0; i--)
                reversedString += input[i];
            return reversedString;
        }
    }
}
