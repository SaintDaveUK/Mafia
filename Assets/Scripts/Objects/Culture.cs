using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Culture : MonoBehaviour {

    public string adjective; //"English"
    public Color color;
    public List<Culture> relatedCultures = new List<Culture>();

    //global
    public static List<Culture> cultures = new List<Culture>();


    // Use this for initialization
    void Start ()
    {
        transform.parent = Data.cultures;

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    static public Culture GetRandomCulture()
    {
        return cultures[Random.Range(0,cultures.Count)];
    }

    void Awake()
    {
        cultures.Add(this);
    }

    static public void Init()
    {
        //Culture[] newCultures = FindObjectsOfType(typeof(Culture)) as Culture[];
        //foreach (Culture culture in newCultures)
        //{
        //    cultures.Add(culture);
        //}
    }
    
}
