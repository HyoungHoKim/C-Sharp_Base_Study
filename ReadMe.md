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





 






