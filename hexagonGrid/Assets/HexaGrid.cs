﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HexaGrid : MonoBehaviour
{
    [SerializeField]
    GameObject hexagon;

    public float gridWidth = 2;
    public float gridHeight = 2;
    public float gap = 0f;

    float hexWidth = Mathf.Sqrt(3) * 5;
    float hexHeight = 2 * 5;

    Vector3 startPos = new Vector3(0, 0, 0);

    public void MakeGrid()
    {
        foreach (Transform child in transform)
        {
            GameObject.Destroy(child.gameObject);
        }
        AddGap();
        CalcStartPos();
        CreateGrid();
    }

    void AddGap()
    {
        hexWidth += hexWidth * gap;
        hexHeight += hexHeight * gap;
    }

    void CalcStartPos()
    {
        float offset = 0;
        if (gridHeight / 2 % 2 != 0)
            offset = hexWidth / 2;

        float x = -hexWidth * (gridWidth / 2) - offset;
        float y = hexHeight * 0.75f * (gridHeight / 2);

        startPos = new Vector3(x, y, 0);
    }

    Vector3 CalcWorldPos(Vector2 gridPos)
    {

        float offset = 0;

        if(gridPos.y % 2 != 0)
        {
            offset = hexWidth / 2;
        }
        float x = startPos.x + gridPos.x * hexWidth + offset;
        float y = startPos.y - gridPos.y * hexHeight * 0.75f;

        return new Vector3(x, y, 0);
    }

    void CreateGrid()
    {
        for (int x = 0; x < gridWidth; x++)
        {
            for (int y = 0; y < gridHeight; y++)
            {
                GameObject hex = Instantiate(hexagon);
                Vector2 gridPos = new Vector2(x, y);
                hex.transform.position = CalcWorldPos(gridPos);
                hex.transform.parent = this.transform;
                hex.name = "Hexagon " + x + "/" + y;
            }
        }
    }

    public void SetGap(float gap)
    {
        this.gap = gap;
    }
    public void SetGridWidth(float gridWidth)
    {
        this.gridWidth = gridWidth;
    }
    public void SetGridHeight(float gridHeight)
    {
        this.gridHeight = gridHeight;
    }
}


