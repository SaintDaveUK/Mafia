using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Data : MonoBehaviour {
    public static Transform characters;
    public static Transform cultures;
    public static Transform names;
    public static Transform provinces;
    public static Transform titles;

	// Use this for initialization
	void Awake () {
        characters = transform.Find("Characters").transform;
        cultures = transform.Find("Cultures").transform;
        names = transform.Find("Names").transform;
        provinces = transform.Find("Provinces").transform;
        titles = transform.Find("Titles").transform;
        Debug.Log("Data transforms set");
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
