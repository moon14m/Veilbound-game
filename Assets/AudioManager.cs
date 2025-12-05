using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour

{
    public static AudioManager instance;
    public AudioSource musicSource;
    public AudioSource sfxSource;
    public AudioClip overrworldMusic;
    public AudioClip caveMusic;
    public AudioClip [] variousSFX;
    // Start is called before the first frame update
    void Start()
    {
        musicSource.clip = overrworldMusic;
        musicSource.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    public void PlayMusicSFX(AudioClip clip)
    {
        sfxSource.clip = clip;
        sfxSource.Play();
    }

    public void PlayMusic(AudioClip clips)
    {
       musicSource.clip = clips;
       musicSource.Play();  
    }
    public void PlayRandomSFX(params AudioClip[] clips)
    {
       variousSFX= clips;
       int randomIndex = Random.Range(0, variousSFX.Length);
        sfxSource.clip = variousSFX[randomIndex];
          sfxSource.Play();
    }
}