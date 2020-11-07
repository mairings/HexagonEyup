using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class sceneOpen : MonoBehaviour
{


    private void Start()
    {
    }

    public void sahneKapa()
    {
       // editorPanel.SetActive(false);
       SceneManager.LoadScene(0);
        
    }
    public void sahneAc()
    {
    //    editorPanel.SetActive(true);
        SceneManager.LoadScene(1);

    }


}
