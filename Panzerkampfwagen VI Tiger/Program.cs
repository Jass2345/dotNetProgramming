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