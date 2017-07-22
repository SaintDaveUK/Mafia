using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class NamesList : MonoBehaviour
{
    public static List<string> inputList = new List<string>();
    public static List<NamesList> namesLists = new List<NamesList>();
    public  List<Name> list = new List<Name>();

    public static List<int> weights = new List<int>();

    public void Init(string input)
    {
        weights.Clear();
        list.Clear();

        if (input == null)
        {
            input = "NO,NAME,0\nNO,NAME,1";
        }

        inputList = Global.SplitNewLine(input);

        //intantiate
        for (int i = 0; i < inputList.Count; i++)
        {
            //Debug.Log(inputList);
            //Debug.Log("inputList["+i+"] "+inputList[i]);
            GameObject cloneName;
            cloneName = Instantiate(Prefabs.nameName);

            cloneName.transform.SetParent(gameObject.transform);
            cloneName.GetComponent<Name>().NameSplit(inputList[i]);

            list.Add(cloneName.GetComponent<Name>());
            weights.Add(list[i].weight);
        }

        //clear 
        input = "";
    }
    public Name GetRandomName()
    {
        int randomSample = Randomize.Sample(weights);
        return list[randomSample];
    }

    void Update()
    {

    }

    void Awake()
    {
        //Debug.Log("NameList "+ name +" Awake()");
        //parent up
        transform.parent = Data.names;
        namesLists.Add(this);
    }
}