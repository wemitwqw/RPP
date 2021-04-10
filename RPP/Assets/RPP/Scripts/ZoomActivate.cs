using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ZoomActivate : MonoBehaviour
{
    private Image zoomInBtn;
    private Animator zoomInAnim;

    // Start is called before the first frame update
    void Start()
    {
        zoomInBtn = gameObject.GetComponent<Image>();
        zoomInAnim = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!GameObject.FindWithTag("Document"))
        {
            zoomInBtn.enabled = false;
            zoomInAnim.enabled = false;
            //btn.gameObject.SetActive(false);
        }

        else
        {
            //btn.gameObject.SetActive(true);
            zoomInBtn.enabled = true;
            zoomInAnim.enabled = true;
        }


    }
}
