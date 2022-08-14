using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllTheUniqueVertQuads : AbstractMeshGenerator {

    [SerializeField] private Vector3[] vs = new Vector3[4];
    [SerializeField] private Vector2[] flexibleUVs = new Vector2[4];
    // Control UV's with all the triangles separated
    [SerializeField] private Vector2[] flexibleUniqueUVs = new Vector2[6];

    protected override void SetMeshNum() {
        numVertices = 6;
        numTriangles = 6;
    }

    protected override void SetVertecies() {
        vertices.Add(vs[0]);
        vertices.Add(vs[1]);
        vertices.Add(vs[3]);

        vertices.Add(vs[0]);
        vertices.Add(vs[3]);
        vertices.Add(vs[2]);
    }
    protected override void SetTriangles() {
        // Triangle One
        triangles.Add(0);
        triangles.Add(1);
        triangles.Add(2);

        // Triangle Two
        triangles.Add(3);
        triangles.Add(4);
        triangles.Add(5);
    }

    protected override void SetUVs() {
        /*
        uvs.Add(flexibleUVs[0]);
        uvs.Add(flexibleUVs[1]);
        uvs.Add(flexibleUVs[3]);
                
        uvs.Add(flexibleUVs[0]);
        uvs.Add(flexibleUVs[3]);
        uvs.Add(flexibleUVs[2]);
        */
        uvs.AddRange(flexibleUniqueUVs);
    }
    protected override void SetNormals() { }
    protected override void SetTangents() { }
    protected override void SetVertexColours() { }
}
