CSharp Study Summary
=============

# 1��
�ü���� ��� ������ ��ũ 
��� �����ӿ�ũ ���� ���
=> Ŭ���� ���̺귯���� CLR(Common Lauguage Runtime)
CRL => ������ ��ũ�ȿ� �ִ� ��� => �ۼ��� �ڵ带 �츮�� ����ϴ� 
OS�� �°� ��ȯ�� => �����ϵ� C#�ڵ带 �����ϴ� ���� 
msdn.Miscrosoft.com => ��� �ڵ忡 ���� ������ ����

# 2��
C++��� �� �ڹ��� ������ ������ 
C#�� �����͸� ���� ������� ���� => �������� ���� �ڵ��� ���
�޸� ������ delete or free => �޸� ���� �߻�
=> C#������ ������ �÷��Ϳ��� �����ؼ� �ڵ����� �������� 
=> �׳� new�� ������ �ϸ� �� => ���� �� �ʿ� ����!!
C# ���α׷� ��������� MSDN�� ��������
## ���� ���� 
C# ��� -> ������ -> MSIL ->  CRL -> ����
(�츮�� ������ �κ��� �����ϱ�����!)

# 3�� 

# 4�� 
## ǥ�� �����
Console.Write(), Console.WriteLine(); => static���� ����Ǿ� ���� 
Console.Write("{0} {1}", 3.14f, 2); =>  3.14 2 �� ���
C : ��ȭ($, \ ��) ǥ��
D : 10���� ����
E : �������� ���
F : �ε� �Ҽ��� ��� 
G : �⺻ ��� 
N :  �޹����
P : %�� ��� 
X : 16���� 
=> �� �ۿ� �͵� MSDN����
ex) Console.WriteLine("{0:C} {1:P} {0:X}", 123, 123.45, 123); => \123, 12,345.00%, 7B �� ���

# 5�� 
C#�� �������� object���� ��� �Ļ��� 
������ ���� CTS���� ���ǵ� ��ü 
System.Single = float
byte ��ȿ ���� : ��ȣ ���� 0 ~ 255
sbyte ��ȿ ���� : -128 ~ 127
short.MinValue, short.MaxValue => ������ ���� �ּ�, �ִ�
C/C++ ���ڿ��� ������ => ���ڿ� ���� 0, '/0'
'+' : ���ڿ� ���� 
'==' : ���ڿ��� �� 
[�ε���] : ���� 
## �������� '\' ����� �� 
1. �ι� ���� : "C:\\temp\\test.txt"
2. �տ� @�� ���δ�. : @"C:\temp\test.txt";

# 6�� 
var : ���ԵǴ� �����Ϳ� ���� �������� ���� 
## ����� �� ���� ��
1. null �� �ʱ�ȭ, �Ű����� ��� x
2. var�� ���� �����θ� ���, Ŭ���� ����δ� ��� x
3. ���������� �ʱ�ȭ �ϴ� ��� :  var m = 10, n = 20; x
## �Ҽ��� ���� �ڸ��� ��� 
Console.WriteLine("{0} {1:f1} {2}", value1, value2, sum);
{1: f1} f1 : float���� �Ҽ��� ù° ¥�������� ��� : 2.1
        f2 : 2.12
## nullable�� : null�� ������� �ʴ� ��������(�⺻ ��������, int, float ��� )�� null ���� ���
����
������? ������ : int? Var1; bool? Var2 = null; 
## ������ ��ȯ 
ToString()
�⺻ ��������.Parse()
Convert.ToInt32()
Convert.ToSingle()
Convert.ToXXXXX()

