CSharp Study Summary
=============

# 1강
운영체제와 닷넷 프레임 워크 
닷넷 프레임워크 구성 요소
=> 클래스 라이브러리와 CLR(Common Lauguage Runtime)
CRL => 프레임 워크안에 있는 모듈 => 작성한 코드를 우리가 사용하는 
OS에 맞게 변환함 => 컴파일된 C#코드를 실행하는 역할 
msdn.Miscrosoft.com => 모든 코드에 대한 설명이 있음

# 2강
C++기반 언어에 자바의 장점을 가져옴 
C#은 포인터를 거의 사용하지 않음 => 안전하지 않음 코드라고 명시
메모리 관리자 delete or free => 메모리 누수 발생
=> C#에서는 가비지 컬렉터에서 관리해서 자동으로 해지해줌 
=> 그냥 new로 생성만 하면 됨 => 해제 할 필요 없음!!
C# 프로그램 실행과정은 MSDN을 참고하자
## 실행 과정 
C# 언어 -> 컴파일 -> MSIL ->  CRL -> 실행
(우리가 생각할 부분은 컴파일까지만!)

# 3강 

# 4강 
## 표준 입출력
Console.Write(), Console.WriteLine(); => static으로 선언되어 있음 
Console.Write("{0} {1}", 3.14f, 2); =>  3.14 2 로 출력
C : 통화($, \ 등) 표시
D : 10진수 정수
E : 지수형태 출력
F : 부동 소수점 출력 
G : 기본 출력 
N :  콤바출력
P : %로 출력 
X : 16진수 
=> 그 밖에 것들 MSDN참고
ex) Console.WriteLine("{0:C} {1:P} {0:X}", 123, 123.45, 123); => \123, 12,345.00%, 7B 로 출력

# 5강 
C#의 데이터형 object에서 모두 파생됨 
데이터 형은 CTS에서 정의된 객체 
System.Single = float
byte 유효 범위 : 부호 없는 0 ~ 255
sbyte 유효 범위 : -128 ~ 127
short.MinValue, short.MaxValue => 데이터 형의 최소, 최댓값
C/C++ 문자열의 차이점 => 문자열 끝에 0, '/0'
'+' : 문자열 연결 
'==' : 문자열의 비교 
[인덱스] : 문자 
## 역슬래시 '\' 출력할 때 
1. 두번 쓴다 : "C:\\temp\\test.txt"
2. 앞에 @를 붙인다. : @"C:\temp\test.txt";

# 6강 
var : 대입되는 데이터에 따라 데이터형 결정 
## 사용할 수 없는 예
1. null 값 초기화, 매개변수 사용 x
2. var은 지역 변수로만 사용, 클래스 멤버로는 사용 x
3. 연속적으로 초기화 하는 경우 :  var m = 10, n = 20; x
## 소수점 이하 자리수 출력 
Console.WriteLine("{0} {1:f1} {2}", value1, value2, sum);
{1: f1} f1 : float형의 소수점 첫째 짜리까지만 출력 : 2.1
        f2 : 2.12
## nullable형 : null을 허용하지 않는 데이터형(기본 데이터형, int, float 등등 )이 null 값을 허용
형식
데이터? 변수병 : int? Var1; bool? Var2 = null; 
## 데이터 변환 
ToString()
기본 데이터형.Parse()
Convert.ToInt32()
Convert.ToSingle()
Convert.ToXXXXX()

# 7강 
## 박싱(boxing)
데이터형을 최상위 object 형으로 변환하여 힙에 저장(즉 참조 하는 형태가 x)
별도의 메모리를 사용 
int m = 123;
object obj = m;
## 언박싱 : 힙에 저장된 형식을 다시 원래의 형식으로 변환 
int n = (int)obj;
## 표준 입력 
Console.ReadKey()
사용자가 눌린 키 한 문자 정보를 리턴하는 메서드
## 함수 원형 
public static ConsoleKeyInfo ReadKey()
public static ConsoleKeyInfo ReadKey(bool ReadKey)
=> true : 화면 출력 안함, false : 화면 출력 
## ConsoleKeyInfo.Key
ConsoleKey 열거형 값 => MSDN 참고 
대소문자 구분 x => 해결 법 : ConsoleKeyInfo.KeyChar : 유니코드를 받음 
## Console.ReadLine() : 엔터키가 눌려질 때까지 입력 받은 문자열을 리턴하는 메서드 

# 8강 
## public struct 구조체명
{
// 멤버, 속성, 메서드 
}
## 제한 사항
- 구조체에 선언된 const, static 변수만 초기화 가능 
- 구조체 안에 선언할 수 있는 생성자는 매개변수가 반드시 있어야 함
public struct MyStruct
{
	public int Age;
	public MyStruct(int InAge)
	{
		Age = InAge;
	}
}
- 구조체를 같은 구조체에 대입하게 되면 값이 복사 (별도로 운영됨)
- 구조체는 값 형식이고 클래스는 참조 형식임 
- 구조체는 값 형식이므로 선언만으로도 사용 가능
- new를 사용했을 때만 -> 생성자가 호출 -> 기본값으로 초기화
- 구조체는 구조체 또는 클래스에 상속할 수 없음 (c++에서는 가능 )
- 구조체는 인터페이스를 상속하여 메서드를 구현할 수 있음 

## 열거형 : 상수를 문자열로 대치하여 선언, 상수에 의미 부여 
## 형식 
enum 열거형 명칭 { 문자열1, 문자열2 };
		{ 문자열1 = 상수, 문자열2 = 상수};
		{ 문자열1 = 상수, 문자열2 };

