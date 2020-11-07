using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class matchControl : MonoBehaviour
{
    RaycastHit2D tileControlHitSag, tileControlHitSol;
    string spriteName;
    
    private void Start()
    {
        spriteName = GetComponent<SpriteRenderer>().sprite.name;
    }
    // Update is called once per frame
    void Update()
    {

        foreach (Collider2D collider in Physics2D.OverlapBoxAll(transform.position, Vector2.one, 0f))
        {
            if (collider == this.GetComponent<Collider2D>())
            {
                return;

            }
        }

        /*
        hitEslesmeKontrolSag();

        hitEslesmeKontrolSol();

        */

    }
    /*
    void hitEslesmeKontrolSag()
    {
        tileControlHitSag = Physics2D.Raycast(transform.position, transform.right);
        tileControlHitSol = Physics2D.Raycast(transform.position, -transform.right);

        if (tileControlHitSag.collider.CompareTag("Karo"))
        {

          //  print("sağda karo var");
        }
        switch (tileControlHitSag.collider.tag)
        {
            case "Karo":

                if (tileControlHitSag.collider.GetComponent<SpriteRenderer>().sprite.name == spriteName)
                {
                    print(tileControlHitSag.collider.GetComponent<SpriteRenderer>().sprite.name);
                    FindObjectOfType<TileTouch>().eslesenSayisi++;

                    if (FindObjectOfType<TileTouch>().eslesenSayisi == 3)
                    {
                        Destroy(tileControlHitSag.collider.gameObject);
                        print("sağda renkdaş var" + tileControlHitSag.collider.GetComponent<SpriteRenderer>().sprite.name);
                    }
                    else 
                    {
                        FindObjectOfType<TileTouch>().eslesenSayisi = 0;
                    }
                }

                break;
        }
    }
    void hitEslesmeKontrolSol()
    {
        tileControlHitSol = Physics2D.Raycast(transform.position, transform.right);

        if (tileControlHitSol.collider.CompareTag("Karo"))
        {

            //  print("sağda karo var");
        }
        switch (tileControlHitSol.collider.tag)
        {
            case "Karo":

                if (tileControlHitSol.collider.GetComponent<SpriteRenderer>().sprite.name == spriteName)
                {
                    print(tileControlHitSol.collider.GetComponent<SpriteRenderer>().sprite.name);
                    FindObjectOfType<TileTouch>().eslesenSayisi++;

                    if (FindObjectOfType<TileTouch>().eslesenSayisi == 3)
                    {
                        Destroy(tileControlHitSol.collider.gameObject);
                        print("sağda renkdaş var" + tileControlHitSol.collider.GetComponent<SpriteRenderer>().sprite.name);
                    }
                    else
                    {
                        FindObjectOfType<TileTouch>().eslesenSayisi = 0;
                    }
                }

                break;
        }
    }
    */
}


