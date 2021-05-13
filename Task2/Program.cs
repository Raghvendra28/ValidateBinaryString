using System;
using System.Linq;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter binary string");

            string binaryString = Console.ReadLine();

            var result = CheckBinaryString(binaryString);
            if (result)
            {
                Console.WriteLine(binaryString + " is a good binary string");
            }
            else
            {
                Console.WriteLine(binaryString + " is not a good binary string");
            }
        }


        public static bool CheckBinaryString(string str)
        {
            var case1 = ValidateCount(str, Condition.Equal);
            if (case1)
            {
                var prefix = str.Remove(str.Length - 1);
                var case2 = ValidateCount(prefix, Condition.GreaterThan);
                if (case2)
                {
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Validate string for both the condition 
        /// </summary>
        /// <param name="str"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        private static bool ValidateCount(string str, Condition condition)
        {
            char one = '1';
            char zero = '0';
            var conut1 = str.Count(c => (c == one));
            var conut2 = str.Count(c => (c == zero));
            switch (condition)
            {
                case Condition.Equal:
                    if (conut1 != conut2)
                    {
                        return false;
                    }
                    break;
                case Condition.GreaterThan:
                    if (conut1 <= conut2)
                    {
                        return false;
                    }
                    break;
            }

            return true;
        }
    }
}
