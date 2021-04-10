using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomType : MonoBehaviour
{
    private GameObject[] allParts;
    private int wrong = -1;
    void Start()
    {
        allParts = GameObject.FindGameObjectsWithTag("Original");
        for (int i = 0; i < allParts.Length; i++)
        {
            //Debug.Log(allParts[i].name);
            int partsPosition = allParts[i].GetComponent<TypeOfPart>().ReturnPos();
            int coinFlip = Random.Range(0, 11);
            if(coinFlip > 6)
            {
                while(wrong == -1 || wrong == partsPosition)
                {
                    wrong = Random.Range(0, allParts.Length);
                }
                allParts[i].GetComponent<TypeOfPart>().changeIn(wrong);
                for(int j = i; j < allParts.Length; j++)
                {
                    allParts[j].GetComponent<TypeOfPart>().changeIn(allParts[j].GetComponent<TypeOfPart>().ReturnPos());
                }
                allParts[wrong].GetComponent<TypeOfPart>().changeIn(partsPosition);
                //Debug.Log(allParts[i].GetComponent<TypeOfPart>().ReturnIn());
                break;
            } else
            {
                allParts[i].GetComponent<TypeOfPart>().changeIn(partsPosition);
                //Debug.Log(allParts[i].GetComponent<TypeOfPart>().ReturnIn());
            }
        }
    }
}

