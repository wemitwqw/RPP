using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;

public class GameTimer : MonoBehaviour
{

    public float timeLeft = 75.0f;
    private float count = 0f;
    private TextMeshPro countdownText;
    public Button startButton;

    void Awake()
    {
        count = timeLeft;
    }

    void Start()
    {
        countdownText = gameObject.AddComponent<TextMeshPro>();
        countdownText.font = Resources.Load<TMP_FontAsset>("Fonts & Materials/pixellocaleSDF");
        countdownText.fontSize = 4;
        //countdownText.alignment = AlignmentTypes.Right;
        countdownText.characterSpacing = 15;
        countdownText.color = Color.green;
        countdownText.enableAutoSizing = false;
    }
     
    void Update()
    {
        if (startButton.IsDestroyed())
        {
            count -= 1 * Time.deltaTime;
            //Debug.Log(count);
            if (count <= 0)
            {

                GameOver();
            }
            else
            {
                countdownText.text = count.ToString("00.00");
            }
        }
        else
        {
            countdownText.text = count.ToString("00.00");
        }
    }

    public void GameOver()
    {
        count = 00.00f;
        //Debug.Log("Game Over!");
        Loader.Load(Loader.Scene.GameOver);
    }
}

