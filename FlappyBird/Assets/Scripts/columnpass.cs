using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class columnpass : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        // if its the bird
        if (other.GetComponent<birdcontrol>()!= null)
        {
            gamecontroller.instance.Birdscored();

        }
    }
}
