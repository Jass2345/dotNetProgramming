//0318실습

////코드 2-49 var 키워드
//var number = 10;
////number = "string"; //선언된 변수의 타입을 바꾸는 것은 불가능

//Console.WriteLine(number.GetType());

////예제
//int intNumber = 2147483647;
//Console.WriteLine("int 자료형: " + (intNumber, intNumber.GetType()));

//long intToLong = intNumber;
//Console.WriteLine("long 자료형: " + (intToLong, intToLong.GetType()));

//double intToDouble = intNumber;
//Console.WriteLine("double 자료형: " + (intToDouble, intToDouble.GetType()));

////기본예제 2-27
//Console.WriteLine(int.Parse("52"));
//Console.WriteLine(long.Parse("273"));
//Console.WriteLine(float.Parse("52.273"));
//Console.WriteLine(double.Parse("103.32"));

//Console.WriteLine(int.Parse("52").GetType());
//Console.WriteLine(long.Parse("273").GetType());
//Console.WriteLine(float.Parse("52.273").GetType());
//Console.WriteLine(double.Parse("103.32").GetType());

//// 기본예제 2-28
//Console.WriteLine((52).ToString());
//Console.WriteLine((52.273).ToString());
//Console.WriteLine(('a').ToString());
//Console.WriteLine((true).ToString());
//Console.WriteLine((false).ToString());

//Console.WriteLine((52).ToString().GetType());
//Console.WriteLine((52.273).ToString().GetType());
//Console.WriteLine(('a').ToString().GetType());
//Console.WriteLine((true).ToString().GetType());
//Console.WriteLine((false).ToString().GetType());

////기본예제 2-29
//double number = 52.273103;
//Console.WriteLine(number.ToString("0.0"));
//Console.WriteLine(number.ToString("0.00"));
//Console.WriteLine(number.ToString("0.000"));
//Console.WriteLine(number.ToString("0.0000"));

////기본예제 2-30
//Console.WriteLine(52+273);
//Console.WriteLine("52"+273);
//Console.WriteLine(52+"273");
//Console.WriteLine("52"+"273");

////기본예제 2-31
//Console.WriteLine(bool.Parse("True"));
//Console.WriteLine(bool.Parse("true"));
//Console.WriteLine(bool.Parse("False"));
//Console.WriteLine(bool.Parse("false"));

//0318 3주차 실습과제
//1-1.사용자로부터 숫자로만 이루어진 문자열을 입력받고, 이를 int, double, char 배열, ASCII 코드 배열로 변환하시오.
string input = Console.ReadLine();
int stringToInt = int.Parse(input);
double stringToDouble = double.Parse(input);
char[] stringToChar = input.ToCharArray();
int[] stringToAscii = input.Select(c => (int)c).ToArray();

//1-2. 변환된 값을 다시 문자열(string) 로 합쳐 출력하시오.
string recombined = $"{stringToInt} / {stringToDouble} / {new string(stringToChar)} / {string.Join("", stringToAscii)}";
Console.WriteLine(recombined);

//2-1. 사용자로부터 입력받은 문자열을 대문자, 소문자, 공백 제거, 숫자만 남기기, 역순 출력 등의 변환을 수행하시오.
string input2 = Console.ReadLine();
Console.WriteLine(input2.ToUpper());
Console.WriteLine(input2.ToLower());
Console.WriteLine(input2.Replace(" ", ""));
Console.WriteLine(new string(input2.Where(char.IsDigit).ToArray()));
Console.WriteLine(new string(input2.Reverse().ToArray()));

//2-2. int, double, bool 값으로 변환할 수 있는지 확인하고, 변환이 가능하면 출력하시오.
if (int.TryParse(input2, out int outInt)) Console.WriteLine(outInt);
if (double.TryParse(input2, out double outDouble)) Console.WriteLine(outDouble);
if (bool.TryParse(input2, out bool outBool)) Console.WriteLine(outBool);
Console.WriteLine();

//3-1. 사용자로부터 쉼표(,)로 구분된 여러 개의 값을 입력받아 각 값을 int, double, char, bool로 변환 가능한지 확인하고, 변환할 수 있는 값들만 변환하여 출력하시오.
string input3 = Console.ReadLine();

string[] items = input3.Split(',');
double sum = 0;

foreach (string item in items)
{
    string trimmed = item.Trim();
    if (int.TryParse(trimmed, out int valInt))
    {
        Console.WriteLine($" '{trimmed}' -> int 변환: {valInt}");
        sum += valInt;
    }
    else if (double.TryParse(trimmed, out double valDouble))
    {
        Console.WriteLine($" '{trimmed}' -> double 변환: {valDouble}");
        sum += valDouble;
    }
    else if (bool.TryParse(trimmed, out bool valBool))
    {
        Console.WriteLine($" '{trimmed}' -> bool 변환: {valBool}");
    }
    else if (char.TryParse(trimmed, out char valChar))
    {
        Console.WriteLine($" '{trimmed}' -> char 변환: {valChar}");
    }
}

//3-2. 변환된 숫자형 데이터(int, double)의 합을 출력하시오.
Console.WriteLine(sum);

//4-1. 사용자로부터 문자열을 입력받아, 각 문자의 ASCII 값을 추출하고 숫자로 변환하여 5를 더한 값으로 변환한다.
string input4 = Console.ReadLine();
int[] shiftedAscii = input4.Select(c => (int)c + 5).ToArray();
string shiftedString = new string(shiftedAscii.Select(a => (char)a).ToArray());
Console.WriteLine(shiftedString);

//4-2. 변환된 숫자들을 다시 문자로 변환하여 원래 문자열을 복원하시오.
string restoredString = new string(shiftedAscii.Select(a => (char)(a - 5)).ToArray());
Console.WriteLine(restoredString);
