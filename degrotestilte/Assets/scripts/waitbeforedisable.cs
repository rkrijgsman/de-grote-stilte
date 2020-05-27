using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class waitbeforedisable : MonoBehaviour
{
    public float waitsbeforedisable;
    public GameObject objecttodisable;
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
    yield return new WaitForSeconds(waitsbeforedisable);
    objecttodisable.SetActive(false);
        
}
}
