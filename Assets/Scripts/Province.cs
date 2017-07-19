using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Province : MonoBehaviour {
    ///<summary>The "county" Title associated with this province.</summary>
    public Title title;

    ///<summary>The predominant Culture of the province.</summary>
    public Culture culture;

    // Use this for initialization
    void Start () {
        //color the province as the culture
        if(culture)
        {
            foreach (Transform child in transform)
                child.GetComponent<Renderer>().material.color = culture.color;
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
