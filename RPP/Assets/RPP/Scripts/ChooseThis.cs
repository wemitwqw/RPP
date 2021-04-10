using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ChooseThis : MonoBehaviour
{
    public GameObject partsText;
    private GameObject chosenPart;
    private GameObject chosenText;
    //private GameObject textToChange;
    public Transform whereTo;
    private void Awake()
    {
        gameObject.GetComponent<Button>().onClick.AddListener(CopyPart);
    }
    public void CopyPart()
    {
        Destroy(GameObject.FindGameObjectWithTag("InNotIdeal"));
        Destroy(GameObject.FindGameObjectWithTag("InNotIdealText"));
        if (gameObject.tag != "InNotIdeal")
        {
            chosenPart = Instantiate(gameObject, new Vector3(whereTo.position.x - 140, whereTo.position.y +93, whereTo.position.z), Quaternion.identity);
            chosenPart.GetComponent<Image>().color = new Color(200, 200, 200, 0);
            chosenPart.transform.localScale = new Vector3(1.5f, 1f, 1);
            chosenPart.GetComponent<TypeOfPart>().changeIn(gameObject.GetComponent<TypeOfPart>().ReturnIn());
            Debug.Log(gameObject.GetComponent<TypeOfPart>().ReturnIn());
            Debug.Log(chosenPart.GetComponent<TypeOfPart>().ReturnIn());
            chosenPart.tag = "InNotIdeal";
            chosenPart.transform.SetParent(GameObject.FindGameObjectWithTag("Control").transform, false);
            /*chosenText = Instantiate(partsText, new Vector3(whereTo.position.x, whereTo.position.y, whereTo.position.z), Quaternion.identity);
            chosenText.tag = "InNotIdealText";
            chosenText.transform.SetParent(GameObject.FindGameObjectWithTag("Control").transform, false);*/
            whereTo.GetComponentInChildren<Image>().enabled = true;
            GameObject.FindGameObjectWithTag("Respawn").GetComponent<Image>().enabled = true;
            GameObject.FindGameObjectWithTag("CompareText").GetComponent<TextMeshProUGUI>().text = partsText.GetComponent<TextMeshPro>().text;
        }
        else
        {
            GameObject.FindGameObjectWithTag("Respawn").GetComponent<Image>().enabled = false;
            GameObject.FindGameObjectWithTag("CompareText").GetComponent<TextMeshProUGUI>().text = "";

        }
    }
}
