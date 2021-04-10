using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CompareChosen : MonoBehaviour
{
    //private GameObject ideal;
    //private GameObject notIdeal;
    private int[] ideal = new int[] { 0, 0 };
    private int[] notIdeal = new int[] { 0, 0 };
    public GameObject results;
    void Update()
    {
        if(GameObject.FindGameObjectWithTag("InIdeal") && GameObject.FindGameObjectWithTag("InNotIdeal"))
        {
            //Debug.Log(GameObject.FindGameObjectWithTag("InIdeal").GetComponent<TypeOfPart>().ReturnPos());
            ideal[0] = GameObject.FindGameObjectWithTag("InIdeal").GetComponent<TypeOfPart>().ReturnPos();
            //Debug.Log(ideal[0]);
            ideal[1] = GameObject.FindGameObjectWithTag("InIdeal").GetComponent<TypeOfPart>().ReturnIn();
            //Debug.Log(ideal[1]);
            notIdeal[0] = GameObject.FindGameObjectWithTag("InNotIdeal").GetComponent<TypeOfPart>().ReturnPos();
            //Debug.Log(notIdeal[0]);
            notIdeal[1] = GameObject.FindGameObjectWithTag("InNotIdeal").GetComponent<TypeOfPart>().ReturnIn();
            //Debug.Log(notIdeal[1]);
            if (ideal[0] == notIdeal[0])
            {
                if(ideal[1] == notIdeal[1])
                {
                    /*Debug.Log(notIdeal[1]);
                    Debug.Log(ideal[1]);
                    Debug.Log(notIdeal[0]);
                    Debug.Log(ideal[0]);
                    Debug.Log("Kõik korras");*/
                    results.GetComponent<TextMeshProUGUI>().text = "OK";
                    results.GetComponent<TextMeshProUGUI>().color = new Color(0, 45, 0);
                } else
                {
                    /*Debug.Log(notIdeal[1]);
                    Debug.Log(ideal[1]);
                    Debug.Log("Vale!");*/
                    results.GetComponent<TextMeshProUGUI>().text = "WRONG";
                    results.GetComponent<TextMeshProUGUI>().color = new Color(45, 0, 0);
                }
            } else
            {
                /*Debug.Log(notIdeal[0]);
                Debug.Log(ideal[0]);
                Debug.Log("Pole probleemi");*/
                results.GetComponent<TextMeshProUGUI>().text = "";
                results.GetComponent<TextMeshProUGUI>().color = new Color(0, 45, 0);
            }
        } else
        {
            results.GetComponent<TextMeshProUGUI>().text = "";
        }
    }
}
