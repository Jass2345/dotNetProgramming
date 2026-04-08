//0325 실습문제
Console.Write("영문 문자열을 입력하세요: ");
string input = Console.ReadLine().ToLower();
int count = 0;

foreach (char ch in input)
{
    switch(ch)
    {
        case 'a':
        case 'e':
        case 'i':
        case 'o':
        case 'u':
            count++;
            break;
        default:
            break;
    }
}
Console.WriteLine($"모음의 갯수는 {count}개 입니다.");