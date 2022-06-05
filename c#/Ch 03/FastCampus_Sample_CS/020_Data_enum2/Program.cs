using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*---------------------------------------------------------------------------
 * Name : _019_Data_enum
 * DESC : enum데이터형 기초
--------------------------------------------------------------------------- */

namespace _020_Data_enum2
{
    enum CHAR_STATE
    {
        IDLE, // 0
        WALK, // 1
        RUN,  // 2
        DIE,  // 3
    }

    enum CLICK_STATE
    {
        NONE, // 0
        CLICK = 100, // 100
        DOUBLE_CLICK = 200, // 200
        UP, // 201
    }

    class Program
    {
        static void Main(string[] args)
        {
            CHAR_STATE charState = CHAR_STATE.IDLE;
            Console.WriteLine("캐릭터 상태 : {0} {1}", charState, (int)charState);
            // 콘솔에 "캐릭터 상태 : IDLE 0"라고 출력됨

            charState = CHAR_STATE.RUN;
            Console.WriteLine("캐릭터 상태 : {0} {1}", charState, (int)charState);
            // 콘솔에 "캐릭터 상태 : RUN 2"라고 출력됨

            charState = CHAR_STATE.DIE;
            Console.WriteLine("캐릭터 상태 : {0} {1}", charState, (int)charState);
            // 콘솔에 "캐릭터 상태 : DIE 3"라고 출력됨

            Console.WriteLine("CLICK_STATE : {0} {1}", CLICK_STATE.NONE, (int)CLICK_STATE.NONE); // 콘솔에 "CLICK_STATE: NONE 0"라고 출력됨
            Console.WriteLine("CLICK_STATE : {0} {1}", CLICK_STATE.CLICK, (int)CLICK_STATE.CLICK); // 콘솔에 "CLICK_STATE: CLICK 100"라고 출력됨
            Console.WriteLine("CLICK_STATE : {0} {1}", CLICK_STATE.DOUBLE_CLICK, (int)CLICK_STATE.DOUBLE_CLICK); // 콘솔에 "CLICK_STATE: DOUBLE_CLICK 200"라고 출력됨
            Console.WriteLine("CLICK_STATE : {0} {1}", CLICK_STATE.UP, (int)CLICK_STATE.UP); // 콘솔에 "CLICK_STATE: UP 201"라고 출력됨
        }
    }
}
