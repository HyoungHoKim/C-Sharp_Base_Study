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

# 17강
## serialize(직렬화)
기본데이터형 뿐만 아니라 구조체나 클래스도 읽고 쓸수 있음 
using System.Runtime.Serialization.Formatters.Binary;
직렬화 대상 설정 
[Serializable]
struct A or Class A
{

}

public void Serialize(Stream serializationStream, object graph) //쓰기
public object Deserialize(Stream serializationStream)//읽기

using(FileStream fs1 = new FileStream("test.dat", FileMode.Create))
{
	BinaryFormatter bf = new BinaryFormatter();
	bf.Serialize(fs1, Data); // 컬렉션도 사용 방법은 같다. Data 대신 DataList
}

using(FileStream fs2 = new FileStream("test.dat", FileMode.Open))
{
	BinaryFormatter bf2 = new BinaryFormatter();
	ResultList = (List<data>)bf2.Deserialize(fs2);
}


## 역직렬화
직렬화 대상에서 제외
[Serializable]
class TestClass
{
	int nValue;
	[NonSerialize] // 밑으로 모두 역직렬화
	string strMessage;
	// 또는 [NonSerialize] string strMessage;
}
제네릭 = 템플릿

# 18~20강 프로젝트 
필수 클래스와 메서드 
1. 화면 출력 클래스 : Console
   화면 출력 메서드 : Console.Beep(), Console.Clear(), Console.SetCursorPosition,
		Console.SetWindowSize(), Thread.Sleep();
   콘솔 색상 관련 속성 : Console.BackgroundColor, Console.ForgroundColor

# 21강 
## 클래스 
변수와 메서드를 그룹화한 것 
### 주요개념 
- 그룹화를 위해 class 키워드와 형식 사용
- new 연산자로 생성하여 사용
- new를 사용하지 않으면 같은 클래스를 참조할 수 있는 변수가 됨 (클래스 참조 변수)
- 클래스를 new를 통해 생성하면 객체가 됨 
- 인스턴스와 객체의 관계 :  인스턴스는 본질, 객체는 실물인 현상 A test1 (object) = new A(); (instatnce)
   "같은 A 인스턴스를 가지는 test1과 test2 객체"
### 형식 
- 클래스 형식과 구조체 형식은 유사 
struct struct_name    class class_name
{                           {

}                           }
xxx.멤버 변수, xxx.멤버 메서드 

구조체 선언은 값형, 클래스 선언은 참조형 

형식
class Date 
{
	int Year, Month, Day;
	void Print()
	{
		Console.WriteLine("{0} {1} {2}", Year, Month, Day);
	}
}

### 접근 한정자 
- 없으면 자동적으로 private 
- 클래스 멤버에 대한 접근 권한 설정
- 접근 한정자 : private, protected, public, internal(C#에서 추가된 개념), protected internal
- 클래스 자체에 적용하는 접근 한정자 
  public -> 명시적
  internal -> 암시적 
#### public 
- 클래스 내외부에서 모두 접근 가능 
- 상속관계에서도 위와 동일하게 접근 가능 
#### private 
- 클래스 또는 구조체 안에서만 멤버에 접근
- 클래스 외부에서는 사용 안됨 
#### protected
- 클래스 안에서는 private와 같은 역할 
- 하위 클래스 안에서는 상위 protected 멤버 접근 가능
#### internal 
- 같은 어셈블리(exe, dll, 같은 프로젝트) 안에 있을 때만 내외부에서 멤버에 접근 가능
- 클래서 서두에 접근 한정자 생략은 internal 생략한 것 
#### protected internal 
- 같은 어셈블리 안에서는 internal과 동일 
- 서로 다른 어셈블리 안에서 상속관계일 때 하위 클래스는 상위 클래스의 protected internal 멤버에 
접근할 수 있음, 외부에서 접근할 수 없음  
 
# 22강 
## 객체 생성 
- new로 생성 
- 객체 해제는 가비지 컬렉터에게 

## 생성자 Constructor
- 객체를 생성할 대 자동으로 호출되는 메서드 
- new
- 기본 생성자 : 클래스명과 같은 이름, 리턴형이 없음, 접근 한정자는 public 
- 생성자 : 매개변수가 있음, 리턴형은 없음, 접근 한정자는 public 
## 소멸자 Destructor
- 객체가 소멸될 때 호출되는 메서드 
- 가비지 컬렉터 
- 클래스명과 같음
- 리턴형 없음 
- 접근 한정자 없음 
- ~로 시작함 
~MyClass()
{

}

## 정적 멤버
### 언어에 따른 static 역할 비교
- C :  변수 값 유지 
- C++ : 객체 안에서 변수 공유 
- C# : 객체를 생성하지 않고 멤버 사용, MyClass.Print();

## 클래스 참조 
- 선언한 클래스 -> 참조형 클래스 변수 
- new 생성한 클래서 -> 객체 

## this
- this는 객체 자신을 참조하는 키워드 : this.member
- 메소드의 매개변수와 멤버 변수명이 같을 때 this.number = number

# 23강 
## Property 속성  
- 역할 : 클래스 안의 멤버변수에 값 읽기 또는 저장 
- private로 선언된 멤버 변수 
- keyword : get, set, value, return 
ex) 
class A 
{
	private string name;
	private int number;

