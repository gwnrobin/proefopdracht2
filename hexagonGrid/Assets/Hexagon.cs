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
        
        vertices[0] = new Vector3(0, 0, 0); //middle
        vertices[1] = vertices[0] + new Vector3(-size, 0, -size).normalized * size; //left bottom
        vertices[2] = vertices[0] + new Vector3(-size, 0, 0).normalized * size; ; //left 
        vertices[3] = vertices[0] + new Vector3(-size, 0, size).normalized * size; ; //left top
        vertices[4] = vertices[0] + new Vector3(size, 0, size).normalized * size; ; //right top
        vertices[5] = vertices[0] + new Vector3(size, 0, 0).normalized * size; ; //right 
        vertices[6] = vertices[0] + new Vector3(size, 0, -size).normalized * size; ; //right bottom

        mesh.vertices = vertices;

        tri[0] = 0;
        tri[1] = 1;
        tri[2] = 2;

        tri[3] = 0;
        tri[4] = 2;
        tri[5] = 3;

        tri[6] = 0;
        tri[7] = 3;
        tri[8] = 4;

        tri[9] = 0;
        tri[10] = 4;
        tri[11] = 5;

        tri[12] = 0;
        tri[13] = 5;
        tri[14] = 6;

        tri[15] = 0;
        tri[16] = 6;
        tri[17] = 1;

        mesh.triangles = tri;
        
/*
        vertices[0] = new Vector3(0, 0, 0);
        vertices[1] = new Vector3(width, 0, 0);
        vertices[2] = new Vector3(0, height, 0);
        vertices[3] = new Vector3(width, height, 0);

        mesh.vertices = vertices;

        tri[0] = 0;
        tri[1] = 2;
        tri[2] = 1;

        tri[3] = 2;
        tri[4] = 3;
        tri[5] = 1;

        mesh.triangles = tri;
        */
    }
}
