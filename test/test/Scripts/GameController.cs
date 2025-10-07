namespace test.Scripts;

public class GameController
{
    private readonly PerformancesManager m_performancesManager = new ();
    
    public void StartGame()
    {
        m_performancesManager.OnTest();       
    }
    
    
}