using UnityEngine;
using System.Collections;

public class ColorUI : MonoBehaviour
{
    //should be placed on base UI Gameobject
    
    public static Gradient goodBadGradient;
    
    void Start ()
    {
    	ColorGradient();
    }
    
    public static Color GrabColor ( float scale  )
    {
    	return goodBadGradient.Evaluate(scale);
    }
    
    void ColorGradient ()
    {
    	//Gradient goodBadGradient;
        GradientColorKey[] gck;
        GradientAlphaKey[] gak;
    
        goodBadGradient = new Gradient();
    
        gck = new GradientColorKey[3];
        gck[0].color = Color.red;
        gck[0].time = 0.0f;
    	//gck[1].color = Color(1,1,0.5f,1); //lemon
    	gck[1].color = Color.yellow;
        gck[1].time = 0.5f;
        gck[2].color = Color.green;
        gck[2].time = 1.0f;
    	
    	// Populate the alpha  keys at relative time 0 and 1  (0 and 100%)
        gak = new GradientAlphaKey[2];
        gak[0].alpha = 1.0f;
        gak[0].time = 1.0f;
        gak[1].alpha = 1.0f;
        gak[1].time = 1.0f;
    	
    	goodBadGradient.SetKeys(gck, gak);
    	
        //Debug.Log(goodBadGradient.Evaluate(0.0ff));
        //Debug.Log(goodBadGradient.Evaluate(0.5ff));
        //Debug.Log(goodBadGradient.Evaluate(1.0ff));
    
    }
    
    void Update ()
    {
    
    }
}