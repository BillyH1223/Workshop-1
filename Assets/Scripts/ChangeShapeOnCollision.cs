using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeShapeOnCollision : MonoBehaviour
{
    [SerializeField]
    private Mesh changeShapeTo;

    private void OnCollisionEnter(Collision collision)
    {
        GetComponent<MeshFilter>().mesh = this.changeShapeTo;
    }
}
