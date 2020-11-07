using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HexTileMapGenerator : MonoBehaviour
{

    public GameObject hexTilePrefab;

    int mapWidth = 25;
    int mapHeight = 12;

    // Start is called before the first frame update
    void Start()
    {
        CreateHexTileMap();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void CreateHexTileMap()
    {
        for (int x = 0; x <= mapWidth; x++ )
        {

        }
    }
}
