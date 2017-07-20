using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>This contains the list of related names and other details.</summary>
public class Name : MonoBehaviour {
    
    public List<string> names = new List<string>();
    public int weight = 10;


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
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
