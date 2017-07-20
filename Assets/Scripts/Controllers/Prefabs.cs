using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prefabs : MonoBehaviour {

    public static GameObject character;
    public static GameObject province;
    public static GameObject title;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    static public void Init()
    {
        character = Resources.Load("EmptyPrefabs/#Character") as GameObject;
        province = Resources.Load("EmptyPrefabs/#Province") as GameObject;
        title = Resources.Load("EmptyPrefabs/#Title") as GameObject;

        Debug.Log("Empty prefabs loaded.");
    }
}
