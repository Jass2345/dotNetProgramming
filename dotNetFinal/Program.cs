using System;
using System.Collections.Generic;

namespace DotNetFinalExam
{
    public class InvalidPriceException : Exception
    {
        public InvalidPriceException(string message) : base(message) { }
    }

    // IComparable 인터페이스를 구현하여 리스트 정렬이 가능하게 만듭니다.
    public class Product : IComparable<Product>
    {
        public string Name { get; set; }
        private int price;
        public int Price
        {
            get { return price; }
            set
            {
                if (value <= 0)
                    throw new InvalidPriceException("가격은 0원보다 커야 합니다.");
                price = value;
            }
        }

        public Product(string name, int price)
        {
            Name = name;
            Price = price;
        }

        // ★ [에러 수정] IComparable 구현을 위해 꼭 필요한 메서드 (가격을 기준으로 정렬)
        public int CompareTo(Product other)
        {
            if (other == null) return 1;
            return this.Price.CompareTo(other.Price);
        }
    }

    class Program
    {
        public static bool TryAddProduct(string nameInput, string priceInput, out Product prod)
        {
            prod = null;

            try
            {
                int parsedPrice = int.Parse(priceInput);
                prod = new Product(nameInput, parsedPrice);
                return true; // 성공해서 여기서 return을 만나도 finally는 무조건 실행됨!
            }
            catch (FormatException)
            {
                Console.WriteLine($"[오류] '{nameInput}' 등록 실패: 숫자만 적어주세요");
                return false; // catch에서 return을 만나도 finally는 실행됨!
            }
            catch (InvalidPriceException ex)
            {
                Console.WriteLine($"[오류] '{nameInput}' 등록 실패: {ex.Message}");
                return false;
            }
            catch (Exception)
            {
                Console.WriteLine("알 수 없는 오류 발생");
                return false;
            }
            // ★ [시험 핵심] 예외 발생 여부, return 여부와 상관없이 무조건 실행되는 블록!
            finally
            {
                Console.WriteLine($"=> '{nameInput}' 상품 등록 시도 종료 (자원 정리 및 마무리)\n");
            }
        }

        static void Main(string[] args)
        {
            List<Product> shopCart = new List<Product>();

            // 1. 정상 등록 테스트
            if (TryAddProduct("노트북", "1500000", out Product prod1))
            {
                shopCart.Add(prod1);
            }
            
            // 2. FormatException 유도 테스트 (숫자가 아님)
            if (TryAddProduct("마우스", "삼만원", out Product prod2))
            {
                shopCart.Add(prod2);
            }

            // 3. InvalidPriceException 유도 테스트 (0 이하의 값)
            if (TryAddProduct("키보드", "-50000", out Product prod3))
            {
                shopCart.Add(prod3);
            }

            // 4. 정상 등록 테스트
            if (TryAddProduct("패드", "20000", out Product prod4))
            {
                shopCart.Add(prod4);
            }

            Console.WriteLine("-------------------------------------------");
            // 가격 순으로 정렬 (CompareTo 메서드 기준)
            shopCart.Sort();

            Console.WriteLine("[장바구니 가격 정렬 결과]");
            foreach (var p in shopCart)
            {
                Console.WriteLine($"이름: {p.Name}, 가격: {p.Price}원");
            }
        }
    }
}