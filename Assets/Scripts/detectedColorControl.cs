using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class detectedColorControl : MonoBehaviour
{
    string ust, alt, sagust, sagalt, solust, solalt, parentColor;
    public Transform efekt;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        colorNameGets();
        colorsMatch();
        print("parentColor adı"+transform.parent.gameObject.name);


    }

    void colorNameGets()
    {
        if (transform.GetChild(0).GetComponent<yonKontrol>().colorKaro != null)
        {
            sagust = transform.GetChild(0).GetComponent<yonKontrol>().colorKaro;
        }
        if (transform.GetChild(1).GetComponent<yonKontrol>().colorKaro != null)
        {
            sagalt = transform.GetChild(1).GetComponent<yonKontrol>().colorKaro;
        }
        if (transform.GetChild(2).GetComponent<yonKontrol>().colorKaro != null)
        {
            alt = transform.GetChild(2).GetComponent<yonKontrol>().colorKaro;
        }
        if (transform.GetChild(3).GetComponent<yonKontrol>().colorKaro != null)
        {
            ust = transform.GetChild(3).GetComponent<yonKontrol>().colorKaro;
        }
        if (transform.GetChild(4).GetComponent<yonKontrol>().colorKaro != null)
        {
            solust = transform.GetChild(4).GetComponent<yonKontrol>().colorKaro;
        }
        if (transform.GetChild(5).GetComponent<yonKontrol>().colorKaro != null)
        {
            solalt = transform.GetChild(5).GetComponent<yonKontrol>().colorKaro;
        }
       
    }

    void colorsMatch()
    {
        parentColor = GetComponentInParent<SpriteRenderer>().sprite.name;

        if (parentColor == ust && parentColor == sagust)
        {
            print("siliyor");

            transform.GetChild(3).GetComponent<yonKontrol>().sil = true;
            transform.GetChild(0).GetComponent<yonKontrol>().sil = true;
            efekt.GetComponent<ParticleSystem>().enableEmission = true;
            StartCoroutine(coinEffectStop());
            Destroy(transform.parent.gameObject, 0.2f);
            ScoreCalculate();

        }
        if (parentColor == alt && parentColor == sagalt)
        {
            print("siliyor");

            transform.GetChild(2).GetComponent<yonKontrol>().sil = true;
            transform.GetChild(1).GetComponent<yonKontrol>().sil = true;
            efekt.GetComponent<ParticleSystem>().enableEmission = true;
            StartCoroutine(coinEffectStop());
            Destroy(transform.parent.gameObject, 0.6f);
            ScoreCalculate();
        }

        if (parentColor == solalt && parentColor == solust)
        {
            print("siliyor");

            transform.GetChild(5).GetComponent<yonKontrol>().sil = true;
            transform.GetChild(4).GetComponent<yonKontrol>().sil = true;
            efekt.GetComponent<ParticleSystem>().enableEmission = true;
            StartCoroutine(coinEffectStop());
            Destroy(transform.parent.gameObject, 0.6f);
            ScoreCalculate();
        }
        if (parentColor == sagalt && parentColor == sagust)
        {
            print("siliyor");

            transform.GetChild(1).GetComponent<yonKontrol>().sil = true;
             transform.GetChild(0).GetComponent<yonKontrol>().sil = true;
            efekt.GetComponent<ParticleSystem>().enableEmission = true;
            StartCoroutine(coinEffectStop());
            Destroy(transform.parent.gameObject, 0.6f);
            ScoreCalculate();
        }
        if (parentColor == solust && parentColor == ust)
        {
            print("siliyor");

            transform.GetChild(4).GetComponent<yonKontrol>().sil = true;
             transform.GetChild(3).GetComponent<yonKontrol>().sil = true;
            efekt.GetComponent<ParticleSystem>().enableEmission = true;
            StartCoroutine(coinEffectStop());
            Destroy(transform.parent.gameObject, 0.6f);
            ScoreCalculate();
        }
        if (parentColor == solalt && parentColor == alt)
        {
            print("siliyor");
            efekt.GetComponent<ParticleSystem>().enableEmission = true;
            StartCoroutine(coinEffectStop());
             transform.GetChild(5).GetComponent<yonKontrol>().sil = true;
              transform.GetChild(2).GetComponent<yonKontrol>().sil = true;
            Destroy(transform.parent.gameObject, 0.6f);
            ScoreCalculate();
        }
    }
    private IEnumerator coinEffectStop()
    {
        yield return new WaitForSeconds(0.5f);

        efekt.GetComponent<ParticleSystem>().enableEmission = false;
    }

    void ScoreCalculate()
    {
        PlayerPrefs.SetInt("score", PlayerPrefs.GetInt("score") + 5);
        PlayerPrefs.SetInt("moves", PlayerPrefs.GetInt("moves") + 1);
        if (PlayerPrefs.GetInt("score") > PlayerPrefs.GetInt("highScore"))
        {
            PlayerPrefs.SetInt("highScore", PlayerPrefs.GetInt("score"));

        }
        FindObjectOfType<scoreUIControls>().scoreUI.text = PlayerPrefs.GetInt("score").ToString();
        FindObjectOfType<scoreUIControls>().highScoreUI.text = PlayerPrefs.GetInt("highScore").ToString();
        FindObjectOfType<scoreUIControls>().movesUI.text = PlayerPrefs.GetInt("moves").ToString();

    }

}
