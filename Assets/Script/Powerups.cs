using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Powerups : MonoBehaviour
{
    public Transform spike;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Scaleup()
    {
        StartCoroutine(SpikeScale());


    }

    IEnumerator SpikeScale()
    {
        spike.transform.localScale = new Vector3(3f,1f,3f);
        yield return new WaitForSeconds(5f);
        spike.transform.localScale = new Vector3(1f, 1f, 1f);
        Destroy(this.gameObject);

    }
}
