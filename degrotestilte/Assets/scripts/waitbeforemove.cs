using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class waitbeforemove : MonoBehaviour
{
              public Transform obj;
    public float xmove, ymove, zmove;
   
public float xAngle, yAngle, zAngle;
    private bool wait = true;

    public float waitsbeforemove;
 
    void Start()
    {

     StartCoroutine(waiter());
     

    }
    void Update()
    {
        if (wait == false){
        transform.Translate(xmove, ymove, zmove);
        obj.transform.eulerAngles = new Vector3(
    obj.transform.eulerAngles.x + xAngle,
    obj.transform.eulerAngles.y + yAngle,
    obj.transform.eulerAngles.z + zAngle);
    }
}
  

    
    IEnumerator waiter()
{
   
    yield return new WaitForSeconds(waitsbeforemove);
  wait = false;
 
        
    

    
}
}
