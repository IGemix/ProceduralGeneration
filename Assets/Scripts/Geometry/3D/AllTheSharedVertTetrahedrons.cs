using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllTheSharedVertTetrahedrons : AbstractMeshGenerator {
    [SerializeField] private Vector3[] vs = new Vector3[4];

    protected override void SetMeshNum() {
        numVertices = 4;
        numTriangles = 12;
    }
    protected override void SetVertecies() {
        vertices.AddRange(vs);
    }
    protected override void SetTriangles() {
        // Base - 
        triangles.Add(0);
        triangles.Add(2);
        triangles.Add(1);

        // Sides
        triangles.Add(0);
        triangles.Add(3);
        triangles.Add(2);

        triangles.Add(2);
        triangles.Add(3);
        triangles.Add(1);

        triangles.Add(1);
        triangles.Add(3);
        triangles.Add(0);

    }
    protected override void SetNormals() {
    }

    protected override void SetTangents() {
    }

    protected override void SetUVs() {
    }
    protected override void SetVertexColours() {
    }
}
