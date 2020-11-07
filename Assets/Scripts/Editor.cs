using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Editor : MonoBehaviour
{
    public Dropdown colorDropD, rowDropD, columnDropD;
    Dropdown ncolorDropD, nrowDropD, ncolumnDropD;
    int renkSayisi, rowSay, columnSay;

    // Start is called before the first frame update
    void Start()
    {
        ncolorDropD = colorDropD;
        nrowDropD = rowDropD;
        ncolumnDropD = columnDropD; 
        colorChange();
        rowChange();
        columnChange();

    }

    public void colorChange()
    {
        renkSayisi = ncolorDropD.value;

        switch (renkSayisi)
        {
            case 0:
                PlayerPrefs.SetInt("renkSayisi", 5);
                break;
            case 1:
                PlayerPrefs.SetInt("renkSayisi", 6);
                break;


        }
    }

    public void rowChange()
    {
        rowSay = nrowDropD.value;

        switch (rowSay)
        {
            case 0:
                PlayerPrefs.SetInt("rowSayisi", 3);
                break;
            case 1:
                PlayerPrefs.SetInt("rowSayisi", 4);
                break;
            case 2:
                PlayerPrefs.SetInt("rowSayisi", 5);
                break;
            case 3:
                PlayerPrefs.SetInt("rowSayisi", 6);
                break;
            case 4:
                PlayerPrefs.SetInt("rowSayisi", 7);
                break;
            case 5:
                PlayerPrefs.SetInt("rowSayisi", 8);
                break;
            case 6:
                PlayerPrefs.SetInt("rowSayisi", 9);
                break;
            case 7:
                PlayerPrefs.SetInt("rowSayisi", 10);
                break;
        }
    }

    public void columnChange()
    {
        columnSay = ncolumnDropD.value;

        switch (columnSay)
        {
            case 0:
                PlayerPrefs.SetInt("columnSayisi", 3);
                break;
            case 1:
                PlayerPrefs.SetInt("columnSayisi", 4);
                break;
            case 2:
                PlayerPrefs.SetInt("columnSayisi", 5);
                break;
            case 3:
                PlayerPrefs.SetInt("columnSayisi", 6);
                break;
            case 4:
                PlayerPrefs.SetInt("columnSayisi", 7);
                break;
            case 5:
                PlayerPrefs.SetInt("columnSayisi", 8);
                break;
            case 6:
                PlayerPrefs.SetInt("columnSayisi", 9);
                break;
            case 7:
                PlayerPrefs.SetInt("columnSayisi", 10);
                break;
        }
    }


    

}
