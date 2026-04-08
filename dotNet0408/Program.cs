// //5-2 Random클래스를 사용한 임의의 실수 생성
// Random random = new Random();
// Console.WriteLine(random.NextDouble());
// Console.WriteLine(random.NextDouble());
// Console.WriteLine(random.NextDouble());
// Console.WriteLine(random.NextDouble());

// //5-3 리스트 요소 추가
// List<int> list = new List<int>();

// list.Add(52);
// list.Add(273);
// list.Add(32);
// list.Add(64);

// foreach (var item in list)
// {
//     Console.WriteLine("Count:" + list.Count + "\titem: " + item);
// }

// //5-4 리스트 요소 제거
// List<int> list = new List<int>() { 52, 273, 32, 64 };

// list.Remove(52);

// foreach (var item in list)
// {
//     Console.WriteLine("Count:" + list.Count + "\titem: " + item);
// }

// // 5-5 Math 클래스 활용
// Console.WriteLine(Math.Abs(-52273)); //절대값
// Console.WriteLine(Math.Ceiling(52.273)); //올림
// Console.WriteLine(Math.Floor(52.273)); //내림
// Console.WriteLine(Math.Max(52, 273)); //최댓값
// Console.WriteLine(Math.Min(52, 273)); //최솟값
// Console.WriteLine(Math.Round(52.273)); //반올림

// // 클래스 선언과 객체 생성
// class Program
// {
//     class Product
//     {
//         public string name;
//         public int price;
//     }

//     static void Main(string[] args)
//     {
//         Product product = new Product();
//         product.name = "감자";
//         product.price = 2000;
//         Console.WriteLine(product.name + " : " + product.price + "원");
//     }
// }

// // 5-7 클래스 변수 생성과 사용
// class Program
// {
//     class MyMath
//     {
//         public static double PI = 3.141592;
//     }

//     static void Main(string[] args)
//     {
//         Console.WriteLine(MyMath.PI);
//     }
// }

// 6-1 인스턴스 메서드 생성과 사용
// class Program
// {
//     class Test
//     {
//         public int Power(int x)
//         {
//             return x * x;
//         }
//     }

//     static void Main(string[] args)
//     {
//         Test test = new Test();
//         Console.WriteLine(test.Power(10));
//         Console.WriteLine(test.Power(20));
//     }
// }

//실습과제
// 1. 컴퓨터 클래스
// - 속성: 브랜드, 모델, 용도, 운영체제, 메모리 용량, 저장 용량, 화면 크기 등
// - 메서드: 켜기, 끄기, 재부팅, 프로그램 실행, 파일 저장, 인터넷 연결 등
class Program
{
    class Computer
    {
        public string brand;
        public string model;
        public string usage;
        public string operatingSystem;
        public int memoryCapacity;
        public int storageCapacity;
        public double screenSize;

        public void TurnOn()
        {
            Console.WriteLine("컴퓨터가 켜졌습니다.");
        }

        public void TurnOff()
        {
            Console.WriteLine("컴퓨터가 꺼졌습니다.");
        }

        public void Reboot()
        {
            Console.WriteLine("컴퓨터가 재부팅됩니다.");
        }

        public void RunProgram(string programName)
        {
            Console.WriteLine(programName + " 프로그램이 실행됩니다.");
        }

        public void SaveFile(string fileName)
        {
            Console.WriteLine(fileName + " 파일이 저장되었습니다.");
        }

        public void ConnectToInternet()
        {
            Console.WriteLine("인터넷에 연결되었습니다.");
        }
    }

}

// 2. 주문 클래스
// - 속성: 주문번호, 주문자명, 주문일자, 주문 상품, 수량, 가격, 주소, 전화번호 등
// - 메서드: 주문 생성, 주문 취소, 결제, 배송 등
class Program
{
    class Order
    {
        public string orderNumber;
        public string ordererName;
        public DateTime orderDate;
        public string product;
        public int orderCount;
        public int price;
        public string address;
        public string phoneNumber;
        public void OrderMake()
        {
            Console.WriteLine(product + "의 주문이 생성되었습니다.");
        }
        public void OrderCancel()
        {
            Console.WriteLine(product + "의 주문이 취소되었습니다.");
        }
        public void OrderPayment()
        {
            Console.WriteLine(product + "의 결제가 완료되었습니다. 금액은 " + (price * orderCount) + "입니다.");
        }
        public void OrderDelivery()
        {
            Console.WriteLine(product + "상품을 " + address + "로 배송하겠습니다.");
        }
    }
}

// 3. 학생 클래스
// - 속성: 이름, 학번, 전공, 학년, 성적, 출석률, 이메일, 전화번호 등
// - 메서드: 출석 체크, 성적 입력, 성적 조회, 이메일 발송, 전화 걸기 등
class Program
{
    class Student
    {
        public string name;
        public string studentId;
        public string major;
        public int grade;
        public double score;
        public double attendanceRatio;
        public string email;
        public string phoneNumber;
        public void CheckAttendance()
        {
            Console.WriteLine(name + " 학생의 출석이 체크되었습니다.");
        }
        public void InputScore(double newScore)
        {
            score = newScore;
            Console.WriteLine(name + " 학생의 성적이 입력되었습니다.");
        }
        public void ViewScore()
        {
            Console.WriteLine(name + " 학생의 성적은 " + score + "입니다.");
        }
        public void SendEmail()
        {
            Console.WriteLine(name + " 학생에게 이메일이 발송되었습니다.");
        }
        public void MakePhoneCall()
        {
            Console.WriteLine(name + " 학생에게 전화가 걸렸습니다.");
        }
    }
}

// 4. 음식 주문 시스템 클래스
// - 속성: 주문번호, 주문자명, 주문일자, 주문 메뉴, 수량, 가격, 주소, 전화번호 등
// - 메서드: 메뉴 선택, 수량 입력, 가격 계산, 주문 생성, 결제, 배송 등
class Program
{
    class FoodOrderSystem
    {
        public string orderNumber;
        public string ordererName;
        public DateTime orderDate;
        public string menu;
        public int orderCount;
        public int price;
        public string address;
        public string phoneNumber;

        public void SelectMenu(string selectedMenu)
        {
            menu = selectedMenu;
            Console.WriteLine(menu + " 메뉴가 선택되었습니다.");
        }
        public void InputOrderCount(int count)
        {
            orderCount = count;
            Console.WriteLine("수량이 " + orderCount + "개로 입력되었습니다.");
        }
        public void CalculatePrice()
        {
            Console.WriteLine("총 가격은 " + (price * orderCount) + "입니다.");
        }
        public void CreateOrder()
        {
            Console.WriteLine(menu + "의 주문이 생성되었습니다.");
        }
        public void Payment()
        {
            Console.WriteLine(menu + "의 결제가 완료되었습니다. 금액은 " + (price * orderCount) + "입니다.");
        }
        public void Delivery()
        {
            Console.WriteLine(menu + "상품을 " + address + "로 배송하겠습니다.");
        }
    }
}