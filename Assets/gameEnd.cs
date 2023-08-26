using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameEnd : MonoBehaviour
{
    public Canvas GameOver;
    public GameObject BgMusic;
    public GameObject GameOverMusic;

    // Start is called before the first frame update
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("enemy"))
        {
            BgMusic.SetActive(false);
            GameOverMusic.SetActive(true);
            Time.timeScale = 0f;
            GameOver.gameObject.SetActive(true);

        }
    }

}