# 7�� 
## �ڽ�(boxing)
���������� �ֻ��� object ������ ��ȯ�Ͽ� ���� ����(�� ���� �ϴ� ���°� x)
������ �޸𸮸� ��� 
int m = 123;
object obj = m;
## ��ڽ� : ���� ����� ������ �ٽ� ������ �������� ��ȯ 
int n = (int)obj;
## ǥ�� �Է� 
Console.ReadKey()
����ڰ� ���� Ű �� ���� ������ �����ϴ� �޼���
## �Լ� ���� 
public static ConsoleKeyInfo ReadKey()
public static ConsoleKeyInfo ReadKey(bool ReadKey)
=> true : ȭ�� ��� ����, false : ȭ�� ��� 
## ConsoleKeyInfo.Key
ConsoleKey ������ �� => MSDN ���� 
��ҹ��� ���� x => �ذ� �� : ConsoleKeyInfo.KeyChar : �����ڵ带 ���� 
## Console.ReadLine() : ����Ű�� ������ ������ �Է� ���� ���ڿ��� �����ϴ� �޼��� 

# 8�� 
## public struct ����ü��
{
// ���, �Ӽ�, �޼��� 
}
## ���� ����
- ����ü�� ����� const, static ������ �ʱ�ȭ ���� 
- ����ü �ȿ� ������ �� �ִ� �����ڴ� �Ű������� �ݵ�� �־�� ��
public struct MyStruct
{
	public int Age;
	public MyStruct(int InAge)
	{
		Age = InAge;
	}
}
- ����ü�� ���� ����ü�� �����ϰ� �Ǹ� ���� ���� (������ ���)
- ����ü�� �� �����̰� Ŭ������ ���� ������ 
- ����ü�� �� �����̹Ƿ� �������ε� ��� ����
- new�� ������� ���� -> �����ڰ� ȣ�� -> �⺻������ �ʱ�ȭ
- ����ü�� ����ü �Ǵ� Ŭ������ ����� �� ���� (c++������ ���� )
- ����ü�� �������̽��� ����Ͽ� �޼��带 ������ �� ���� 

## ������ : ����� ���ڿ��� ��ġ�Ͽ� ����, ����� �ǹ� �ο� 
## ���� 
enum ������ ��Ī { ���ڿ�1, ���ڿ�2 };
		{ ���ڿ�1 = ���, ���ڿ�2 = ���};
		{ ���ڿ�1 = ���, ���ڿ�2 };

�⺻�� int�������� char ���� ������ ���� ������ �� ����
enum Days : byte { Sun = 0, Mone, Tue, Wed, Thu };
## ������ ������ �ƴ� ������ ������ ���� ������ ������ ���������� ����� �� 

# 9�� 
�� ���� : ������ ���� ���� �����ϴ� ��, �⺻��������, ����ü, ������ 
����(�ݵ�� �ʱ�ȭ �ؾߵ�) vs ����(new, �ڵ����� �⺻������ �ʱ�ȭ)

���� ���� : �� ��ü�� ������ ������ ����� �� �������� ���� ������ �ٲ�� ��ü�� ������ ��
class, interface, delegate, �迭, string 
��ü�� ������ ������ ������ ��ü�� �޸� �ּҰ� �����

# 10�� 
## ������ 
����/�ε� + "���ڿ�" = "���ڿ�"
string str = 1 + "test" + 3.14f + "abcd" => ���ڿ�
## is ������(�Ǵ�)
���� ȣȯ�� �����ϴ� ������ 
���� : '����' is 'Ŭ������ or ��������' = A is B => ����� true, false
�ڽ�/��ڽ� ��ȯ, ���� ��ȯ���� ��� 
int nValue = 10;
if(nValue is float)
## as ������(��ȯ)
���� 
����ȯ�� ��ȯ ���� 
ĳ��Ʈ �������� ���Ұ� �Һ�ȯ�� null ���� 
����, �ڽ�, ��ڽ�, null���� ��� 
���� : ����� = ������, ��ڽ�, �ڽ� as ��ȯ�� 
A test1 = new A();
object obj1 = test1;
B test2 = obj1 as B;
if(test2 == null) Console.WriteLine("����ȯ ����");
else Console.WriteLine("����ȯ ����");
## null ���� ������ : ??
null�� �����ϴ� ������ : null�̸� ���� �ְ�, �ƴϸ� ���� ����
C = A ?? B; (A�� ����)
A�� null�� �ƴϸ� A�� C�� ����
A�� null�̸� B�� C�� ���� 
int? x = null;
int y = x ?? -1; // y�� -1

