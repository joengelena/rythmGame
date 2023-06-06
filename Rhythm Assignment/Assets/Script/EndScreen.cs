using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class EndScreen : MonoBehaviour
{
    public TMP_Text textMeshPro;
    public GameObject endCanvas;
    public GameObject scoreCanvas;
    public float accuracy;
    public GameObject spawners;

    public void EndGame()
    {
        spawners.SetActive(false);
        accuracy = ((float)PlayerSettings.Score) / ((float)PlayerSettings.Accuracy) * 100;
        accuracy = Mathf.Round(accuracy);
        scoreCanvas.SetActive(false);
        endCanvas.SetActive(true);
        textMeshPro.text = "Your Score for \r\nHit the Drums!\r\nScore: " + PlayerSettings.Score + "/" + PlayerSettings.Drum + "\r\nAccuracy: " + accuracy + "%";
    }

}
