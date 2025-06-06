using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaunchAtPlayer : MonoBehaviour
{
    [SerializeField] float projectileSpeed = 0.01f;
    [SerializeField] Transform player;
    Vector3 playerPosition;

    private void Awake()
    {
        gameObject.SetActive(false);
    }

    void Start()
    {
        
        playerPosition = player.transform.position;
        
    }

    

    // Update is called once per frame
    void Update()
    {
        Launch();
        DestroyAtDestination();


    }

    private void Launch()
    {
        transform.Rotate(1, 0.8f, 1);
        transform.position = Vector3.MoveTowards(transform.position, playerPosition, Time.deltaTime * projectileSpeed);
    }

    private void DestroyAtDestination()
    {
        if (transform.position == playerPosition)
        {
            Destroy(gameObject);
        }
    }
}