기본은 int형이지만 char 형을 제외한 형식 지정할 수 있음
enum Days : byte { Sun = 0, Mone, Tue, Wed, Thu };
## 열거형 변수가 아닌 변수에 열거형 값을 대입할 때에는 데이터형을 명시할 것 

# 9강 
값 형식 : 변수가 직접 값을 저장하는 형, 기본데이터형, 구조체, 열거형 
선언(반드시 초기화 해야됨) vs 생성(new, 자동으로 기본값으로 초기화)

참조 형식 : 한 객체를 참조형 변수가 사용할 때 참조형에 의해 내용이 바뀌면 객체에 영향을 줌
class, interface, delegate, 배열, string 
객체와 참조형 사이의 대입은 객체의 메모리 주소가 복사됨

# 10강 
## 연산자 
정수/부동 + "문자열" = "문자열"
string str = 1 + "test" + 3.14f + "abcd" => 문자열
## is 연산자(판단)
형식 호환을 조사하는 연산자 
형식 : '변수' is '클래스형 or 데이터형' = A is B => 결과는 true, false
박싱/언박싱 변환, 참조 변환에서 사용 
int nValue = 10;
if(nValue is float)
## as 연산자(변환)
역할 
형변환과 변환 조사 
캐스트 연산자의 역할과 불변환은 null 리턴 
참조, 박싱, 언박싱, null형에 사용 
형식 : 결과형 = 참조형, 언박싱, 박싱 as 변환형 
A test1 = new A();
object obj1 = test1;
B test2 = obj1 as B;
if(test2 == null) Console.WriteLine("형변환 실패");
else Console.WriteLine("형변환 성공");
## null 병합 연산자 : ??
null을 조사하는 연산자 : null이면 값을 넣고, 아니면 값을 유지
C = A ?? B; (A가 기준)
A가 null이 아니면 A를 C에 대입
A가 null이면 B를 C에 대입 
int? x = null;
int y = x ?? -1; // y는 -1

# 11강
## foreach
처음부터 끝까지 순차적인 값을 반복하여 읽는 역할 -> 읽기 전용 
int[] Array1 = { 1, 2 .... , 10 };
foreach(int nValue in Array1)
{
	Console.WriteLine(nValue);
} 
## 예외 처리 
try
{
	// 예외가 발생할 수 있는 코드 
}catch(예외처리 객체 e)
{
	//예외 처리 
}
try 문 안에서 초기화한 변수는 try 문 밖에서 사용할 수 없다. 
try ~ finally 
finally : 예외 발생과 상관없이 항상 실행되는 구문 
다중 예외 처리 : catch를 여러개 연달아 붙이면 됨
throw : 예외 상황을 임의로 발생시키는 역할

# 12강
## 1차원 배열 
기본 개념 : 같은 데이터형 + 변수명 + 순차적인 메모리 나열 
참조형 : new를 통해 생성 
Array로부터 파생된 참조형 
foreach 사용 가능 
선언 형식 : 데이터형[] 배열명; int[] array_name;
## 다차원 배열 
콤마로 구분 
선언형식 : int[,] array1 = new int[2, 2](2차원 배열) int[,,] array2 = new int[2, 3, 2](3차원 배열)
array1[0, 1] = 2;


# 13강
가변 배열 : 데이터명[][] 배열명; int[][] array_name;
ex) int[][] array = new int[3][];
     array[0] = new int[2];
     array[1] = new int[3];
     array[2] = new int[4];

배열 함수로 전달 
void func(int[] arr) { } (1차원 배열)
void func(int[, ] arr) { } (2차원 배열)

# 14강 
## 배열 초기화 메서드 
public static void Clear(Array array, int index, int length) index부터 length에 해당하는 
범위를 0으로 초기화 
##배열을 복사 
public object Clone(); int[] nCloneArray = (int[])nArray1.Clone();

# 15강
## 파일 입출력 
### 스트림(stream)
파일, 네트워크 등에서 데이터를 바이트 단위로 읽고 쓰는 클래스
Stream class는 상위 기본 클래스임 
using System.IO 선언 
### File Stream
파일 입출력을 다루는 기본 클래스 
byte[] 배열로 데이터를 읽거나 저장함 => 형변환이 요구됨 
파일 정보 설정에 사용 
public FileStream( string path, FileMode mode, FileAccess access)
텍스트 파일의 특징 : 기본단위 = 1바이트, 아스키 코드 기반, 아스키코드를 유니코드로 인코딩 
static void Main(string[] args)
{
	FileStream fs = new FileStream("text.txt", FileMode.Create);
	StreamWriter sw = new StreamWriter(fs);
	sw.Close();
}
or
using(Stream Writer sw = new StreamWriter(new FileStream("text.txt", FileMode.Create))
{
	//파일 입출력 처리  
} // 자동으로 Close 해줌, 세련되보이니까 자주 쓰자 
쓰기 메서드 Write, WriteLine을 통해 씀 sw.Write(value);
읽기 메서드 Read(), ReadLine(), string ReadLine()

#16강 
## string 데이터 분리 
public string[] Split( Params char[] separator )
string.Split(new char[] { ' ' }); 
using (BinaryReader br = new BinaryReader(File.Open("test.dat, FileMode.Open))
{
	var1 = br.ReadInt32();
	var2 = br.ReadSingle();
	str1 = br.ReadString();
}





 






