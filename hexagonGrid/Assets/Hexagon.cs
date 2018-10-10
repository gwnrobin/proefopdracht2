using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hexagon : MonoBehaviour
{
    float size = 5;
    MeshFilter meshFilter;
    Mesh mesh;

    Vector3[] vertices = new Vector3[7];
    int[] tri = new int[18];

    void Start()
    {
        meshFilter = GetComponent<MeshFilter>();
        mesh = new Mesh();
        meshFilter.mesh = mesh;

        vertices[6] = new Vector3(0, 0, 0); //middle
        for(int i = 0; i < 6; i++)
        {
            vertices[i] = Pointy_Hex_Corner(vertices[6], size, i, true);
        }

        mesh.vertices = vertices;

        tri[0] = 6;
        tri[1] = 0;
        tri[2] = 1;

        tri[3] = 6;
        tri[4] = 1;
        tri[5] = 2;

        tri[6] = 6;
        tri[7] = 2;
        tri[8] = 3;

        tri[9] = 6;
        tri[10] = 3;
        tri[11] = 4;

        tri[12] = 6;
        tri[13] = 4;
        tri[14] = 5;

        tri[15] = 6;
        tri[16] = 5;
        tri[17] = 0;

        mesh.triangles = tri;
    }

    Vector3 Pointy_Hex_Corner(Vector3 center, float size, int i, bool pointy)
    {
        float point;

        if (pointy)
        {
            point = 30;
        }
        else
        {
            point = 0;
        }
           
        float angle_deg = 60 * i - point;
        float angle_rad = Mathf.PI / 180 * angle_deg;

        return new Vector3(center.x + size * Mathf.Cos(angle_rad), center.y + size * Mathf.Sin(angle_rad), 0);
    }
}
