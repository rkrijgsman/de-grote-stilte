using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class waitfor : MonoBehaviour

{
    public UnityEngine.Video.VideoClip videoClip;
    public float waittime;
    public float lengthtext;
    void Start()
    {
        var videoPlayer = gameObject.AddComponent<UnityEngine.Video.VideoPlayer>();
videoPlayer.playOnAwake = false;
        videoPlayer.clip = videoClip;
        videoPlayer.renderMode = UnityEngine.Video.VideoRenderMode.MaterialOverride;
        videoPlayer.targetMaterialRenderer = GetComponent<Renderer>();
        videoPlayer.targetMaterialProperty = "_MainTex";

         StartCoroutine(waiter());
    }



    // Update is called once per frame
    IEnumerator waiter()
{
    

    //Wait for 4 seconds
    yield return new WaitForSeconds(waittime);
    var vp = GetComponent<UnityEngine.Video.VideoPlayer>();
    vp.Play();
    yield return new WaitForSeconds(lengthtext);
    
        Destroy(gameObject);
    

    
}
}
