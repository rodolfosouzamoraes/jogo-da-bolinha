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
    public AudioClip audioButton;
    public AudioClip audioGate;
    public AudioClip audioPortal;
    public AudioClip audioIce;
    public AudioClip audioApito;
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

    public void PlayAudioKey() { 
        audioSource.PlayOneShot(audioKey);
    }

    public void PlayAudioUnlock() {
        audioSource.PlayOneShot(audioUnlock);
    }

    public void PlayAudioButton()
    {
        audioSource.PlayOneShot(audioButton);
    }

    public void PlayAudioGate()
    {
        audioSource.PlayOneShot(audioGate);
    }

    public void PlayAudioPortal()
    {
        audioSource.PlayOneShot(audioPortal);
    }

    public void PlayAudioIce()
    {
        audioSource.PlayOneShot(audioIce);
    }

    public void PlayAudioApito()
    {
        audioSource.PlayOneShot(audioApito);
    }
}
