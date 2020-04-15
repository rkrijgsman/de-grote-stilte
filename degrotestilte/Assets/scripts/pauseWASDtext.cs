using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pauseWASDtext : MonoBehaviour

{
  
 
    public float lengthtext;
    void Start()
    {
     
var videoPlayer = GetComponent<UnityEngine.Video.VideoPlayer>();
        videoPlayer.Pause();
    }
     void Update()
        {
         var videoPlayer = GetComponent<UnityEngine.Video.VideoPlayer>();
        

         if (Input.GetKeyDown(KeyCode.W))
         {
             videoPlayer.Play();
              StartCoroutine(waiter());
         }
         if (Input.GetKeyDown(KeyCode.A))
         {
             videoPlayer.Play();
              StartCoroutine(waiter());
          
              
         }
         if (Input.GetKeyDown(KeyCode.S))
         {
             videoPlayer.Play();
              StartCoroutine(waiter());
         }
         if (Input.GetKeyDown(KeyCode.D))
         {
             videoPlayer.Play();
              StartCoroutine(waiter());
         }
         }
    
    IEnumerator waiter()
{
    
    yield return new WaitForSeconds(lengthtext);
    
        Destroy(gameObject);
    

    
}
}
