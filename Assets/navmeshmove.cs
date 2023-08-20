using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class navmeshmove : MonoBehaviour
{
    public GameObject Singer;

    public NavMeshAgent crowd;
    // Start is called before the first frame update
    void Start()
    {
        crowd.SetDestination(Singer.transform.position);
    }
}
