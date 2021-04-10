using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PersonBehaviour : MonoBehaviour
{
    public Transform destination;
    public GameObject paper;
    private bool spawned = false;
    public Transform destinationToDestroy;

    // Start is called before the first frame update
    void Start()
    {
        //destinationToDestroy = gameObject.transform;
        //zoomInBtn.enabled = true;
    }

    void Update()
    {
        //transform.position = Vector3.Lerp(transform.position, destination.position, Time.deltaTime*0.8f);
        if (transform.position.x > -154 && !spawned)
        {
            spawned = true;
            Instantiate(paper, new Vector3(destination.position.x + 40, destination.position.y - 75, 0), Quaternion.identity);
        }

        else if (spawned && !GameObject.FindWithTag("Document"))
        {
            transform.position = Vector3.Lerp(transform.position, destinationToDestroy.position, Time.deltaTime * 0.85f);
            if (transform.position.x < -279)
            {
                Destroy(GameObject.FindWithTag("Person"));
            }
        }
        else
        {
            transform.position = Vector3.Lerp(transform.position, destination.position, Time.deltaTime * 0.8f);
        }
        
    }
}
