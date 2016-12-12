using System;

namespace WorkItemTrackingSample
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;

            for(int i=0;i<16;i++)
            {
                sum += i;  

            }
            Console.WriteLine("try to sum:" + sum);
        }
    }
}
