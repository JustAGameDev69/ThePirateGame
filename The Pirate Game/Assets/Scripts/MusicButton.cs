using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class MusicButton : MonoBehaviour
{
    public AudioClip musicClip;
    private AudioSource audioSource;
    private bool isMusicPlaying = false;

    // Start is called before the first frame update
    void Awake()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = musicClip;
        audioSource.loop = true;
        audioSource.playOnAwake = true;
        isMusicPlaying = true;
    }

    public void ToggleMusic()
    {
        isMusicPlaying = !isMusicPlaying;

        if (isMusicPlaying)
        {
            audioSource.Play();
        }
        else { audioSource.Stop();}
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
