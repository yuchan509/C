using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConverType
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
              부동 소수점과 정수형 사이의 형변환.
             */
            // 반올림 등 없이 정수 타입으로 가져와야 하므로 소수점 다 버리고 가져옴.
            // float f = 0.123431f;
            // int aa = (int)f;
            // Console.WriteLine(aa);

            /*
              문자열과 숫자 사이의 형변환.
             */
            // 에러 발생.
            // 반대 상황도 되지 않음.
            // string str1 = "12222";
            // int aa = (int)str1; 

            // ToString() : 숫자를 문자열로 바꿔주는 메소드.
            int aa = 343243;
            string bb = aa.ToString();
            Console.WriteLine(bb);
            
            float ff = 12312.1231f;
            string cc = ff.ToString();
            Console.WriteLine(cc);

            // 문자열을 숫자로 바꿔주는 메소드
            string str1 = "221312565";
            int aaa = int.Parse(str1);
            Console.WriteLine(aaa);

            // 보통 소수는 7자리까지만 표시. 나머지는 반올림 처리.
            string str2 = "1215.454687";
            float h = float.Parse(str2);
            Console.WriteLine(h);

            Console.ReadKey();
        }
    }
}
