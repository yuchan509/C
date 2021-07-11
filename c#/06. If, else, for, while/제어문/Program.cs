using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ifelseEx
{
    class Program
    {
        static void Main(string[] args) 
        { 
            /* if문
             * 
             * if (조건식) 
             * {
             *   조건식이 참인 경우 실행할 코드.
             * }
             * 
             */

            int j = 100;
            if ((j % 2) == 1)
                Console.WriteLine("짝수");
            else
                Console.WriteLine("홀수");


        }
    }
}