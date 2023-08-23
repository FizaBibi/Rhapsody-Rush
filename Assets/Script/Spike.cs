using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spike : MonoBehaviour
{
    [SerializeField] private ParticleSystem bloodParticle;
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("hehehe " + collision.gameObject.name);
        if (collision.gameObject.CompareTag("enemy"))
        {
            //bloodParticle.transform.position = ;
             Instantiate(bloodParticle, collision.gameObject.transform.position, bloodParticle.transform.rotation);
            bloodParticle.Play();
            Destroy(collision.gameObject);
        }
    }
}
