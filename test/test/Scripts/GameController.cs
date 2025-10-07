namespace test.Scripts;

public class GameController
{
    private PerformancesManager m_performancesManager = new ();
    
    public void StartGame()
    {
        m_performancesManager.OnTest();       
    }
    
    
}