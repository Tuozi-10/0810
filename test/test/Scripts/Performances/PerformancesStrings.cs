using System.Text;

namespace test.Scripts;

// TODO ADD WATCH

public class PerformancesStrings
{
    public void CheckPerfStrings()
    {
        CheckPerfsLotOfStrings();
        CheckPerfsStringBuilder();
    }

    private void CheckPerfsLotOfStrings()
    {
        string myString = "";

        for (int i = 0; i < 100; i++)
        {
            myString += i.ToString();
        }
    }
    
    private void CheckPerfsStringBuilder()
    {
        StringBuilder stringBuilder = new StringBuilder();
        
        for (int i = 0; i < 100; i++)
        {
            stringBuilder.Append(i);
        }

        string myString = stringBuilder.ToString();
    }

    private void CheckPerfsPrimeNumbersList()
    {
        // TODO ADD ALL PRIME NUMBERS IN A LIST, FROM 1 TO 153248
    }
    
}