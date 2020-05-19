using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class waitanddestroy : MonoBehaviour
{
    // Start is called before the first frame update
    public float waitsbeforedestroy;
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
    yield return new WaitForSeconds(waitsbeforedestroy);
     Destroy(gameObject);
}
}
