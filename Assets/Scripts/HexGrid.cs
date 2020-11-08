using UnityEngine;
using System.Collections;

public class HexGrid : MonoBehaviour
{
    public Transform spawnThis;

    public int x;
    public int y;

    private float offsetX, offsetY;
   
    void Start()
    {
        startValues();
        gridGenerator();
    }

    //Gelen verilere göre Otomatik Hexagon Grid oluşturur
    void gridGenerator()
    {
        x = PlayerPrefs.GetInt("rowSayisi");
        y = PlayerPrefs.GetInt("columnSayisi");

        offsetX = 0.9f;
        offsetY = 1f;

        for (int i = 0; i < x; i++)
        {
            for (int j = 0; j < y; j++)
            {
                Vector2 hexpos = MesafeHesaplayici(i, j);
                Vector3 pos = new Vector3(hexpos.x - 3.7f, hexpos.y - 4, 0);
                Instantiate(spawnThis, pos, Quaternion.identity);
            }
        }
    }

    //Karolar arası mesafeyi hesaplar
    Vector2 MesafeHesaplayici(int x, int y)
    {
        Vector2 position = Vector2.zero;

        if (x % 2 == 0)
        {
            position.x = x * offsetX;
            position.y = (y - 0.5f) * offsetY;
        }
        else
        {
            position.x = x * offsetX;
            position.y = y * offsetY;
        }

        return position;
    }

    //Başlangıç değerlerinin atanması
    void startValues()
    {
        if (PlayerPrefs.GetInt("a") == 0)
        {
            PlayerPrefs.SetInt("rowSayisi", 8);
            PlayerPrefs.SetInt("columnSayisi", 9);
            PlayerPrefs.SetInt("renkSayisi", 5);
            PlayerPrefs.SetInt("a", 1);

        }
    }


}