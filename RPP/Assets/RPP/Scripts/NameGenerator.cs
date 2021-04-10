/*using System.Collections;
using System.Collections.Generic;
using System.Runtime.Versioning;
using UnityEngine;

public class NameGenerator : MonoBehaviour
{

    public List<string> names;
    public string[] lines;
    public string[] ManyLines;

    void Start()
    {
        TextAsset nameText = ResourceAsset.load<TextAsset>("Names");
        Manylines = nameText.text.Split();
        lines = Manylines.text.Split("\r", "\n"[0]);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnGui()
    {
       
    }
}

*/