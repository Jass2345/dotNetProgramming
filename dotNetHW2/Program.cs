using System;

namespace AccountManagementSystem
{
    public class InvalidInputException : Exception
    {
        public InvalidInputException(string message) : base(message)
        {
        }
    }

    class Program
    {
        static string[] userDatabase = new string[3];
        static int userCount = 0;

        static void Main(string[] args)
        {
            Console.WriteLine("=== 회원가입 및 계정 관리 시스템 ===");

            while (true)
            {
                Console.WriteLine($"\n[현재 등록 회원 수: {userCount} / 3]");
                Console.Write("회원가입을 진행하시겠습니까? (y/n): ");
                string choice = Console.ReadLine();

                if (choice?.ToLower() != "y")
                {
                    Console.WriteLine("프로그램을 종료합니다.");
                    break;
                }

                RegisterUser();
            }
        }

        static void RegisterUser()
        {
            try
            {
                Console.Write("아이디를 입력하세요: ");
                string id = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(id))
                {
                    Console.WriteLine("[알림] 아이디 입력 값이 누락되었거나 공백입니다. 다시 시도해주세요.");
                    return;
                }

                if (id.Length < 4)
                {
                    throw new InvalidInputException("아이디는 최소 4글자 이상이어야 합니다.");
                }

                Console.Write("나이를 입력하세요: ");
                string ageInput = Console.ReadLine();

                int age = int.Parse(ageInput);

                userDatabase[userCount] = $"아이디: {id}, 나이: {age}";
                userCount++;

                Console.WriteLine("▶ 회원가입이 성공적으로 완료되었습니다!");
            }
            catch (InvalidInputException ex)
            {
                Console.WriteLine($"[입력 오류] {ex.Message}");
            }
            catch (FormatException)
            {
                Console.WriteLine("[형식 오류] 나이는 숫자만 입력할 수 있습니다.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("[범위 오류] 입력한 숫자가 유효한 나이 범위를 벗어났습니다.");
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("[시스템 오류] 등록 정원이 초과되었습니다.");
            }
            finally
            {
                Console.WriteLine("--- 회원가입 프로세스 종료 ---");
            }
        }
    }
}