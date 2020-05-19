using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CallFadeIn : MonoBehaviour
{
    public AudioSource audioSource;
    public float duration;
    public float targetVolume;
   public float waitsbeforefade;
    void Start()
    {
        StartCoroutine(waiter());

    }

    // Update is called once per frame
    void Update()
    {
        
    }
     IEnumerator waiter()
{
    yield return new WaitForSeconds(waitsbeforefade);
    StartCoroutine(FadeAudioSource.StartFade(audioSource, duration, targetVolume));
}
}
