using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.IO;

public class AddText : MonoBehaviour
{
    private TextMeshPro m_textMeshPro;
    private TextContainer m_textContainer;
    public GameObject part;
    private int partNr;
    private int whichLine = 0;
    private Button btn;
    //private string[] partsTextType = new string[] { "Problem", "Goal", "Methodology" };
    private string[] problem = new string[] { "A lot of students struggle with math..."};
    private string[] goal = new string[] { "..so the aim of this research is to study different math learning apps.." };
    private string[] methodology = new string[] { "...and different polls were conducted among the students." };
    private string[][] allLines = new string[3][];
    private string label = "Example of some new" + "\n" + "text.";

    void Awake()
    {
        m_textContainer = gameObject.AddComponent<TextContainer>();
        m_textMeshPro = gameObject.AddComponent<TextMeshPro>();
    }

    private void Start()
    {
        allLines[0] = problem;
        allLines[1] = goal;
        allLines[2] = methodology;
        partNr = part.GetComponent<TypeOfPart>().ReturnIn();
        whichLine = part.GetComponent<TypeOfPart>().ReturnLine();
        /*StreamReader sr = new StreamReader("Assets/StreamingAssets/"+partsTextType[partNr] +".txt");
        for (int i = 0; i < whichLine + 1; i++)
        {
            label = sr.ReadLine();
        }*/
        //sr.Close();
        for (int i = 0; i < whichLine + 1; i++)
        {
            label = allLines[partNr][whichLine];
        }
        m_textMeshPro.font = Resources.Load<TMP_FontAsset>("Fonts & Materials/pixellocaleSDF");
        m_textMeshPro.text = label;
        m_textMeshPro.fontSize = 0.25f;
        m_textMeshPro.color = Color.black;
        m_textContainer.width = 3.5f;
        m_textMeshPro.enableAutoSizing = false;
        //m_textMeshPro.font = Resources.Load<TMP_FontAsset>("Fonts & Materials/pixellocale.ttf");
        
        //m_textMeshPro.fontSharedMaterial = Resources.Load("Fonts/pixellocale SDF Material");
    }
}
