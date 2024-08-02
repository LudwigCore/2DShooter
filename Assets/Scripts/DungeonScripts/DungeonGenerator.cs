using System;
using System.Security.Principal;
using UnityEngine;
public class DungeonGenerator : MonoBehaviour
{
    public float RoomSize;
    public int GridSize;
    public Vector2[,] Grid_Vector;
    public GameObject testObject;
    void Start()
    {
        ClearDungeon();
        GridGenerator();
        dungeonGenerator();
    }
    void ClearDungeon()
    {
        GameObject[] obj = GameObject.FindGameObjectsWithTag("DungeonPart");
        foreach (var item in obj)
        {
            Destroy(item);
        }
    }
    void GridGenerator()
    {
        Grid_Vector = new Vector2[GridSize * 2,GridSize * 2];
        float M1 = MathF.Sqrt(3);
        float M2 = M1 / 2;
        for(int i = 0; i < GridSize * 2; i++)
        {
            for (int j = 0; j < GridSize * 2; j++)
            {
                float x = RoomSize * ((3/2) * i + 0 * j);
                float y = RoomSize * (M2 * i + M1 * j);
                Grid_Vector[i,j] = new Vector2(x, y);
            }
        }
    }
    void dungeonGenerator()
    {
        for (int i = 0;i < GridSize;i++)
        {
            for (int j = 0; j < GridSize; j++)
            {
                Instantiate(testObject, Grid_Vector[i, j], Quaternion.identity);
            }
        }
    }
}
