// 파란색으로 보이는 부분은 예약어(키워드)로 되어있다. 바꿀 수 없다.
// 흰색으로 보이는 부분은 함수, namespace의 이름이다.
// 초록색으로 보이는 부분은 클래스의 이름이다.
// 빨간색 밑줄이 쳐진 부분은 에러가 발생했다는 것이다.

// 솔루션이 여러 개 있을 때는 솔루션을 우클릭하여 시작 프로그램으로 설정하는 것이 좋다.
// 빌드 부분에서 솔루션 빌드 외에도 원하는 솔루션을 직접 선택하여 빌드시킬수 있다.

// using : 선언된 네임스페이스 내부 객체들에 접근.
using System; // 현재 namespace("_001_HelloWorld")안에 있는 "Console"을 사용하기 위해 사용했다.
using System.Collections.Generic; // 회색으로 보이는 부분은 실제 사용하지 않는 부분이다.
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*---------------------------------------------------------------------------
 * Name : _001_HelloWorld
 * DESC : 코드 리뷰
--------------------------------------------------------------------------- */

// namespace : 그룹화. 동일한 함수의 이름 사용 가능.
// 동일한 함수의 이름?
// 다른 솔루션 내의 "Program"이라는 같은 이름의 클래스가 있음에도, 충돌이 발생하지 않는다.
namespace _001_HelloWorld
{  // namespace가 숫자로 시작하는 경우 이름 앞에 '_'가 붙는다.

    // class : 필드(field), 메소드(method)로 분리. 프로그램을 구성하는 기본.
    // 필드(field) : 변수 같은 데이터들을 묶어놓는 것.
    // method : 함수를 나타냄.
    class Program
    {
        // static void Main : 가장 중요한 메소드. 최초의 진입점(Entry Point). 메인 메소드가 반드시 존재.
        // string[] args : parameter(매개변수)를 뜻한다.
        // Main : 함수의 이름을 뜻한다.
        // void : 반환 타입을 뜻한다.
        static void Main(string[] args)
        {
            Console.WriteLine("HelloWorld"); // 콘솔 창에 "HelloWorld"라고 나타난다.
                                             // "System"을 using 하지 않았을 경우
                                             // "Systme.Console.WriteLine("HelloWorld");" 로 대체할 수 있다.
        }
    }
}

// 세미콜론 ';' : 코드 문장의 끝을 나타냄.
// namespace, class, method 뒤에는 사용하지 않는다.

// 브레이스 '{}' : 코드 블록(블록 단위로 코드를 구분함).
// using, namespace, class, method처럼 사용된 부분의 왼쪽을 보면 '+', '-'부분을 통해 구분할 수 있다.

// 주석 : 컴파일되지 않는 부분. 
// 주석 종류 : 한 줄 주석("//"), 여러 줄 주석("/**/").
