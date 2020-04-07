using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audiopickup : MonoBehaviour {


    public Transform hand;
    public Rigidbody rb;
    
    public bool audioplaying = false;
            AudioSource audio;
 
    public AudioClip SoundToPlay;
    public float Volume;
    Collider m_Collider;

    // Use this for initialization
    void Start () {


        rb = GetComponent<Rigidbody>();
        audio = GetComponent<AudioSource>();
        
        m_Collider = GetComponent<BoxCollider>();
	}
	
	// Update is called once per frame
	void Update () {
       
       if (rb.isKinematic == true && audioplaying == false)
        {
            audio.PlayOneShot(SoundToPlay, Volume);
            audioplaying = true;
            m_Collider.enabled = !m_Collider.enabled;
            
        }
	}

    private void OnMouseDown()
    {
        rb.useGravity = false;
        transform.position = hand.position;
        transform.parent = hand;
        rb.isKinematic = true;
     
        

    }

  // private void OnMouseUp()
  //  {
  //      transform.parent = null;
  //      rigidbody.useGravity = true;
  //      rigidbody.isKinematic = false;
  //      rigidbody.AddForce(Camera.main.transform.forward * 15, ForceMode.Impulse);
  //  }
}
