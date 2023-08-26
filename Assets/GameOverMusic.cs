using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverMusic : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public BackgroundMusic musicManager; // Drag your BackgroundMusicManager here

    public string gameOverSceneName = "GameOverScene"; // Name of the game over scene

    public void LoadGameOverScene()
    {
        musicManager.PlayGameOverMusic(); // Play game over background music
        SceneManager.LoadScene(gameOverSceneName); // Load the game over scene
    }
}
