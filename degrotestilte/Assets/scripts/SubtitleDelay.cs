using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SubtitleDelay : MonoBehaviour
{
      public float waitsbeforeimage;

    public float waitsbeforeimagedestroy;
    public Image sub;
    // Start is called before the first frame update
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
    yield return new WaitForSeconds(waitsbeforeimage);
    
sub.enabled = true;
yield return new WaitForSeconds(waitsbeforeimagedestroy);

    Destroy(gameObject);
}
}
