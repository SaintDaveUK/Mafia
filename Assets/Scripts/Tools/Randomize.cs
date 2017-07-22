using UnityEngine;
using System.Collections;
using System.Collections.Generic;

///<summary>A collection of custom Random methods.</summary>
public class Randomize : MonoBehaviour {
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    ///<summary>Returns a random weighted by an AnimationCurve.</summary>
    public static float CurveWeightedRandom(AnimationCurve curve)
    {
        return curve.Evaluate(Random.value);
    }

    ///<summary>Returns a random weighted by an AnimationCurve, and scaled by a max number.</summary>
    public static int CurveWeightedRandom(AnimationCurve curve, int max)
    {
        return Mathf.RoundToInt((curve.Evaluate(Random.value)* max));
    }

    public static float Rnd()
    {
        return Random.value;
    }

    public static int Sum(List<int> floats)
    {
        int result = 0;
        for (int i = 0; i < floats.Count; i++)
        {
            result += floats[i];
        }
        //Debug.Log("Sum Result:"+result);
        return result;
    }
    public static int Sample(List<int> distro)
    {
        int total = Sum(distro);
        return Sample(distro, total);
    }

    //	Choose an integer at random, according to the supplied distribution.
    public static int Sample(List<int> distro, int total)
    {

        int randVal = (int)(total * Rnd());

        //Debug.Log("Random value: "+randVal);
        //Debug.Log("distro[0]: "+distro[0]);
        //Debug.Log("distro.Count: "+distro.Count);

        for (int i = 0; i < distro.Count; i++)
        {
            if (randVal < distro[i])
            {
                //Debug.Log("Distro "+i+": "+distro[i]+"\nTrait number:"+i);
                return i;
            }

            randVal -= distro[i];
        }

        return distro.Count - 1;
    }
}
