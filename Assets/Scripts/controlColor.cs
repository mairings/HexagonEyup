using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlColor : MonoBehaviour
{
    public int score, highScore, moves;

    bool kontrolAnahtar = false;
    private void Update()
    {
        transform.Rotate(0,0,30*Time.deltaTime);
    }
    private void OnMouseDown()
    {
        kontrolAnahtar = true;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision == this.GetComponent<Collider2D>()) return;
        if (collision.gameObject.CompareTag("Tile")
            || collision.gameObject.CompareTag("Tile2")
            || collision.gameObject.CompareTag("Tile3")
            || collision.gameObject.CompareTag("Tile4")
            || collision.gameObject.CompareTag("Tile5")
            || collision.gameObject.CompareTag("Tile6")) return;
        if (collision.gameObject.CompareTag("Karo")) {
            if (collision.GetComponent<SpriteRenderer>().sprite.name == this.GetComponentInParent<SpriteRenderer>().sprite.name)
            {
                print("bu renk" + collision.GetComponent<SpriteRenderer>().sprite.name + "aynı" + this.GetComponentInParent<SpriteRenderer>().sprite.name);
                PlayerPrefs.SetInt("ayniRenkSayisi", PlayerPrefs.GetInt("ayniRenkSayisi") + 1);
                if (PlayerPrefs.GetInt("ayniRenkSayisi") >= 3 && kontrolAnahtar)
                {
                    Destroy(collision.gameObject, 2);
                    Destroy(gameObject, 2);
                    kontrolAnahtar = false;
                    PlayerPrefs.DeleteKey("ayniRenkSayisi");
                    score++;
                    FindObjectOfType<scoreUIControls>().scoreUI.text=score.ToString() ;
                    moves++;
                    FindObjectOfType<scoreUIControls>().movesUI.text = moves.ToString();

                    if(score > highScore)
                    {
                        score = highScore;
                        FindObjectOfType<scoreUIControls>().highScoreUI.text = highScore.ToString();
                    }


                }

            }
        }
    }

}
