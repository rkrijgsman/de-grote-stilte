using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public float xmove, ymove, zmove;
 
    public float xAngle, yAngle, zAngle;

   public Transform obj;
    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
           transform.Translate(xmove, ymove, zmove);
            obj.transform.eulerAngles = new Vector3(
    obj.transform.eulerAngles.x + xAngle,
    obj.transform.eulerAngles.y + yAngle,
    obj.transform.eulerAngles.z + zAngle);
     
    }
}
