using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collisions : MonoBehaviour

   {
    private Rigidbody characterRigidbody;
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "concert")
        {
            characterRigidbody.velocity = Vector3.zero;
        }
    }
    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "concert")
        {
            characterRigidbody.velocity = Vector3.zero;
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "concert")
        {
            characterRigidbody.velocity = Vector3.zero;
        }
    }
}

