using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersuePlayer : MonoBehaviour
{
    [SerializeField] float projectileSpeed = 0.01f;
    [SerializeField] Transform player;
    Vector3 playerPosition;

    private void Awake()
    {
        gameObject.SetActive(false);


    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        playerPosition = player.transform.position; // updates the player position each frame.
        Launch();

    }


    private void Launch()
    {
        transform.Rotate(1, 0.8f, 1);
        transform.position = Vector3.MoveTowards(transform.position, playerPosition, Time.deltaTime * projectileSpeed);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);

        }
        else if( collision.gameObject)
        {
            Destroy(gameObject);
        }
    }
}
