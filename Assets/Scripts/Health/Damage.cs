using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{
    

    private void Update()
    {
        RaycastHit hit;
        Ray deathRay = Camera.main.ScreenPointToRay(Input.mousePosition);

        if(Input.GetMouseButton(0))
        {
            if(Physics.Raycast(deathRay, out hit))
            {
            Debug.DrawRay(deathRay.origin, deathRay.direction * hit.distance, Color.cyan);
                //takeDamage();
                hit.collider.GetComponent<Health>().takeDamage(5);
            }
        }


    }
}
