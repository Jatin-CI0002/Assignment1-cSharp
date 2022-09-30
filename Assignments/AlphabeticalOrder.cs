using System;

namespace Assignments
{
    public class AlphabeticalOrder
    {
        public static string SortAlphabets(string inputString)
        {
            inputString = inputString.ToLower();

            string outputString = "";
            
            string[] strings = inputString.Split(" ");
            int[] stringLengths = new int[strings.Length];
            int[] frequencyArray = new int[26];
            inputString =  inputString.Replace(" ", String.Empty);

            for (int index = 0; index < strings.Length; index++)
                stringLengths[index] = strings[index].Length;

            for (int index = 0; index < inputString.Length; index++)
            {
                char character = inputString[index];
                frequencyArray[character - 'a']++;
            }

            int asciiValue = 97;
            int requiredLength = 0;
            int lengthIndex = 0;
            for (int index = 0; index < frequencyArray.Length;)
            {

                if (lengthIndex < stringLengths.Length && requiredLength == stringLengths[lengthIndex])
                {
                    outputString += " ";
                    lengthIndex++;
                    requiredLength = 0;
                }

                if (frequencyArray[index] > 0)
                {
                    outputString += Convert.ToChar(asciiValue);
                    frequencyArray[index]--;
                    requiredLength++;
                }

                else
                {
                    index++;
                    asciiValue += 1;
                }
            }

            return outputString;
        }


    }
}
