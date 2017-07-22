using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Strings : MonoBehaviour
{
    
    
    void Start (){
    
    }
    
    void Update (){
    
    }

    public static string RandomListString ( List<string> stringList)
    {
    	return stringList[Random.Range(0, stringList.Count)];
    }

    public static List<string> SplitComma(string inputStr)
    {
        return new List<string>(inputStr.Split(",".ToCharArray()));
    }

    public static string ColorPosNeg ( float number  ){
    	string returnString = (""+number+"");
    	if(number > 0)
    	{
    		//green
    		returnString = Green("+"+returnString+"");
    	}
    	else if (number < 0)
    	{
    		//red
    		returnString = Red(""+returnString+"");
    	}
    	else
    	{
    		returnString = Yellow(""+returnString+"");
    	}
    	return returnString;
    }
    
    //public static string ColorScale ( float number  ){
    //	string returnString = (""+number+"");
    //	float calc;
    //	float division = 3;
    //	
    //	if(number > 0) //Positive
    //	{
    //		calc = (1-(1/division)) + ((number/100)/division);
    //		
    //		returnString = ("<color=#" + ColorMath.ColorToHex(ColorUI.goodBadGradient.Evaluate(calc)) + ">+" + Bold(number.ToString()) + "</color>");
    //	}
    //	else if (number < 0) //Negative
    //	{
    //		
    //		calc = (0+(1/division)) + ((number/100)/division);
    //		
    //		returnString = ("<color=#" + ColorMath.ColorToHex(ColorUI.goodBadGradient.Evaluate(calc)) + ">" + Bold(number.ToString()) + "</color>");
    //	}
    //	else
    //	{
    //		returnString = Yellow("+"+number+"");
    //	}
    //	return returnString;
    //}

    //colours
    public static string Green ( string str  ){
    	return ("<color=#00FF00FF>"+Bold(str)+"</color>");
    }

    public static string Red ( string str  ){
        //Debug.Log(ColorUI.GrabColor(0.0f));
        //return ("<color=red>"+Bold(str)+"</color>");
        //Debug.Log("<color=#"+Hex.RGBToHex(ColorUI.goodBadGradient.Evaluate(0.0ff))+">"+Bold(str)+"</color>");
        //return ("<color=#"+ColorMath.ColorToHex(ColorUI.goodBadGradient.Evaluate(0.0f))+">"+Bold(str)+"</color>");

        return ("<color=red>" + Bold(str) + "</color>");
    }
    
    public static string Yellow ( string str  ){
    	return ("<color=yellow>"+Bold(str)+"</color>");
    }

    public static string Dull ( string str  ){
    	return ("<color=#FFFFFF77>"+str+"</color>");
    }

    public static string Bold ( string str  ){
    	return ("<b>"+str+"</b>");
    }
    public static string Italics ( string str  ){
    	return ("<i>"+str+"</i>");
    }

    public static string Space (){
    	return (" ");
    }
    
    //capitalise string
    public static string Cap ( string inputString  ){
        string outputString = "";
        outputString = (inputString.Substring(0, 1).ToUpper()) + (inputString.Substring(1));
        return inputString;
    }

    public static string SmallCaps(string str)
    {
        return ("<smallcaps>" + str + "</smallcaps>");
    }

    //public static string The ( StringClass str  ){
    //	if (str.the)
    //		return ("the ");
    //	else
    //		return null;
    //}
    //
    //public static string An ( StringClass str  ){
    //	if (str.an)
    //		return ("an ");
    //	else
    //		return ("a ");
    //}

    public static string RemoveFinalChar ( string str  ){
        if(str.Length > 0)
        {
            return str.Substring(0, str.Length - 1);
        }
        else
        {
            return str;
        }
    	
    }
}