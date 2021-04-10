using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ChooseIdeal : MonoBehaviour
{
    public GameObject partsText;
    private GameObject chosenPart;
    private GameObject chosenText;
    public Transform whereTo;
    private void Awake()
    {
        gameObject.GetComponent<Button>().onClick.AddListener(CopyPart);
    }
    public void CopyPart()
    {
        Destroy(GameObject.FindGameObjectWithTag("InIdeal"));
        Destroy(GameObject.FindGameObjectWithTag("InIdealText"));
        if (gameObject.tag != "InIdeal")
        {
            chosenPart = Instantiate(gameObject, new Vector3(whereTo.position.x - 575, whereTo.position.y - 242, whereTo.position.z), Quaternion.identity);
            chosenPart.GetComponent<Image>().color = new Color(255, 255, 255, 0);
            chosenPart.transform.localScale = new Vector3(1.5f, 1f, 1);
            chosenPart.GetComponent<TypeOfPart>().changeIn(gameObject.GetComponent<TypeOfPart>().ReturnPos());
            chosenPart.tag = "InIdeal";
            chosenPart.transform.SetParent(GameObject.FindGameObjectWithTag("Control").transform, false);
            chosenText = Instantiate(partsText, new Vector3(whereTo.position.x - 477, whereTo.position.y - 268, whereTo.position.z), Quaternion.identity);
            chosenText.tag = "InIdealText";
            chosenText.transform.SetParent(GameObject.FindGameObjectWithTag("Control").transform, false);
            whereTo.GetComponent<Image>().enabled = true;
            GameObject.FindGameObjectWithTag("CompareTextIdeal").GetComponent<TextMeshProUGUI>().text = chosenText.GetComponent<TextMeshPro>().text;
        } else
        {
            whereTo.GetComponent<Image>().enabled = false;
            GameObject.FindGameObjectWithTag("CompareTextIdeal").GetComponent<TextMeshProUGUI>().text = "";
        }
    }
}
