using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class F_Music : MonoBehaviour
{

    public 
    // Start is called before the first frame update
    void Start()
    {
        FMOD.Studio.EventInstance Music = FMODUnity.RuntimeManager.CreateInstance("event:/MusicIntro");
       // FMODUnity.RuntimeManager.AttachInstanceToGameObject(Music, transform, GetComponent<Rigidbody>());
        Music.start();
        Music.release();
    }

    // Update is called once per frame
    void Update()
    {
    //   Music.setParameterByName("PickUpBook", MaterialValue, false);                   // hier het eventpath meegeven vanuit de animatie. de parameter heet Material

    }
}
