namespace test.Scripts;

// class used to check modules performances and potential unit tests
public class PerformancesManager
{
    private readonly PerformancesSort m_performanceSort;
    private readonly PerformancesStrings m_PerformanceStrings;

    public PerformancesManager()
    {
        Console.WriteLine($"Constructor for PerformancesManager");
        
        m_performanceSort = new PerformancesSort();
        m_PerformanceStrings = new PerformancesStrings();
        
    }
    
    public void OnTest()
    {
        m_performanceSort.CheckPerfSort();
        m_PerformanceStrings.CheckPerfStrings();
    }
}