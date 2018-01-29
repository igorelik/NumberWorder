using System.Collections.Generic;

namespace NumberWordAPI
{
    public class NumberConverter
    {
        private List<string> numbersAsString;

        public bool AddRowString(string numberString)
        {
            var numberStrings = InputParser.ParseInput(numberString);
            foreach (var number in numberStrings)
            {
                var convertedString = InputParser.ConvertNumberToString(number);
                numbersAsString.Add(convertedString);
            }

            return true;
        }

        public override string ToString()
        {
            var result = "Converted numbers are:\r\n";
            foreach (var number in numbersAsString)
            {
                result += number + "\r\n";
            }

            return result;
        }
    }
}
