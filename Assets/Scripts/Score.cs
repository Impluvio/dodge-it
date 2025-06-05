using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    int hits = 0;
    private void OnCollisionEnter(Collision other)
    {

        if(other.gameObject.tag != "Hit")
        {
            hits++;
            Debug.Log($"you hit something this many times: {hits} you burke ");
        }
        

        
    }
}
