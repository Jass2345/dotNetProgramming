class Game
{
    public static int TotalGameCount = 0;
    private string gameName = "";
    private int gamePrice;
    private int playerCount;
    private double gameReviewScore;


    private string GameName
    {
        get => GameName;
        set { GameName = value; }
    }
    private int GamePrice
    {
        get => GamePrice;
        set { GamePrice = value; }
    }
    //섀도잉은 변수 이름이 겹쳐서 발생하는 문제야.
    //변수 이름과 프로퍼티 이름이 동일하기 때문에 무한 재귀 호출이 발생하는데,
    //이걸 해결하기 위해서 변수 이름과 프로퍼티 이름을 다르게 설정해야 하는거야.
    private int PlayerCount
    {
        get => PlayerCount;
        set { PlayerCount = value; }
    }
    private double GameReviewScore
    {
        get => GameReviewScore;
        set { GameReviewScore = value; }
    }
    
    public Game()
    {
        TotalGameCount++;
    }
    public Game(string gameName, int gamePrice, int playerCount, double gameReviewScore)
    {
        this.gameName = gameName;
        this.gamePrice = gamePrice;
        this.playerCount = playerCount;
        this.gameReviewScore = gameReviewScore;
        TotalGameCount++;
    }
    
    public void PlayGame(string gameName)
    {
        Console.WriteLine($"{gameName}을 시작합니다!");
    }

}
class Program
{
    static void Main(string[] args)
    {
        Game WT = new Game("WarThunder", 0, 99, 5.0);
        Game R6S = new Game("RainbowSixSiege", 0, 10, 5.0);

        WT.PlayGame;
    }
}