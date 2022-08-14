using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllThePoligons : AbstractMeshGenerator {

    [SerializeField, Range(3, 50)] private int numSides = 3;
    [SerializeField] private float radius;

    [SerializeField] private float xTiling = 1;
    [SerializeField] private float yTiling = 1;

    [SerializeField] private float xScroll = 1;
    [SerializeField] private float yScroll = 1;

    [SerializeField] private float angle = 0;

    protected override void SetMeshNum() {
        numVertices = numSides;
        numTriangles = 3 * (numSides - 2); // There are (numSides - 2) physical triangles in a regular polygon. 3 ints describe each physical triangle, so miltiple this by 3
    }
    protected override void SetVertecies() {
        // Cordinates of a regular polygon
        for (int i = 0; i < numSides; i++) {
            float angle = 2 * Mathf.PI * i / numSides;
            vertices.Add(new Vector3(radius * Mathf.Cos(angle), radius * Mathf.Sin(angle), 0));
        }
    }
    protected override void SetTriangles() {
        for (int i = 1; i < numSides - 1; i++) {
            triangles.Add(0);
            triangles.Add(i + 1);
            triangles.Add(i);
        }
    }
    protected override void SetUVs() { 
        for (int i = 0; i < numVertices; i++) {
            float uvX = xTiling * vertices[i].x + xScroll;
            float uvY = yTiling * vertices[i].y + yScroll;
            Vector2 uv = new Vector2(uvX, uvY);

            uvs.Add(Quaternion.AngleAxis(angle, Vector3.forward) * uv);
        }
    }
    protected override void SetNormals() {
        Vector3 normal = new Vector3(0, 0, -1);

        for (int i = 0; i < numVertices; i++) {
            normals.Add(normal);
        }
    }
    protected override void SetTangents() { 
        
    }
    protected override void SetVertexColours() { 
        
    }
}
