using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NextMan : MonoBehaviour
{
    public Transform spawnPoint;
    public GameObject person;
    public Button btn;
    public Button startButton;
    public Button approve;
    public Button disapprove;
    public static bool personOnScreen = false;


    private void Start()
    {
        startButton.onClick.AddListener(DestroyBtn);
        btn.onClick.AddListener(CreateMan);
        approve.onClick.AddListener(CreateMan);
        disapprove.onClick.AddListener(CreateMan);
    }
    void DestroyBtn()
    {
        CreateMan();
        Destroy(startButton.gameObject);        
    }

    // Start is called before the first frame update
    public void CreateMan()
    {
        if (!personOnScreen)
        {
            Instantiate(person, new Vector3(spawnPoint.position.x, spawnPoint.position.y, spawnPoint.position.z), Quaternion.identity);
            personOnScreen = true;
        }
        else
        {
            DestroyMan();
        }
    }
    void DestroyMan()
    {
        Destroy(GameObject.FindWithTag("Document"));
        personOnScreen = false;
    }
}
