using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllTheCones : AbstractMeshGenerator {
	[SerializeField] private float radius;
	[SerializeField, Range(3, 360)] private int numSides = 3;
	[SerializeField] private float length;

	protected override void SetMeshNum() {
		numVertices = 1 + numSides;
		numTriangles = 6 * numSides;
	}

	protected override void SetVertecies() {
		vertices.Add(new Vector3(0f, 0f, length));

		for (int i = 0; i < numSides; i++) {
			float angle = 2 * Mathf.PI * i / numSides;
			vertices.Add(new Vector3(radius * Mathf.Cos(angle), radius * Mathf.Sin(angle), 0f));
		}
	}

	protected override void SetTriangles() {
		//Middle
		for (int i = 1; i < numSides; i++) {
			triangles.Add(0);
			triangles.Add(i);
			triangles.Add(i + 1);
		}
		triangles.Add(0);
		triangles.Add(numSides);
		triangles.Add(1);

		//Base
		for (int i = 1; i < numSides - 1; i++) {
			triangles.Add(1);
			triangles.Add(i + 2);
			triangles.Add(i + 1);
		}

		triangles.Add(1);
		triangles.Add(numSides);
		triangles.Add(numSides - 1);
		triangles.Add(1);
		triangles.Add(numSides - 1);
		triangles.Add(numSides - 2);
	}

	protected override void SetNormals() { }
	protected override void SetTangents() { }
	protected override void SetUVs() { }
	protected override void SetVertexColours() { }
}
