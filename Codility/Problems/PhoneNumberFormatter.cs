using System;
using System.Collections.Generic;
using System.Linq;

namespace Codility.Problems
{
    class PhoneNUmberFormatter
    {
        public class PhoneNumberFormatter
        {
            public string Solution(string phoneNumber)
            {
                phoneNumber = RemoveNonDigits(phoneNumber);
                return FormatPhoneNumber(phoneNumber, CheckNumberSize(phoneNumber));
            }

            private Boolean CheckNumberSize(String phoneNumber)
            {
                return phoneNumber.Length % 3 == 1;
            }

            private string RemoveNonDigits(String s)
            {
                return s.Replace("[^0-9]", "");
            }

            private string FormatPhoneNumber(string s, bool lastGroup)
            {
                IEnumerable<char> tempNumber = "";
                int dashCounter = 0;
                for (int i = 0; i < s.Length; i++)
                {
                    if (dashCounter < 3)
                    {
                        tempNumber = tempNumber.Concat(s.Substring(i, i + 1));
                        dashCounter++;
                    }
                    else if (dashCounter == 3)
                    {
                        tempNumber = tempNumber.Concat("-");
                        tempNumber = tempNumber.Concat(s.Substring(i, i + 1));
                        dashCounter = 1;
                    }
                }
                if (lastGroup)
                {
                    char[] temp = tempNumber.ToArray();
                    temp[temp.Length - 2] = temp[temp.Length - 3];
                    temp[temp.Length - 3] = '-';
                    tempNumber = new String(temp);
                }

                return string.Join("", tempNumber);
            }
        }
    }
}
