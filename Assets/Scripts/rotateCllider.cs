using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateCllider : MonoBehaviour
{
    public List<GameObject> eskiChildListesi = new List<GameObject>();
    public Transform rotateObj;
    // Start is called before the first frame update
  
        private void Start()
    {
        rotateObj = transform;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

        /*
        if (collision.gameObject.CompareTag("Karo"))
        {

          

            collision.transform.parent = transform;

           
          //  eskiChildListesi.Add(transform.Find("Tile").transform);
            
            
            print(eskiChildListesi.Count+"bööö");
            
        }*/
    }


}
