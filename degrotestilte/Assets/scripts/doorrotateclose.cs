using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorrotateclose : MonoBehaviour
{
    

    public float xAngle, yAngle, zAngle;
    public Transform obj;
        public float waittime;

    // Start is called before the first frame update
    void Start()
    {
        
    
   StartCoroutine(waiter());
        

    }

    // Update is called once per frame
    void Update()
    {
      obj.transform.eulerAngles = new Vector3(
    obj.transform.eulerAngles.x + xAngle,
    obj.transform.eulerAngles.y + yAngle,
    obj.transform.eulerAngles.z + zAngle);
    }
     IEnumerator waiter()
{


    yield return new WaitForSeconds(waittime);
    gameObject.GetComponent<doorrotate>().enabled = false;
    
}
    }

