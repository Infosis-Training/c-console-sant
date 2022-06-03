using System;
using System.Linq;

namespace DayTwoAssignments
{
    public class DayTwo
    {
        //Method (2022.06.02) ---------------->
        public int MaxNumber(int one, int two, int three)
        {

            int[] num = { one, two, three };

            return num.Max();
        }

        public string Floatings(float arg, float arg2, float arg3 = 1) => $"{arg * arg2 * arg3}";

        public string Initials(string firstName, string secondName) => $"{firstName[0]}{secondName[0]}";

        public void InitialsSplit(string name)
        {

            string[] splits = name.Split();

            foreach (string split in splits)
            {
                Console.Write(split[0]);
            }
        }

    }
}