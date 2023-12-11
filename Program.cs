// See https://aka.ms/new-console-template for more information
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace InterviewQuest
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            CheckCycle();
          
        }
            public static bool CheckCycle()
            {
                int[] nums = { 2, 1, -1, -2 };
                int n = nums.Length;
                for (int i = 0; i < n; i++)
                {
                    if (nums[i] == 0) continue;
                    int back = i, forward = i;
                    int direction = nums[i];
                    do
                    {
                        back = (back + nums[back] + n) % n;
                        forward = (forward + nums[forward] + n) % n;
                        forward = (forward + nums[forward] + n) % n;
                    }
                    while (nums[back] * direction > 0 && nums[forward] * direction > 0 && back != forward);
                    if (back == forward)
                    {
                       Console.WriteLine("its a Cycle");
                        return true;

                    }
                }
            Console.WriteLine("this is not a ciircular array");
                return false;
            }


        

    }
}

