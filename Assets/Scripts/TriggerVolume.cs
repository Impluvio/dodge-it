using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerVolume : MonoBehaviour
{
    [SerializeField] GameObject projectile;
    [SerializeField] GameObject projectileSalvo;

    private void OnTriggerEnter(Collider other)
    {
        
        if(other.gameObject.tag == "Player")
        {
            if(projectile != null)
            {
                projectile.SetActive(true);
            }
            else if(projectileSalvo != null)
            {
                foreach(Transform child in projectileSalvo.transform)
                {
                    child.gameObject.SetActive(true);
                }
            }
            

        }
        
    }
}
