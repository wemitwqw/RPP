using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class AddText : MonoBehaviour
{
    private TextMeshPro m_textMeshPro;
    private TextContainer m_textContainer;
    private Button btn;

    private string label = "Example of some new text.";

    void Awake()
    {
        m_textMeshPro = gameObject.AddComponent<TextMeshPro>();
        m_textContainer = GetComponent<TextContainer>();
    }

    private void Start()
    {
        m_textMeshPro.font = Resources.Load<TMP_FontAsset>("Fonts & Materials/pixellocale SDF");
        m_textMeshPro.text = label;
        m_textMeshPro.fontSize = 50;
        m_textMeshPro.color = Color.black;
        m_textContainer.width = 8;
        m_textMeshPro.enableAutoSizing = true;
        //m_textMeshPro.font = Resources.Load<TMP_FontAsset>("Fonts & Materials/pixellocale.ttf");
        
        //m_textMeshPro.fontSharedMaterial = Resources.Load("Fonts/pixellocale SDF Material");
    }
}
