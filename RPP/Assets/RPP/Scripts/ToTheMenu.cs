using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ToTheMenu : MonoBehaviour
{

    public void PlayMenu()
    {
        Loader.Load(Loader.Scene.Menu);
    }
     
}
