using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraswitch : MonoBehaviour
{
    public GameObject cameraon;
public GameObject cameraoff;
public float waitsbeforeswitch;
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
    yield return new WaitForSeconds(waitsbeforeswitch);
    cameraon.SetActive(true);
        cameraoff.SetActive(false);
}
}
