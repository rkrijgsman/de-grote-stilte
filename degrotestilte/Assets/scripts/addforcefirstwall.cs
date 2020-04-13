using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class addforcefirstwall : MonoBehaviour
{
    public float thrustx, thrusty, thrustz;

    public Rigidbody rb;
    public float xAngle, yAngle, zAngle;
    public Transform obj;

     public float waittime;
  
   

    // Start is called before the first frame update
    void Start()
    {
           StartCoroutine(waiter());
        rb = GetComponent<Rigidbody>();
       

        

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator waiter()
{

    yield return new WaitForSeconds(waittime);
     
    rb.isKinematic = false;
 
   rb.AddForce(thrustx, thrusty, thrustz, ForceMode.Impulse);
   obj.transform.eulerAngles = new Vector3(
    obj.transform.eulerAngles.x + xAngle,
    obj.transform.eulerAngles.y + yAngle,
    obj.transform.eulerAngles.z + zAngle);
    
    

    
}
    }