# 11��
## foreach
ó������ ������ �������� ���� �ݺ��Ͽ� �д� ���� -> �б� ���� 
int[] Array1 = { 1, 2 .... , 10 };
foreach(int nValue in Array1)
{
	Console.WriteLine(nValue);
} 
## ���� ó�� 
try
{
	// ���ܰ� �߻��� �� �ִ� �ڵ� 
}catch(����ó�� ��ü e)
{
	//���� ó�� 
}
try �� �ȿ��� �ʱ�ȭ�� ������ try �� �ۿ��� ����� �� ����. 
try ~ finally 
finally : ���� �߻��� ������� �׻� ����Ǵ� ���� 
���� ���� ó�� : catch�� ������ ���޾� ���̸� ��
throw : ���� ��Ȳ�� ���Ƿ� �߻���Ű�� ����

# 12��
## 1���� �迭 
�⺻ ���� : ���� �������� + ������ + �������� �޸� ���� 
������ : new�� ���� ���� 
Array�κ��� �Ļ��� ������ 
foreach ��� ���� 
���� ���� : ��������[] �迭��; int[] array_name;
## ������ �迭 
�޸��� ���� 
�������� : int[,] array1 = new int[2, 2](2���� �迭) int[,,] array2 = new int[2, 3, 2](3���� �迭)
array1[0, 1] = 2;


# 13��
���� �迭 : �����͸�[][] �迭��; int[][] array_name;
ex) int[][] array = new int[3][];
     array[0] = new int[2];
     array[1] = new int[3];
     array[2] = new int[4];

�迭 �Լ��� ���� 
void func(int[] arr) { } (1���� �迭)
void func(int[, ] arr) { } (2���� �迭)

# 14�� 
## �迭 �ʱ�ȭ �޼��� 
public static void Clear(Array array, int index, int length) index���� length�� �ش��ϴ� 
������ 0���� �ʱ�ȭ 
##�迭�� ���� 
public object Clone(); int[] nCloneArray = (int[])nArray1.Clone();

