﻿namespace NumberWordAPI
{
    public class InputParser
    {
        public static string[] ParseInput(string s)
        {
            var result = s.Split('_');
            return result;
        }

        public static string ConvertCharToString(char c)
        {
            switch (c)
            {
                case '0': return "zero";
                case '1': return "one";
                case '2': return "two";
                case '3': return "three";
                case '4': return "four";
                case '5': return "five";
                case '6': return "six";
                case '7': return "seven";
                case '8': return "eight";
                case '9': return "nine";
            }

            return "";
        }

        public static string ConvertNumberToString(string numberString)
        {
            var result = "";
            for (var i = 0; i < numberString.Length; i++)
            {
                result += ConvertCharToString(numberString[i]);
            }

            return result;
        }
    }
}
