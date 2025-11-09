using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManage : MonoBehaviour
{
    public static AudioManage Instance;

    [Header("Audio Sources")]
    [SerializeField] AudioSource Music;
    [SerializeField] AudioSource SFX;

    [Header("Audio Types")]
    public AudioClip jumpSFX;
    public AudioClip deathSFX;
    public AudioClip backgroundMusic;
    public AudioClip scoreSFX;

    private void Awake()
    {
        Instance = this;
        Music.clip = backgroundMusic;
        Music.loop = true;
        Music.Play();
    }


    public void PlaySFX(AudioClip clip)
    {
        SFX.PlayOneShot(clip);
    }
}
