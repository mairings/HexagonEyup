using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileTouch : MonoBehaviour
{
    public bool parentTemizle=false;
    public int eslesenSayisi;
    public Transform rotateObj;
    bool objRotateAnahtar;
    public Animator dondurAnima;
    Animator rotateAnim;
    


    // Start is called before the first frame update
    void Start()
    {
        rotateAnim = dondurAnima.GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        MouseTouchTile();



    }

    // Herhangi bir altıgene dokunulursa üçlü grup oluşturulur ve bu üç altıgen bir parentte birleştirilir
    void MouseTouchTile()
    {
        if (Input.GetMouseButtonDown(0))
        {
            FindObjectOfType<rotateCllider>().rotateObj.DetachChildren();
            Vector2 worldpoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            print(worldpoint);
            RaycastHit2D hit = Physics2D.Raycast(worldpoint, Vector2.zero);
            if (hit.collider != null)
            {
               
            switch (hit.collider.tag)
                {
                    case "Tile":
                        print("tam isabet Bro");

                        Transform child = hit.transform.Find("kesisim");
                        rotateObj.transform.position = child.transform.position;
                        break;
                    case "Tile1":
                        print("tam isabet Bro");
                        
                        Transform child1 = hit.transform.Find("kesisim");
                        rotateObj.transform.position = child1.transform.position;

                        break;
                    case "Tile2":
                        print("tam isabet Bro");

                        Transform child2 = hit.transform.Find("kesisim");
                        rotateObj.transform.position = child2.transform.position;

                        break;
                    case "Tile3":
                        print("tam isabet Bro");

                        Transform child3 = hit.transform.Find("kesisim");
                        rotateObj.transform.position = child3.transform.position;

                        break;
                    case "Tile4":
                        print("tam isabet Bro");

                        Transform child4 = hit.transform.Find("kesisim");
                        rotateObj.transform.position = child4.transform.position;

                        break;
                    case "Tile5":
                        print("tam isabet Bro");

                        Transform child5 = hit.transform.Find("kesisim");
                        rotateObj.transform.position = child5.transform.position;

                        break;
                    case "Tile6":
                        print("tam isabet Bro");

                        Transform child6 = hit.transform.Find("kesisim");
                        rotateObj.transform.position = child6.transform.position;

                        break;
                }
                rotateAnim.SetTrigger("rotateAnime");
                dondurAnima.SetTrigger("defaultAnime");
            }
        }
    }



}
