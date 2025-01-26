public class GameManger
{
    private static GameManger? instance;
    public GameState currentGameState { get; private set; }

    public static GameManger Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new GameManger();
            }

            instance.ChangeState(GameState.Starting);
            return instance;
        }
    }

    public enum GameState
    {
        Starting,
        Menu,
        Playing,
        Pause,
        GameOver
    }

    private Player player;
    // private CreatureManager creatureManger;
    // private StringManager stringManager;

    public void RunGame()
    {
        InitilizeNewGame();
        Console.WriteLine("Game Started!");
        
    }

    public void ChangeState(GameState newState)
    {
        currentGameState = newState;

        switch (newState)
        {
            case GameState.Starting:
                Console.WriteLine("Game is starting");
                break;
            case GameState.Menu:
                Console.WriteLine("Game in Menu state");
                break;
            case GameState.Playing:
                Console.WriteLine("Game started!");
                break;
            case GameState.Pause:
                Console.WriteLine("Game paused");
                break;
            case GameState.GameOver:
                Console.WriteLine("Game over");
                break;            
        }
    }

    void DisplayMainMenu()
    {
        throw new NotImplementedException();
    }

    void InitilizeNewGame()
    {
        player = CreateNewPlayerCharacter();
    }

    void LoadGame()
    {
        throw new NotImplementedException();
    }

    Player CreateNewPlayerCharacter()
    {
        string playerName = "";
        Console.WriteLine("How is your hero called?");
        
        do
        {
            playerName = Console.ReadLine();
            if(string.IsNullOrEmpty(playerName))
                {
                    Console.WriteLine("Your Character needs a name.");
                }
        } while(string.IsNullOrEmpty(playerName));

        return new Player(playerName, 100);
    }    
}