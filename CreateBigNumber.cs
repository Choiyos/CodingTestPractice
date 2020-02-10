using System;
using System.Configuration;
using Xunit;

namespace CodingTestPractice
{
    public class CreateBigNumber
    {
        public static void main()
        {
            Solution("7799", 2);
        }

        public static string Solution(string str, int k)
        {
            string solution = str;
            int count = k;
            int index = 0;
            
            while (k != 0)
            {
                var temp = k;
                for (int i = index+1; i <= k+index; i++)
                {
                    if (solution[index] < solution[i])
                    {
                        solution = String.Concat(
                            solution.Substring(0, index),
                            solution.Substring(index + 1, solution.Length - index-1)
                            );
                        k--;
                        break;
                    }
                }

                if (temp == k) index++;
            }
            return solution;
        }
    }

    public class TestClass
    {
        [Fact]
        private void Test()
        {
            // act && assert
            Assert.Equal("99",CreateBigNumber.Solution("7799", 2));
            Assert.Equal("94",CreateBigNumber.Solution("1924", 2));
            Assert.Equal("3234",CreateBigNumber.Solution("1231234", 3));
            Assert.Equal("775841",CreateBigNumber.Solution("417725841", 4));
            
            
            Assert.Equal("999959",CreateBigNumber.Solution("059959959", 3));
            Assert.Equal("599999",CreateBigNumber.Solution("512399999", 3));
            Assert.Equal("5399999",CreateBigNumber.Solution("532199999", 2));
        }
    }
}