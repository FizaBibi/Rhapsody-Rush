using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private GameObject guitarSpikeBlock;

    private void Start()
    {
        Time.timeScale = 1.0f;
    }
    public void OnClick_Guitar()
    {
        Debug.Log("hahah");
        //guitarSpikeBlock.transform.position = Vector3.Lerp(guitarSpikeBlock.transform.position, new Vector3(28.2f, -1.5f, 7.3f), 0.3f);
        //guitarSpikeBlock.transform.position = new Vector3(28.2f, -1.5f, 7.3f);
        guitarSpikeBlock.SetActive(true);
    }
}
