using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class LoadAssets : MonoBehaviour
{
    // Start is called before the first frame update
    void Awake()
    {
        StartCoroutine(loadStreamingAsset("Problem.txt"));
        StartCoroutine(loadStreamingAsset("Goal.txt"));
        StartCoroutine(loadStreamingAsset("Methodology.txt"));
    }

    IEnumerator loadStreamingAsset(string myFileURI)
    {
        UnityWebRequest www = UnityWebRequest.Get(myFileURI);
        yield return www.SendWebRequest();

        if (!www.isNetworkError && !www.isHttpError)
        {
            // Get text content like this:
            Debug.Log(www.downloadHandler.text);
        }
    }
}
