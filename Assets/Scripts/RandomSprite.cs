using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSprite : MonoBehaviour
{
    public Sprite[] altigenSprites;
    SpriteRenderer mySprite;
    bool denetle=false, sil=false;

    // Start is called before the first frame update
    void Start()
    {
        mySprite = GetComponent<SpriteRenderer>();

        mySprite.sprite = altigenSprites[Random.Range(0, PlayerPrefs.GetInt("renkSayisi"))];

    }


            




    private void Update()
    {
        if (FindObjectOfType<TileTouch>().parentTemizle)
        {
            
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        

        if (collision.gameObject.CompareTag("Player"))
        {


            transform.parent = collision.gameObject.transform;
               // FindObjectOfType<rotateCllider>().eskiChildListesi.Add(gameObject);
               // print("adet" + FindObjectOfType<rotateCllider>().eskiChildListesi.Count + "bir" + FindObjectOfType<rotateCllider>().eskiChildListesi[0].name);

        }
    }

    

}
