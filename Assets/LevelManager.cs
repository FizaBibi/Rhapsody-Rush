using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public GameObject Win;
    public GameObject bg;
    public GameObject GameOver;
    public GameObject BgMusic;
    public GameObject WinMusic;   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(this.transform.childCount==0)
        {
            Win.SetActive(true);
            GameOver.SetActive(false);
            bg.SetActive(false);
            BgMusic.SetActive(false);
            WinMusic.SetActive(true);

        }
    }
    
}
