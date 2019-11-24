using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerScript : MonoBehaviour
{
    public static AudioClip playerFireSound;
    static AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        playerFireSound = Resources.Load<AudioClip>("audio/sfx/fire");
        audioSource = GetComponent<AudioSource>();
    }

    public static void PlaySound(string soundName)
    {
        audioSource.volume = 10;
        switch(soundName)
        {
            case "fire":
                audioSource.volume = .15f;
                audioSource.PlayOneShot(playerFireSound);
                break;
        }
    }

}
