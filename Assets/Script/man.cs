using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class man : MonoBehaviour
{
    public AudioClip backgroundMusic;
    private AudioSource musicPlayer;
    // Start is called before the first frame update
    void Start()
    {
        musicPlayer = GetComponent<AudioSource>();
        playSound(backgroundMusic, musicPlayer);
    }

    public static void playSound(AudioClip clip,AudioSource audioPlayer)
    {
        audioPlayer.Stop();
        audioPlayer.clip = clip;
        audioPlayer.loop=true;
        audioPlayer.time = 0;
        audioPlayer.Play();

    }
}
