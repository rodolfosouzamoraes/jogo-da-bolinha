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
            DontDestroyOnLoad(gameObject);
            return;
        }
        Destroy(gameObject);
    }

    public AudioSource audioSourceEffects;
    public AudioSource audioSourceMusic;
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
    public AudioClip audioBoot;
    public AudioClip audioMenu;
    public AudioClip audioGame;

    public void PlayAudioCoin()
    {
        audioSourceEffects.PlayOneShot(audioCoin);
    }

    public void PlayAudioTrophy() 
    {
        audioSourceEffects.PlayOneShot(audioTrophy);
    }

    public void PlayAudioExplosion()
    {
        audioSourceEffects.PlayOneShot(audioExplosion);
    }

    public void PlayAudioKey() { 
        audioSourceEffects.PlayOneShot(audioKey);
    }

    public void PlayAudioUnlock() {
        audioSourceEffects.PlayOneShot(audioUnlock);
    }

    public void PlayAudioButton()
    {
        audioSourceEffects.PlayOneShot(audioButton);
    }

    public void PlayAudioGate()
    {
        audioSourceEffects.PlayOneShot(audioGate);
    }

    public void PlayAudioPortal()
    {
        audioSourceEffects.PlayOneShot(audioPortal);
    }

    public void PlayAudioIce()
    {
        audioSourceEffects.PlayOneShot(audioIce);
    }

    public void PlayAudioApito()
    {
        audioSourceEffects.PlayOneShot(audioApito);
    }

    public void PlayAudioBoot()
    {
        audioSourceEffects.PlayOneShot(audioBoot);
    }

    public void PlayAudioGame()
    {
        if (audioSourceMusic.clip != audioGame) { 
            audioSourceMusic.Stop();
            audioSourceMusic.clip = audioGame;
            audioSourceMusic.Play();
        }
    }

    public void PlayAudioMenu()
    {
        if (audioSourceMusic.clip != audioMenu)
        {
            audioSourceMusic.Stop();
            audioSourceMusic.clip = audioMenu;
            audioSourceMusic.Play();
        }
    }
}
