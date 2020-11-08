using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yonKontrol : MonoBehaviour
{
    public bool sil;
    public string colorKaro;

    //Altıgenin hangi yönünde hangi rengin olduğunun tespit edilmesi
    private void OnTriggerStay2D(Collider2D collision)
    {
        returnColliderlers(collision);

        if (collision.gameObject.tag == "Karo")
        {
            colorKaro = collision.GetComponent<SpriteRenderer>().sprite.name;
            if (sil)
            {
               Destroy(collision.gameObject, 0.2f);
               
            }


        }
    }
    
    //Dikkate alınmaması gereken colliderler
    void returnColliderlers(Collider2D a)
    {
        if (a == this.GetComponent<Collider2D>()) return;
        if (a.gameObject.CompareTag("Tile")
            || a.gameObject.CompareTag("Tile2")
            || a.gameObject.CompareTag("Tile3")
            || a.gameObject.CompareTag("Tile4")
            || a.gameObject.CompareTag("Tile5")
            || a.gameObject.CompareTag("Tile6")) return;
    }

   

}
