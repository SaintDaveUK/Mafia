using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Global : MonoBehaviour
{
    void Start ()
    {
    
    }
    
    void Update ()
    {
    
    }

    public static List<string> TextToStringList(TextAsset inputText)
    {
        return new List<string>(SplitNewLine(inputText.text));

    }

    public static List<string> SplitNewLine(string inputStr)
    {
        return new List<string>(inputStr.Split("\n".ToCharArray()));
    }

    public static List<string> SplitComma(string inputStr)
    {
        return new List<string>(inputStr.Split(",".ToCharArray()));
    }
    
    public static bool GameObjectInArray (GameObject obj, GameObject[] array)
    {
    	
    	int i;
        for (i = 0; i < array.Length; i++) {
            if (array[i] == obj) {
                return true;
            }
        }
    	
        return false;
    }

    //GameObjectInList(specific object we are looking for, list of objects)
    public static bool GameObjectInList(GameObject obj, List<GameObject> list)
    {
    	
        int i;
        for (i = 0; i < list.Count; i++) {
            if (list[i] == obj) {
                return true;
            }
        }
        return false;
    }
    
    public static bool BinaryInList(bool boolean, List<GameObject> list)
    {
         int i;
        for (i = 0; i < list.Count; i++) {
            if (list[i] == boolean) {
                return true;
            }
        }
        return false;
    }
    
    public static void DestroyChildren ( Transform parentTransform  ){
    	DestroyChildren(parentTransform.gameObject);
    }

    public static void DestroyChildren ( GameObject parentObj  ){
    	int children = parentObj.transform.childCount;
    	for (int i = 0; i < children; i++) {
    		DestroyImmediate(parentObj.transform.GetChild(0).gameObject);
    	}
    }
    //MinMax(authority,0,100)
    static int MinMax ( int num ,  int min ,  int max  ){
    	//Debug.Log("MinMax("+num+","+min+","+max+"):int");
    	if (num<min)
    		num=min;
    	else if (num>max)
    		num=max;
    	
    	return num;
    }
    static float MinMax ( float num ,  float min ,  float max  ){
    	//Debug.Log("MinMax("+num+","+min+","+max+"):float");
    	if (num<min)
    		num=min;
    	else if (num>max)
    		num=max;
    	
    	return num;
    }
    
    static void WikiLink ( string wikiPage  ){
    	Application.OpenURL ("https://en.wikipedia.org/wiki/"+wikiPage);
    }

    // GlobalCS.ObjectInList(object, list)
    //returns true or false
    public static bool ObjectInList<T>(T obj, List<T> myList) where T : class
    {
        for (var i = 0; i < myList.Count; i++)
        {
            if (myList[i] == obj)
            {
                return true;
            }
        }
    
        return false;
    }

    /// <summary>Returns 'false' if modifier is 'false'.
    /// If modifier is 'true', returns value intact.</summary>
    public static bool Falsify(bool value, bool modifier)
    {
        if (modifier == false)
        {
            return false;
        }
        else
        {
            return value;
        }
    }
}