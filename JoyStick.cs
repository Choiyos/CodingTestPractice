using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTestPractice
{
    public class JoyStick
    {
        public static void main()
        {
            Console.WriteLine("AABAAAAAAABBB : " + Solution("AABAAAAAAABBB"));
            Console.WriteLine("AAAAAAAAAAAAAAAA : " + Solution("AAAAAAAAAAAAAAAA"));
            Console.WriteLine("AABBBBBA : " + Solution("AABBBBBA"));
            Console.WriteLine("ABBBAAAAABBBBBBB : " + Solution("ABBBAAAAABBBBBBB"));
            Console.WriteLine("AAAAAAABBAA : " + Solution("AAAAAAABBAA"));
            Console.WriteLine("ABBBBBAAAAAAAAAZ : " + Solution("ABBBBBAAAAAAAAAZ"));
            Console.WriteLine("ABBBBB : " + Solution("ABBBBB"));
            Console.WriteLine("BBBBBA : " + Solution("BBBBBA"));
            Console.WriteLine("JONNAAPPA : " + Solution("JONNAAPPA"));
            Console.WriteLine("JNNAAANAAAAEH : " + Solution("JNNAAANAAAAEH"));
        }

        public static int Solution(string name)
        {
            int answer = 0;
            string forDebug = String.Empty;
            int rightLength = 0, leftLength = 0, sum = 0, rightStart = 0, leftStart = 0;
            bool isFirstBlock = true, isDirty = false;

            Dictionary<char, int> dic = new Dictionary<char, int>();

            for (int i = 0; i < (('Z' - 'A') / 2) + 1; i++)
            {
                dic.Add((char) ('A' + i), i);
            }

            for (var i = -(('Z' - 'A') / 2); i <= 0; i++)
            {
                dic.Add((char) ('Z' + i), -(i - 1));
            }

            for (int i = 0; i < name.Length; i++)
            {
                char tempChar = name[i];
                sum += dic[tempChar];
                forDebug += $"{dic[tempChar]} ";
                if (i == 0) continue;
                if (!isDirty && rightStart == 0 && isFirstBlock && tempChar == 'A')
                {
                    rightLength++;
                    rightStart = i - 1;
                    isDirty = true;
                }
                else if (isFirstBlock && tempChar == 'A')
                {
                    rightLength++;
                }
                else if (rightLength != 0 && tempChar != 'A')
                {
                    isFirstBlock = false;
                }
            }

            isFirstBlock = true;
            isDirty = false;

            for (int i = name.Length - 1; i > 0; i--)
            {
                char tempChar = name[i];
                if (!isDirty && leftStart == 0&& isFirstBlock && tempChar == 'A')
                {
                    leftLength++;
                    leftStart = name.Length - (i + 1);
                    isDirty = true;
                }

                else if (isFirstBlock && tempChar == 'A')
                {
                    leftLength++;
                }
                else if (leftLength != 0 && tempChar != 'A')
                {
                    isFirstBlock = false;
                }
            }

            sum += rightStart - rightLength > leftStart - leftLength
                ? leftStart - leftLength
                : rightStart - rightLength;
            sum += name.Length - 1;

            answer = sum;

            return answer;
        }
    }
}