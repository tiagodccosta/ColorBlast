using UnityEngine.Audio;
using System;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class AudioManager : MonoBehaviour {


    public Sound[] sounds;

    public Toggle musicToggle;

    // Use this for initialization
    void Awake() {

        foreach (Sound s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;

            s.source.volume = s.volume;
            s.source.pitch = s.pitch;

            s.source.loop = s.loop;
        }

	}
    
    public void Start()
    {
        Play("theme");
    }

     public void StopMusic()
    {
        Stop("theme");
    }
        

    public void Play(string name)
    {
       Sound s = Array.Find(sounds, sound => sound.name == name);
        if(s == null)
        {
            return;
        }
        s.source.Play();
    }
    public void Stop(String name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        if (s == null)
        {
            return;
        }
        s.source.Stop();
    }

    public void ToogleChanged(bool IsOn)
    {
        if(musicToggle.isOn)
        {
            Start();
        } else {
            StopMusic();
        }
    }

}


