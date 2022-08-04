using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Audio;

public class AudioManager : MonoBehaviour
{
    public Sound[] sounds;
    public string currentTrack;

    void Awake() 
    {
        foreach (Sound s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;
            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
            s.source.loop = s.loop;
        }

        currentTrack = "Track1";
    }

    void Start() 
        {
            Play();
        }

    public void Play()
        {
            Sound s = Array.Find(sounds, sound => sound.name == currentTrack);
            s.source.Play();
        }

    public void PitchDown()
        {
            Sound s = Array.Find(sounds, sound => sound.name == currentTrack);
            s.source.pitch -= .1f;
        }    

    IEnumerator FadeTrack(string trackToFade, float endVolume)
    {
        Sound s1 = Array.Find(sounds, sound => sound.name == currentTrack);
        Sound s2 = Array.Find(sounds, sound => sound.name == trackToFade);

        float fadeTime = 1.5f;
        float timeElapsed = 0f;
        float startVolume1 = s1.source.volume;
        float startVolume2 = s2.source.volume;
        currentTrack = trackToFade;
        Play();

        while (timeElapsed < fadeTime)
        {
            s1.source.volume = Mathf.Lerp(startVolume1, 0f, timeElapsed/fadeTime);
            s2.source.volume = Mathf.Lerp(startVolume2, endVolume, timeElapsed/fadeTime);
            timeElapsed += Time.deltaTime;
            yield return null;
        }
    }

    public void ChangeTrack(string track, float finalVolume)
    {
        StopAllCoroutines();
        StartCoroutine(FadeTrack(track, finalVolume));
    }
}