# 15��
## ���� ����� 
### ��Ʈ��(stream)
����, ��Ʈ��ũ ��� �����͸� ����Ʈ ������ �а� ���� Ŭ����
Stream class�� ���� �⺻ Ŭ������ 
using System.IO ���� 
### File Stream
���� ������� �ٷ�� �⺻ Ŭ���� 
byte[] �迭�� �����͸� �аų� ������ => ����ȯ�� �䱸�� 
���� ���� ������ ��� 
public FileStream( string path, FileMode mode, FileAccess access)
�ؽ�Ʈ ������ Ư¡ : �⺻���� = 1����Ʈ, �ƽ�Ű �ڵ� ���, �ƽ�Ű�ڵ带 �����ڵ�� ���ڵ� 
static void Main(string[] args)
{
	FileStream fs = new FileStream("text.txt", FileMode.Create);
	StreamWriter sw = new StreamWriter(fs);
	sw.Close();
}
or
using(Stream Writer sw = new StreamWriter(new FileStream("text.txt", FileMode.Create))
{
	//���� ����� ó��  
} // �ڵ����� Close ����, ���õǺ��̴ϱ� ���� ���� 
���� �޼��� Write, WriteLine�� ���� �� sw.Write(value);
�б� �޼��� Read(), ReadLine(), string ReadLine()

#16�� 
## string ������ �и� 
public string[] Split( Params char[] separator )
string.Split(new char[] { ' ' }); 
using (BinaryReader br = new BinaryReader(File.Open("test.dat, FileMode.Open))
{
	var1 = br.ReadInt32();
	var2 = br.ReadSingle();
	str1 = br.ReadString();
}

# 17��
## serialize(����ȭ)
�⺻�������� �Ӹ� �ƴ϶� ����ü�� Ŭ������ �а� ���� ���� 
using System.Runtime.Serialization.Formatters.Binary;
����ȭ ��� ���� 
[Serializable]
struct A or Class A
{

}

public void Serialize(Stream serializationStream, object graph) //����
public object Deserialize(Stream serializationStream)//�б�

using(FileStream fs1 = new FileStream("test.dat", FileMode.Create))
{
	BinaryFormatter bf = new BinaryFormatter();
	bf.Serialize(fs1, Data); // �÷��ǵ� ��� ����� ����. Data ��� DataList
}

using(FileStream fs2 = new FileStream("test.dat", FileMode.Open))
{
	BinaryFormatter bf2 = new BinaryFormatter();
	ResultList = (List<data>)bf2.Deserialize(fs2);
}


## ������ȭ
����ȭ ��󿡼� ����
[Serializable]
class TestClass
{
	int nValue;
	[NonSerialize] // ������ ��� ������ȭ
	string strMessage;
	// �Ǵ� [NonSerialize] string strMessage;
}
���׸� = ���ø�

# 18~20�� ������Ʈ 
�ʼ� Ŭ������ �޼��� 
1. ȭ�� ��� Ŭ���� : Console
   ȭ�� ��� �޼��� : Console.Beep(), Console.Clear(), Console.SetCursorPosition,
		Console.SetWindowSize(), Thread.Sleep();
   �ܼ� ���� ���� �Ӽ� : Console.BackgroundColor, Console.ForgroundColor

# 21�� 
## Ŭ���� 
������ �޼��带 �׷�ȭ�� �� 
### �ֿ䰳�� 
- �׷�ȭ�� ���� class Ű����� ���� ���
- new �����ڷ� �����Ͽ� ���
- new�� ������� ������ ���� Ŭ������ ������ �� �ִ� ������ �� (Ŭ���� ���� ����)
- Ŭ������ new�� ���� �����ϸ� ��ü�� �� 
- �ν��Ͻ��� ��ü�� ���� :  �ν��Ͻ��� ����, ��ü�� �ǹ��� ���� A test1 (object) = new A(); (instatnce)
   "���� A �ν��Ͻ��� ������ test1�� test2 ��ü"
### ���� 
- Ŭ���� ���İ� ����ü ������ ���� 
struct struct_name    class class_name
{                           {

}                           }
xxx.��� ����, xxx.��� �޼��� 

����ü ������ ����, Ŭ���� ������ ������ 

����
class Date 
{
	int Year, Month, Day;
	void Print()
	{
		Console.WriteLine("{0} {1} {2}", Year, Month, Day);
	}
}

### ���� ������ 
- ������ �ڵ������� private 
- Ŭ���� ����� ���� ���� ���� ����
- ���� ������ : private, protected, public, internal(C#���� �߰��� ����), protected internal
- Ŭ���� ��ü�� �����ϴ� ���� ������ 
  public -> �����
  internal -> �Ͻ��� 
#### public 
- Ŭ���� ���ܺο��� ��� ���� ���� 
- ��Ӱ��迡���� ���� �����ϰ� ���� ���� 
#### private 
- Ŭ���� �Ǵ� ����ü �ȿ����� ����� ����
- Ŭ���� �ܺο����� ��� �ȵ� 
#### protected
- Ŭ���� �ȿ����� private�� ���� ���� 
- ���� Ŭ���� �ȿ����� ���� protected ��� ���� ����
#### internal 
- ���� �����(exe, dll, ���� ������Ʈ) �ȿ� ���� ���� ���ܺο��� ����� ���� ����
- Ŭ���� ���ο� ���� ������ ������ internal ������ �� 
#### protected internal 
- ���� ����� �ȿ����� internal�� ���� 
- ���� �ٸ� ����� �ȿ��� ��Ӱ����� �� ���� Ŭ������ ���� Ŭ������ protected internal ����� 
������ �� ����, �ܺο��� ������ �� ����  
 
# 22�� 
## ��ü ���� 
- new�� ���� 
- ��ü ������ ������ �÷��Ϳ��� 

## ������ Constructor
- ��ü�� ������ �� �ڵ����� ȣ��Ǵ� �޼��� 
- new
- �⺻ ������ : Ŭ������� ���� �̸�, �������� ����, ���� �����ڴ� public 
- ������ : �Ű������� ����, �������� ����, ���� �����ڴ� public 
## �Ҹ��� Destructor
- ��ü�� �Ҹ�� �� ȣ��Ǵ� �޼��� 
- ������ �÷��� 
- Ŭ������� ����
- ������ ���� 
- ���� ������ ���� 
- ~�� ������ 
~MyClass()
{

}

## ���� ���
### �� ���� static ���� ��
- C :  ���� �� ���� 
- C++ : ��ü �ȿ��� ���� ���� 
- C# : ��ü�� �������� �ʰ� ��� ���, MyClass.Print();

## Ŭ���� ���� 
- ������ Ŭ���� -> ������ Ŭ���� ���� 
- new ������ Ŭ���� -> ��ü 

## this
- this�� ��ü �ڽ��� �����ϴ� Ű���� : this.member
- �޼ҵ��� �Ű������� ��� �������� ���� �� this.number = number

# 23�� 
## Property �Ӽ�  
- ���� : Ŭ���� ���� ��������� �� �б� �Ǵ� ���� 
- private�� ����� ��� ���� 
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
	
	//�̷������� ������ ���� ���� �ִ�.  
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

# 24�� 
## �ε��� indexer 
- Ŭ���� ���� �迭 ���� �÷����� �ܺο��� ������ �� �ֵ��� �ϴ� ���� 
- Ű���� : �Ӽ� ���� + �迭 ���� (get, set, return, value + this[int index])
- ��� ��� : �迭�� ���� ���, ��ü��[�ε���] = �� �Ǵ� ����;
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

# 25�� 

# 26�� 
## ��������Ʈ delegate
- �޼��� �������̴�. 
- ���� �Ǵ� ���� �޼��带 ����Ͽ� ȣ���ϴ� ���� -> ���� �����̿��� �Ѵ�.
- �޼��常 ȣ�� ����
- �ܺο��� ȣ�Ⱑ��(private, protected �޼���� ȣ�� �Ұ�)
- delegate int DelegateType(string Name)
### ��������Ʈ ���� 
- DelegateType DelegateMethod = new DelegateType( Function );
- DelegateType DelegateMethod = Fuction;
### ��Ƽĳ��Ʈ ��������Ʈ 
- �ټ� �Ǵ� ���� �޼��� ȣ�� 
- +=, -= ȣ���� �޼��带 ���� �Ǵ� ���� 

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
- �̺�Ʈ�� �߻���Ű�� Ŭ���� -> �Խ��� 
- �̺�Ʈ�� �ްų� ó���ϴ� Ŭ���� -> ������
- ��������Ʈ�� ������� �Ѵ�. (�޼��� ȣ��)
- �̺�Ʈ�� �޼��� �ȿ����� ��� ����  
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

### �̺�Ʈ�� �ٽ�
- �̺�Ʈ �ڵ鷯�� ��ü �޼��带 ����
- �̺�Ʈ �ڵ鷯�� ��ü �޼��忡�� ȣ��
- �̺�Ʈ �ڵ鷯�� �����Ͽ� ��ü �ȿ� �޼��带 ���� �ٸ� ��ü �Ǵ� ���� ��ü�� 
�޼��带 ȣ���ϱ� ���� ��� (���� ������ ����)

## ��������Ʈ�� �̺�Ʈ
### ������
- ��ü�� �޼��带 ȣ�� 
### ������ 
- ��������Ʈ : ��������Ʈ�� ȣ��, ��������Ʈ�� ����
- �̺�Ʈ : �̺�Ʈ�� ������ �޼��忡�� ȣ��, �̺�Ʈ �ڵ鷯 ����

# 27��
## ��� 

