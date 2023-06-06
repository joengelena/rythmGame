using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;

public class ScoreCounting : MonoBehaviour
{
    public TMP_Text textMeshPro;
    // Start is called before the first frame update
    void Start()
    {
        textMeshPro.text = "Score: 0";
    }

    // Update is called once per frame
    void Update()
    {

        textMeshPro.text = "Score: " + PlayerSettings.Score; 
    }
}
