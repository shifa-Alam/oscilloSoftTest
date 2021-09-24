using System;

namespace solutionForProblem3
{
    class Program
    {
        static void Main(string[] args)
        {
            var num1 = Console.ReadLine();
            var num2 = Console.ReadLine();

            num1 = reverseString(num1);
            num2 = reverseString(num2);
            var result = Add(num1, num2);

            result = reverseString(result);
            var firstItem = result[0].ToString();
            if (string.Equals(firstItem, "0"))
            {
                result = result.Remove(0, 1);
            }
            Console.WriteLine(result);

        }
        public static string reverseString(string s)
        {
            var finalString = string.Empty;

            for (int i = s.Length - 1; i >= 0; i--)
            {
                finalString = finalString + string.Concat(s[i]);
            }
            return finalString;
        }


        private static string Add(string a, string b)
        {
            //var valid = ApplyValidation(int.Parse(a), int.Parse(b));
            //if (!valid) return "Invalid Argument";

            var extraVal = 0;
            var val = string.Empty;
            for (var i = a.Length - 1; i >= 0; i--)
            {
                var firstNumber = int.Parse(a[i].ToString());
                var secondNumber = int.Parse(b[i].ToString()) + extraVal;

                if (firstNumber + secondNumber >= 10)
                {
                    var rowVal = (firstNumber + secondNumber).ToString();
                    val = rowVal[1].ToString() + val;
                    extraVal = int.Parse(rowVal[0].ToString());
                }
                else
                {
                    val = (firstNumber + secondNumber).ToString() + val;
                    extraVal = 0;
                }
            }
            if (extraVal > 0)
            {
                return extraVal.ToString() + val;
            }
            return val;
        }

        //private static bool ApplyValidation(int num1, int vnum2)
        //{
        //    if (num1 < 0 && vnum2 < 0) return false;
        //    return true;
        //}
    }
}
