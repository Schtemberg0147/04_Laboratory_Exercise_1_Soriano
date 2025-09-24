using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace _04_Laboratory_Exercise_1_Soriano
{
    internal class MyThreadClass //Step 2
    {
        public static void Thread1() 
        {
            for (int loopCount = 0; loopCount <= 5; loopCount++) //Step 3
            {
                Thread thread = Thread.CurrentThread;
                Console.WriteLine("Name of Thread: " + thread.Name + " = " + loopCount);
                if(loopCount == 5)
                {
                    Thread.Sleep(1500); //Terminates the thread in the fifth attempt
                }
            }
        }
    }
}
