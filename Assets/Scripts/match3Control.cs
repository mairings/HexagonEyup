using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class match3Control : MonoBehaviour
{
    private void Update()
    {
        foreach (Collider2D collider in Physics2D.OverlapBoxAll(transform.position, Vector2.one, 0f))
        {
            if (collider == this.GetComponent<Collider2D>()) return;
            if (collider.gameObject.CompareTag("Tile")
                || collider.gameObject.CompareTag("Tile2")
                || collider.gameObject.CompareTag("Tile3")
                || collider.gameObject.CompareTag("Tile4")
                || collider.gameObject.CompareTag("Tile5")
                || collider.gameObject.CompareTag("Tile6")) return;
            if (collider.GetComponent<SpriteRenderer>().sprite.name == GetComponent<SpriteRenderer>().sprite.name ) 
            {
                print(collider.GetComponent<SpriteRenderer>().sprite.name + "rengi ve" + GetComponent<SpriteRenderer>().sprite.name + "rengi aynıdır");

                Destroy(collider.gameObject);

                


            }
        }
    }
}
