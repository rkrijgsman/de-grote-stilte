using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CallFade : MonoBehaviour
{
    public AudioSource audioSource;
    public float duration;
    public float targetVolume;

    void Start()
    {
        StartCoroutine(FadeAudioSource.StartFade(audioSource, duration, targetVolume));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
