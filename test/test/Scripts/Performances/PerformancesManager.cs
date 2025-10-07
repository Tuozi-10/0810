namespace test.Scripts;

// class used to check modules performances and potential unit tests
public class PerformancesManager
{
    private PerfsSort m_perfSort;

    public PerformancesManager()
    {
        Console.WriteLine($"Constructor for PerformancesManager");
        m_perfSort = new PerfsSort();
    }
    
    public void OnTest()
    {
        m_perfSort.CheckPerfSort();
    }
}