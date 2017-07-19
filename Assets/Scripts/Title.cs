﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Title : MonoBehaviour {
    ///<summary>The proper noun for this Title (e.g. France)</summary>
    public string noun;
    ///<summary>The adjective for this Title (e.g. French). </summary>
    public string adj;
    ///<summary>The Character who rules the Title.</summary>
    public Character boss;

    ///<summary>Returns the Proper Noun if there is one, else it returns the text "NULL".</summary>
    public string GetNoun()
    {
        if(string.IsNullOrEmpty(noun))
        {
            return noun;
        }
        else
        {
            return "NULL";
        }
    }

    ///<summary>Returns the Adjective if there is one, else it returns the Proper Noun.</summary>
    public string GetAdj()
    {
        if(string.IsNullOrEmpty(adj))
        {
            return adj;
        }
        else
        {
            return GetNoun();
        }
    }

}
