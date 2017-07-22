using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class Names : MonoBehaviour {


    ///<summary>A list of every NamesList in the game.</summary>
    static public List<NamesList> namesLists = new List<NamesList>();

    

    string coroutineWWW;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Init()
    {
        string namesPath = Application.streamingAssetsPath + "/Names";

        DirectoryInfo dir = new DirectoryInfo(namesPath);
        
        FileInfo[] files = dir.GetFiles("*.txt", SearchOption.AllDirectories);

        foreach (FileInfo file in files)
        {
            

            StartCoroutine(ImportTextStreamingAsset(file));

            //Debug.Log("<Color=red>" + www.text + "</color>");
        }
    }

    public static NamesList GetNamesList(string str)
    {
        foreach (NamesList nameList in namesLists)
        {
            if (nameList.name == (str+".txt"))
            {
                return nameList;
            }
        }
        Debug.LogWarning("NameList " + str + " not found.");
        return null;
    }


        //NamesList LoadNames(string type)
        //{
        //    //male
        //    string filepath = ("file://" + Application.streamingAssetsPath + "/Names/" + name + "_" + type + ".txt");
        //
        //
        //    Debug.Log(filepath);
        //
        //    GameObject go = Instantiate(Prefabs.namesList);
        //    go.name = (name + "_" + type);
        //    StartCoroutine(ImportTextStreamingAsset(filepath, go.GetComponent<NamesList>()));//this has to be run here because its a generator :(
        //    //Debug.Log("<color=red>" + importText + "</color>");
        //    //go.GetComponent<NamesList>().Init(importText);
        //    return go.GetComponent<NamesList>();
        //}

        IEnumerator ImportTextStreamingAsset(FileInfo file)
    {
        GameObject go = Instantiate(Prefabs.namesList);
        go.name = file.Name;
        Debug.Log("file://" + file.FullName);
        WWW www = new WWW("file://" + file.FullName);
        //yield return www;
        yield return www;

        //Debug.Log("<color=green>"+www.text+"</color>");

        go.GetComponent<NamesList>().Init(www.text);
    }
}
