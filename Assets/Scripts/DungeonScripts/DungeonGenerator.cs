using System;
using System.Collections.Generic;
using UnityEngine;
public class DungeonGenerator : MonoBehaviour
{
    public float RoomSize;
    public int GridSize;
    public Vector2[,] GridVector;
    public GameObject TestObject;
    void Start()
    {
        ClearDungeon();
        GridGenerator();
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
        GridVector = new Vector2[GridSize, GridSize];
    }
    void dungeonGenerator()
    {

    }
}
