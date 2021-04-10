using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TypeOfPart : MonoBehaviour
{
    private int positionOnDoc;
    private int whatIsInside = 0;
    private int whichLine = 0;
    private string[] parts = new string[] { "First", "Second", "Third" };
    private GameObject[] allParts;
   
    void Awake()
    {
        for(int i = 0; i < parts.Length; i++)
        {
            if(gameObject.name.Equals(parts[i]) || gameObject.name.Equals(parts[i] + "(Clone)"))
            {
                /*Debug.Log(i);
                Debug.Log(gameObject.name);*/
                positionOnDoc = i;
                //Debug.Log(positionOnDoc);
                break;
            }
        }
    }

    private int[] both = new int[]{0, 0};

    public int ReturnPos()
    {
        //Debug.Log(positionOnDoc);
        return positionOnDoc;
    }

    public int ReturnIn()
    {
        return whatIsInside;
    }

    public int ReturnLine()
    {
        return whichLine;
    }

    public int[] ReturnBoth()
    {
        both[0] = positionOnDoc;
        both[1] = whatIsInside;
        return both;
    }

    public void changeIn(int newIn)
    {
        //positionOnDoc = newPos;
        whatIsInside = newIn;
    }
}
