using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DroppingObject : MonoBehaviour
{

    [SerializeField] float timeUntilDrop = 2f;
    MeshRenderer objMeshRenderer;
    Rigidbody objRigidBody;

    void Start()
    {
        objMeshRenderer = GetComponent<MeshRenderer>();
        objMeshRenderer.enabled = false;

        objRigidBody = GetComponent<Rigidbody>();
        objRigidBody.useGravity = false;

    }

    // Update is called once per frame
    void Update()
    {
        

        if(Time.time > timeUntilDrop)
        {
            objMeshRenderer.enabled = true;
            objRigidBody.useGravity = true;
        }

    }
}
