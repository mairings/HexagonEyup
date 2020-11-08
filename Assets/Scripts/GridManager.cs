using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridManager : MonoBehaviour
{

    public List<Sprite> Sprites = new List<Sprite>();
    public GameObject TilePrafeb;
    public int GridDimensionx = 9, GridDimensiony = 8;
    public float Distancex = 1.0f, Distance = 1.0f;
    private GameObject[,] Grid;


    // Start is called before the first frame update
    void Start()
    {
        Grid = new GameObject[GridDimensionx, GridDimensiony];
        InitGrid();
    }


    void InitGrid()
    {
        Vector3 positionOffset = transform.position - new Vector3(GridDimensionx * Distance / 2.0f, GridDimensiony * Distance, 0);

        for (int row = 0;row < GridDimensionx; row++)
        {
            for (int column = 0; column < GridDimensiony; column++)
            {
                GameObject newTile = Instantiate(TilePrafeb);
                SpriteRenderer renderer = newTile.GetComponent<SpriteRenderer>();
                renderer.sprite = Sprites[Random.Range(0, Sprites.Count)];
                newTile.transform.parent = transform;
                newTile.transform.position = new Vector3(column*Distance,row*Distance,0)+positionOffset ;
                Grid[column, row] = newTile;
            }
        }


    }

}
