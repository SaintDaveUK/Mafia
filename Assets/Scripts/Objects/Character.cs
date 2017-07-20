using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour {


    public List<Name> firstNames = new List<Name>();
    public List<Name> lastNames = new List<Name>();

    public Culture culture;

    public bool isFemale;

    // Use this for initialization
    void Start () {
        transform.parent = Data.characters;
    }
	
	// Update is called once per frame
	void Update () {
		
	}





    ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    ///////////////// NAMES
    ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


    /// <summary>Returns the full formal name, e.g. "Henry Arthur Smith-Jones" </summary>
    public string GetName()
    {
        return ( GetFirstName() + " " + GetLastName() );
    }

    /// <summary>Returns all last names, as a single entity e.g. "Henry Arthur" </summary>
    public string GetFirstName()
    {
        string returnString = "";
        foreach (Name firstName in firstNames)
        {
            returnString += firstName.GetString();
        }
        return returnString;
    }

    /// <summary>Returns all last names, as a single entity e.g. "Smith-Jones" </summary>
    public string GetLastName()
    {
        string returnString = "";
        foreach(Name lastName in lastNames)
        {
            returnString += lastName.GetString();
        }
        return returnString;
    }

    ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    ///////////////// GENERATION
    ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

    public static Character Generate()
    {
        //put a copy of the character prefab in the game world
        GameObject go = Instantiate(Prefabs.character);
        Character newChar = go.GetComponent<Character>();

        //run initialisations on it
        newChar.Init();

        //send it back to the previous function
        return newChar;
    }

    public void Init()
    {
        culture = Culture.GetRandomCulture();
        // Generate Culture
        // Generate Names
    }

    void Awake()
    {
    }



}
