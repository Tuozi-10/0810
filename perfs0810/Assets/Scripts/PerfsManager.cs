using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.Profiling;

public class PerfsManager : MonoBehaviour
{

    void Start()
    {
        StartCoroutine(DoChecks());
    }

    private IEnumerator DoChecks()
    {
        yield return new WaitForSeconds(2f);
        CheckTruc();
        CheckTruc2();
        CheckTruc3();
        CheckTruc4();
        CheckTruc5();
        CheckTruc6();
    }

    private void CheckTruc()
    {
        Profiler.BeginSample("test 1");
        string t = "";

        for (int i = 0; i < 50000; i++)
        {
            t += i.ToString();
        }

        Profiler.EndSample();
    }

    private void CheckTruc2()
    {
        Profiler.BeginSample("test 2");
        StringBuilder stringBuilder = new StringBuilder();

        for (int i = 0; i < 50000; i++)
        {
            stringBuilder.Append(i);
        }

        Profiler.EndSample();
    }

    private void CheckTruc3()
    {
        Profiler.BeginSample("test 3");
        string t = "";

        for (int i = 0; i < 1; i++)
        {
            t += i.ToString();
        }

        Profiler.EndSample();
    }

    private void CheckTruc4()
    {
        Profiler.BeginSample("test 4");
        StringBuilder stringBuilder = new StringBuilder();

        for (int i = 0; i < 1; i++)
        {
            stringBuilder.Append(i);
        }

        Profiler.EndSample();
    }

    private List<int> GenerateRandomList(int count)
    {       
        var randomList = new List<int>();
        
        for (int i = 0; i < count; i++)
        {
            int value = Random.Range(0,int.MaxValue);
            randomList.Add(value);
        }

        return randomList;
    }
    
    private void CheckTruc5()
    {
        Profiler.BeginSample("test 5");
        var list = GenerateRandomList(1);
        list.Sort();
        Profiler.EndSample();
    }
    
    private void CheckTruc6()
    {
        Profiler.BeginSample("test 6");
        
        var list = GenerateRandomList(1);
        var list2 = list.OrderBy(x=>x);
        
        Profiler.EndSample();
    }
}
