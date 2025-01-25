public class GameManger
{
    private static GameManger? instance;

    public static GameManger Instance
    {
        get
        {
            // Lazy initialization
            if (instance == null)
            {
                instance = new GameManger();
            }
            return instance;
        }
    }

    public void RunGame()
    {
        Console.WriteLine("Game Started!");
    }

    void InitilizeNewGame()
    {
        throw new NotImplementedException();
    }

    void LoadGame()
    {
        throw new NotImplementedException();
    }    
}