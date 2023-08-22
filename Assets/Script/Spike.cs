using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spike : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("hehehe " + collision.gameObject.name);
        if (collision.gameObject.CompareTag("enemy"))
            Destroy(collision.gameObject);

        // here

    }
}
