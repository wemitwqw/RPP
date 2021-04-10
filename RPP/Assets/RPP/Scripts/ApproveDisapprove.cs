using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ApproveDisapprove : MonoBehaviour
{
    public Button approve;
    public Button disapprove;
    public Button startButton;
    public Button btn;
    public Camera main;



    // Start is called before the first frame update
    void Awake()
    {
        btn.gameObject.SetActive(false);
        disapprove.gameObject.SetActive(false);
        approve.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (startButton.IsDestroyed())
        {
            if (!GameObject.FindWithTag("Document") && !GameObject.FindWithTag("Person") && main.gameObject.activeInHierarchy)
            {
                btn.gameObject.SetActive(true);
                disapprove.gameObject.SetActive(false);
                approve.gameObject.SetActive(false);
            }
            else if (!GameObject.FindWithTag("Document") && !GameObject.FindWithTag("Person") && !main.gameObject.activeInHierarchy)
            {
                btn.gameObject.SetActive(false);
                disapprove.gameObject.SetActive(false);
                approve.gameObject.SetActive(false);
            }
            else if (!GameObject.FindWithTag("Document") && GameObject.FindWithTag("Person"))
            {
                btn.gameObject.SetActive(false);
                disapprove.gameObject.SetActive(false);
                approve.gameObject.SetActive(false);
            }

            else
            {
                btn.gameObject.SetActive(false);
                disapprove.gameObject.SetActive(true);
                approve.gameObject.SetActive(true);
            }
        }
    }
}
