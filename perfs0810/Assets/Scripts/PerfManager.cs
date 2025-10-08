using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.Profiling;


public class PerfManager : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(DoChecks());
    }

    private IEnumerator DoChecks()
    {
        yield return new WaitForSeconds(2f);
        SortCheck();
        SortCheckPetit();
        LinqCheck();
        LinqCheckPetit();
        //CheckToString();
        //CheckStringBuilder();
        //CheckToStringPetit();
        //CheckStringBuilderPetit();
    }
    
    private void CheckToString()
    {
        Profiler.BeginSample("test to string 10000 élément");
        string t = "";
        for (int i = 0; i < 10000; i++)
        {
            t += i.ToString();
        }
        Profiler.EndSample();
    }
    
    private void CheckStringBuilder()
    {
        Profiler.BeginSample("test string builder 10000 élément");
        StringBuilder stringBuilder = new StringBuilder();
        
        for (int i = 0; i < 10000; i++)
        {
            stringBuilder.Append(i);
        }

        string myString = stringBuilder.ToString();
        Profiler.EndSample();
    }
    private void CheckToStringPetit()
    {
        Profiler.BeginSample("test to string 1 élément");
        string t = "";
        t += 0.ToString();
        Profiler.EndSample();
    }
    
    private void CheckStringBuilderPetit()
    {
        Profiler.BeginSample("test string builder 1 élément");
        StringBuilder stringBuilder = new StringBuilder();
        stringBuilder.Append(0);

        string myString = stringBuilder.ToString();
        Profiler.EndSample();
    }
    
    private List<int> GenerateRandomList(int count)
    {
        var randomList = new List<int>();
        
        for (int i = 0; i < count; i++)
        {
            int value = Random.Range(0, int.MaxValue);
            randomList.Add(value);
        }

        return randomList;
    }

    private void SortCheck()
    {
        Profiler.BeginSample("test sort 100000 élément");
        var list = GenerateRandomList(100000);
        list.Sort();
        Profiler.EndSample();
    }

    private void LinqCheck()
    {
        Profiler.BeginSample("test Linq 100000 élément");
        var list = GenerateRandomList(100000);
        var list2 = list.OrderBy(x => x);
        Profiler.EndSample();
    }
    
    private void SortCheckPetit()
    {
        Profiler.BeginSample("test sort 1 élément");
        var list = GenerateRandomList(1);
        list.Sort();
        Profiler.EndSample();
    }

    private void LinqCheckPetit()
    {
        Profiler.BeginSample("test Linq 1 élément");
        var list = GenerateRandomList(1);
        var list2 = list.OrderBy(x => x);
        Profiler.EndSample();
    }
}
