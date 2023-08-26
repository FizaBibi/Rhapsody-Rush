using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class BackgroundMusic : MonoBehaviour
{
    public AudioMixerSnapshot defaultSnapshot;  // Drag the default Audio Mixer Snapshot here
    public AudioMixerSnapshot gameOverSnapshot; // Drag the game over Audio Mixer Snapshot here

    public void PlayDefaultMusic()
    {
        defaultSnapshot.TransitionTo(1.0f);  // Transition to the default snapshot
    }

    public void PlayGameOverMusic()
    {
        gameOverSnapshot.TransitionTo(1.0f); // Transition to the game over snapshot
    }
}
