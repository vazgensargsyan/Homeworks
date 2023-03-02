using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Registration
{
    internal class Human
    {
        enum Errors
        {
            IncorrectNameOrSurname,
            IncorrectSurname
        }
        public bool Validation(string myString)
        {
            for (int i = 0; i < myString.Length; i++)
            {
                if (!(myString[i] >= 'a' && myString[i] <= 'z') && !(myString[i] >= 'A' && myString[i] <= 'Z'))
                {
                    return false;
                }
            }
            return true;
        }
        public byte CheckCount(char myChar, string myString)
        {
            byte count = 0;
            for (int i = 0; i < myString.Length; i++)
            {
                if (myString[i] == myChar)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
