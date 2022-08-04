using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllThePoligons : AbstractMeshGenerator {

    [SerializeField, Range(3, 50)] private int numSides = 3;
    [SerializeField] private float radius;

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
    protected override void SetNormals() { }
    protected override void SetTangents() { }
    protected override void SetUVs() { }
    protected override void SetVertexColours() { }
}
