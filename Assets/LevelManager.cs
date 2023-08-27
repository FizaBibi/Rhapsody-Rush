using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public GameObject WinUi;
    public GameObject bg;
    public GameObject GameWinLoseMusic;
    public GameObject BgMusic;

    // Update is called once per frame
    void Update()
    {
        if (this.transform.childCount == 0)
        {
            WinUi.SetActive(true);
            GameWinLoseMusic.SetActive(true);
            bg.SetActive(false);
            BgMusic.SetActive(false);
        }
    }
}
