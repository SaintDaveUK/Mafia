using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Name : MonoBehaviour
{
    public List<string> names = new List<string>();
    public int weight = 10;
    bool single;

    void Start()
    {


    }

    public void NameSplit(string inputStr)
    {

        gameObject.name = inputStr;
        names = Strings.SplitComma(inputStr);

        //if contains numbers, set as weight and remove!
        for (int i = 0; i < names.Count; i++)
        {
            int num;
            if (int.TryParse(names[i], out num))
            {
                weight = num;
                names.RemoveAt(i);
            }
        }
    }

    void Update()
    {

    }

    /// <summary>Returns the base name (e.g. James, not Jimmy)</summary>
    public string GetString()
    {
        return GetString(0);
    }

    /// <summary>Returns the specified nickname</summary>
    public string GetString(int nickNum)
    {
        return names[nickNum];
    }
}