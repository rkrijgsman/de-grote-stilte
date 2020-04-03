using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickupaudio : MonoBehaviour {


    public Transform hand;
    public Rigidbody rigidbody;
     public bool audioplaying = false;
            AudioSource audio;
 
    public AudioClip SoundToPlay;
    public float Volume;
    

    // Use this for initialization
    void Start () {


        rigidbody = GetComponent<Rigidbody>();
        audio = GetComponent<AudioSource>();
        
	}
	
	// Update is called once per frame
	void Update () {
       
       if (rigidbody.isKinematic == true && audioplaying == false)
        {
            GetComponent<AudioSource>().PlayOneShot(SoundToPlay, Volume);
            audioplaying = true;
        }
	}

    private void OnMouseDown()
    {
        rigidbody.useGravity = false;
        transform.position = hand.position;
        transform.parent = hand;
        rigidbody.isKinematic = true;
     
        

    }

  // private void OnMouseUp()
  //  {
  //      transform.parent = null;
  //      rigidbody.useGravity = true;
  //      rigidbody.isKinematic = false;
  //      rigidbody.AddForce(Camera.main.transform.forward * 15, ForceMode.Impulse);
  //  }
}
