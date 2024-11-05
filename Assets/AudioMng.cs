using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioMng : MonoBehaviour
{
    public static AudioMng Instance;

    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
            return;
        }
        Destroy(gameObject);
    }

    private AudioSource audioSource;
    public AudioClip audioCoin;
    public AudioClip audioTrophy;
    public AudioClip audioExplosion;
    public AudioClip audioKey;
    public AudioClip audioUnlock;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void PlayAudioCoin()
    {
        audioSource.PlayOneShot(audioCoin);
    }

    public void PlayAudioTrophy()
    {
        audioSource.PlayOneShot(audioTrophy);
    }

    public void PlayAudioExplosion() 
    {
        audioSource.PlayOneShot(audioExplosion);
    }
}
