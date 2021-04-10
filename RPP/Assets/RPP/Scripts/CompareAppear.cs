using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CompareAppear : MonoBehaviour
{
    // Update is called once per frame
    public GameObject textToChange;
    private string textInside;

    void Start()
    {
        textInside = textToChange.GetComponent<TextMeshProUGUI>().text;
    }

    void Update()
    {
        if (GameObject.FindGameObjectWithTag("InIdeal") && gameObject.name == "Ideal")
        {
            gameObject.GetComponent<Image>().enabled = true;
            Debug.Log("Test1");
        } else if (GameObject.FindGameObjectWithTag("InNotIdeal") && gameObject.name == "NotIdeal")
        {
            gameObject.GetComponent<Image>().enabled = true;
            Debug.Log("Test2");
        } else
        {
            textInside = "";
            gameObject.GetComponent<Image>().enabled = false;
            Debug.Log("Test3");
        }

    }
}
