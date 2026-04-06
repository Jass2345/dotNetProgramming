# 🎓 .NET Program 학습 레포지토리

이 Repository는 `.NET Program` 과목을 수강하며 배운 내용들과 **C# 프로그래밍**을 공부하며 기록하는 개인 학습 레포지토리입니다.

날짜별로 학습한 내용을 정리하여 체계적으로 관리하고, 복습 및 포트폴리오로 활용하기 위해 만들어졌습니다.

## 📁 프로젝트 구조

```
dotnetProgram/
├── README.md                    # 이 파일 (레포지토리 소개 및 워크플로우)
├── create-daily-project.ps1     # 날짜별 프로젝트 자동 생성 스크립트
│
├── dotnet0311/                  # 2024년 3월 11일 학습
│   ├── Program.cs
│   ├── README.md               # 해당 날짜 학습 내용 정리
│   └── dotnet0311.csproj
│
├── dotnet0318/                  # 2024년 3월 18일 학습
│   ├── Program.cs
│   ├── README.md
│   └── dotnet0318.csproj
│
└── ...                          # 추가 날짜별 프로젝트
```

## 🚀 학습 워크플로우

### 1️⃣ 새로운 학습 날짜 프로젝트 생성

```powershell
# 자동화 스크립트 사용 (추천)
.\create-daily-project.ps1 -date "0325"

# 또는 수동으로 생성
dotnet new console -n dotnet0325 -f net10.0
```

스크립트 실행 시 자동으로 생성되는 것:
- .NET 10 콘솔 프로젝트
- `README.md` 템플릿 (학습 내용 정리용)
- `.gitignore` (bin, obj 폴더 제외)

### 2️⃣ 프로젝트로 이동하여 코드 작성

```powershell
# 해당 날짜 폴더로 이동
cd dotnet0325

# Visual Studio에서 코드 작성
code Program.cs

# 또는 Visual Studio Community 2026에서 열기
```

### 3️⃣ 코드 실행 및 테스트

```powershell
# 프로젝트 빌드 및 실행
dotnet run

# 특정 프로젝트 지정 실행 (루트 디렉토리에서)
dotnet run --project dotnet0325
```

### 4️⃣ 학습 내용 정리

```powershell
# README.md 파일 수정하여 학습 내용 문서화
code README.md
```

각 날짜별 `README.md`에 포함할 내용:
- 📚 학습 주제
- 📝 학습 내용 (상세 설명 및 코드 예시)
- 💡 주요 개념
- 🔍 실습 코드 목록
- ✅ 체크리스트
- 🤔 궁금한 점 / 추가 학습 필요 사항
- 📌 참고 자료

### 5️⃣ Git 커밋 및 푸시

```powershell
# 변경사항 스테이징
git add .

# 커밋 (의미 있는 메시지 작성)
git commit -m "학습: 3월 25일 - [학습 주제명]"

# GitHub에 푸시
git push origin master
```

## 💡 팁

### 여러 예제 파일 관리하기

하나의 날짜 프로젝트 안에 여러 예제가 있을 경우:

**방법 1: 메뉴 시스템 (Program.cs)**
```csharp
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== 3월 25일 학습 예제 ===");
        Console.WriteLine("1. 변수와 데이터 타입");
        Console.WriteLine("2. 조건문");
        Console.WriteLine("3. 반복문");
        Console.Write("실행할 예제 번호: ");
        
        var choice = Console.ReadLine();
        
        switch(choice)
        {
            case "1": Example1.Run(); break;
            case "2": Example2.Run(); break;
            case "3": Example3.Run(); break;
        }
    }
}
```

**방법 2: 별도 클래스 파일 생성**
- `Example1.cs`, `Example2.cs` 등으로 분리하여 `Program.cs`에서 호출

### 솔루션 파일로 통합 관리 (선택사항)

```powershell
# 최초 1회 솔루션 생성
dotnet new sln -n dotnetProgram

# 기존 프로젝트 추가
dotnet sln add dotnet0311/dotnet0311.csproj
dotnet sln add dotnet0318/dotnet0318.csproj

# 새 프로젝트 생성 후 추가
dotnet sln add dotnet0325/dotnet0325.csproj
```

## 🛠️ 기술 스택

- **.NET 10**
- **C#**
- **Visual Studio Community 2026**

## 📚 참고 자료

- [Microsoft .NET 공식 문서](https://learn.microsoft.com/dotnet/)
- [C# 프로그래밍 가이드](https://learn.microsoft.com/dotnet/csharp/)
- [.NET API 브라우저](https://learn.microsoft.com/dotnet/api/)

## 📊 학습 진행 상황

- [x] 2024-03-11: [학습 주제]
- [x] 2024-03-18: [학습 주제]
- [ ] 2024-03-25: 예정

---

**Happy Coding! 🚀**
