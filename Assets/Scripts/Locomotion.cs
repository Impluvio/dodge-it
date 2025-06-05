using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Locomotion : MonoBehaviour
{
    [SerializeField] [Tooltip("controls speed of player")] float playerSpeed = 10f;   

    // Start is called before the first frame update
    void Start()
    {






    }

    // Update is called once per frame
    void Update()
    {
        float xInput = Input.GetAxis("Horizontal") * playerSpeed * Time.deltaTime;
        float yInput = 0.0f;
        float zInput = Input.GetAxis("Vertical") * playerSpeed * Time.deltaTime;
        transform.Translate(xInput, yInput, zInput);

        

    }
}
