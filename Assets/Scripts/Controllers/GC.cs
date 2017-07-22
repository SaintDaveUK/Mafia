using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>Game Controller</summary>
public class GC : MonoBehaviour {
    

    void Awake()
    {
    }
	// Use this for initialization
	void Start () {
        LoadData();

        Prefabs.Init();

        InitNames();

        Title.Init();
        Culture.Init();

        GenerateCharacters();
	}

   
	
	// Update is called once per frame
	void Update () {
		
	}

    void LoadData()
    {
        LoadNames();
    }

    void LoadNames()
    {

    }

    void GenerateCharacters()
    {
        Debug.Log("GenerateCharacters()");
        //generate bosses for every title that is in play
        foreach(Title title in Title.titles)
        {
            Debug.Log("title "+title.ToString());
            if (title.exists)
            {
                Debug.Log("title exists");
                if (title.boss == false)
                {
                    Debug.Log("title no boss");
                    title.boss = Character.Generate();
                }
            }

        }
    }

    void InitNames()
    {
        GameObject go = Instantiate(Prefabs.names);
        Names names = go.GetComponent<Names>();
        names.Init();
    }
}
