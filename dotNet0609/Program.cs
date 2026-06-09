// //10-1 예외 상황 확인
// string[] array = {"가", "나"};
// Console.WriteLine("숫자입력:");
// int input = int.Parse(Console.ReadLine());

// if (input < array.Length)
// {
//     Console.WriteLine("입력값은 " + array[input]);
// }
// //10-2 기본 예외 처리
// else
// {
//     Console.WriteLine("인덱스 범위를 벗어났습니다.");
// }

// //10-4 고급 예외 처리
// Console.Write("숫자입력:");
// string input = Console.ReadLine();

// try
// {
//     int index = int.Parse(input);
//     Console.WriteLine("입력값은 " + index);
// }
// catch (Exception e)
// {
//     Console.WriteLine("유효한 숫자를 입력해주세요.");
//     Console.WriteLine(e.GetType());
// }
// finally
// {
//     Console.WriteLine("프로그램이 종료됩니다.");
// }

// //10-9 예외 상황 확인
// Console.Write("숫자입력:");
// try
// {
//     string input = Console.ReadLine();
//     int[] array = {52, 273, 32, 103};

//     int index = int.Parse(input);
//     Console.WriteLine("입력숫자 " + index);
//     Console.WriteLine("배열요소 " + array[index]);
// }
// catch (FormatException exception)
// {
//     Console.WriteLine("유효한 숫자를 입력해주세요.");
//     Console.WriteLine(exception.GetType());
// }
// catch (IndexOutOfRangeException exception)
// {
//     Console.WriteLine("인덱스 범위를 벗어났습니다.");
//     Console.WriteLine(exception.GetType());
// }

//10-10 box 클래스의 예외 관련 구현
class Program
{
    class Box
    {
        private int width;
        public int Width
        {
            get { return width; }
            set
            {
                if (value > 0) { width = value; }
                else
                {
                    throw new Exception("너비는 양수여야 합니다.");
                }
            }
        }
        private int height;
        public int Height
        {
            get { return height; }
            set
            {                
                if (value > 0) { height = value; }
                else
                {                    
                    throw new Exception("높이는 양수여야 합니다.");
                }
            }
        }
        public Box(int width, int height)
        {
            Width = width;
            Height = height;
        }
        public int Area()
        {
            return this.width * this.height;
        }
    }
    static void Main(string[] args)
    {
        Box box = new Box(-10, -20);
    }
}