	public int Name 
	{
		get { return count; }
		set { count = value; }
	}
	
	//이런식으로 가려서 받을 수도 있다.  
	public int Number
	{
		get { return number; }
		set
		{
			if( value <  0 || value > 9) number = 0;
			else number = value;
		}
	}
}

A test = new A();
test.Name = "Microsoft C#";
Console.WriteLine("{0}", test.Name);

# 24강 
## 인덱서 indexer 
- 클래스 내의 배열 도는 컬렉션을 외부에서 접근할 수 있도록 하는 역할 
- 키워드 : 속성 형식 + 배열 형식 (get, set, return, value + this[int index])
- 사용 방법 : 배열과 같이 사용, 객체명[인덱스] = 값 또는 변수;
ex)
class A
{
	private int[] number = new int[5];
	public int this[int index]
	{
		get { return number[index]; }
		set { number[index] = value; }
	}
}

A test = new A();

test[i] = i;
Console.WritteLine(test[i]);

# 25강 

# 26강 
## 델리게이트 delegate
- 메서드 참조형이다. 
- 복수 또는 단일 메서드를 대신하여 호출하는 역할 -> 같은 형식이여야 한다.
- 메서드만 호출 가능
- 외부에서 호출가능(private, protected 메서드는 호출 불가)
- delegate int DelegateType(string Name)
### 델리게이트 생성 
- DelegateType DelegateMethod = new DelegateType( Function );
- DelegateType DelegateMethod = Fuction;
### 멀티캐스트 델리게이트 
- 다수 또는 단일 메서드 호출 
- +=, -= 호출할 메서드를 포함 또는 제거 

delegate void DelegateType();

class A
{
	public void PrintA()
	{
		Console.WriteLine("PrintA");
	}

	public void PrintB()
	{
		Console.WriteLine("PrintB");
	}
}

class Program
{
	static void Main(string[] args)
	{
		A Test = new A();
		DelegateType DelFunc = Test.PrintA();
		DelFunc += Test.PrinatB();
		DelFunc -= Test.PrintA();
		DelFunc();
	}
}

## event 
- 이벤트를 발생시키는 클래스 -> 게시자 
- 이벤트를 받거나 처리하는 클래스 -> 구독자
- 델리게이트를 기반으로 한다. (메서드 호출)
- 이벤트는 메서드 안에서만 사용 가능  
- delegate void DelegateType(string message)
   class A
   {
	public event DelegateType EventHandler;
	public void Func(string Message)
	{
		EventHandler(Message);
	}
   }

   Test1.EventHandler += Test2.PrintA;
   Test1.Func("Hi~~!");

### 이벤트의 핵심
- 이벤트 핸들러에 객체 메서드를 연결
- 이벤트 핸들러는 객체 메서드에서 호출
- 이벤트 핸들러를 포함하여 객체 안에 메서드를 통해 다른 객체 또는 같은 객체의 
메서드를 호출하기 위한 방법 (같은 데이터 전달)

## 델리게이트와 이벤트
### 공통점
- 객체의 메서드를 호출 
### 차이점 
- 델리게이트 : 델리게이트로 호출, 델리게이트에 연결
- 이벤트 : 이벤트를 포함한 메서드에서 호출, 이벤트 핸들러 연결

# 27강
## 상속 

