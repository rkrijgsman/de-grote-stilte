using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audiopickup : MonoBehaviour
{
    public bool audioplaying = false;
            AudioSource audio;
    public Rigidbody rb;
    public AudioClip SoundToPlay;
    public float Volume;
    // Start is called before the first frame update
    void Start()
    {
        
        rb = GetComponent<Rigidbody>();
        audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (rb.isKinematic == true && audioplaying == false)
        {
            audio.PlayOneShot(SoundToPlay, Volume);
            audioplaying = true;
        }
        

    }
}
