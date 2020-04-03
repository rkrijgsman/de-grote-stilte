using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickaudio : MonoBehaviour {


 
  
     public bool audioplaying = false;
            AudioSource audio;
 
    public AudioClip SoundToPlay;
    public float Volume;
    

    // Use this for initialization
    void Start () {


      
        audio = GetComponent<AudioSource>();
        
	}
	
	// Update is called once per frame
	void Update () {
       
   
       
	}

    private void OnMouseDown()
    {

      if (audioplaying == false)
        {
            GetComponent<AudioSource>().PlayOneShot(SoundToPlay, Volume);
            audioplaying = true;
        }
        audioplaying = false;
   
     
        

    }

  // private void OnMouseUp()
  //  {
  //      transform.parent = null;
  //      rigidbody.useGravity = true;
  //      rigidbody.isKinematic = false;
  //      rigidbody.AddForce(Camera.main.transform.forward * 15, ForceMode.Impulse);
  //  }
}
