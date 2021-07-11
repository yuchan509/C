using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constant
{
    class Program
    {   
        // 지정되지 않은 값, 마지막으로 지정된 값을 기준으로 1씩 증가.
        // 그러나 직접 값을 지정하지 않는 것을 권장.
        enum City { Seoul = 02, busan = 032, incheon, Daegu }
        static void Main(string[] args)
        {
            // 변수 : 담고 있는 데이터를 얼마든지 변경 가능한 메모리 공간.
            // 상수 : 담고 있는 데이터를 절대 바꿀 수 없는 메모리 공간.
            // 상수는 const라고 하는 키워드를 사용.
            // 선언 형식 ---> const type명 상수명;

            // 상수는 값 변경 불가능.
            // const int A = 100;
            // Console.WriteLine(A);

            // enum은 열거형 상수(constant)를 표현하기 위한 것.
            // 선언 형식 : enum 열거형식명 : 자료형 {상수1, 상수2, 상수3....}
            // 위에서 자료형은 정수형 자료형(byte, sbyte, short, long, char, int, unit)만 사용됨.
            // 일반적으로 자료형을 표시하지 않음 ---> 생략시 int형으로 설정.

            // 열거형식 안에 선언된 상수값이 할당 되지 않을 경우 자동으로 0, 1, 2 ....으로 설정.
            // enum City {Seoul, busan, incheon, Daegu}

            // (int) 처리를 해야 원하는 숫자 값으로 표시됨.
            Console.WriteLine((int)City.Seoul);
            Console.WriteLine((int)City.busan);
            Console.WriteLine((int)City.incheon);
            Console.WriteLine((int)City.Daegu);

            City sel = City.Seoul;

            // 참이며 True, 거짓이면 False로 반환.
            Console.WriteLine(sel == City.Seoul);
            Console.WriteLine(sel == City.Daegu);



        }
    }
}
