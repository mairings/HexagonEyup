using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class scoreUIControls : MonoBehaviour
{
    public Text scoreUI, highScoreUI, movesUI;
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.DeleteKey("score");
        PlayerPrefs.DeleteKey("highScore");
        PlayerPrefs.DeleteKey("moves");
    }

  
}
