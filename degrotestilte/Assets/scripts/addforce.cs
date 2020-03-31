using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class addforce : MonoBehaviour
{
    public float thrustx, thrusty, thrustz;

    public Rigidbody rb;
    public float xAngle, yAngle, zAngle;
    public Transform obj;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(thrustx, thrusty, thrustz, ForceMode.Impulse);

        

    }

    // Update is called once per frame
    void Update()
    {
        obj.transform.eulerAngles = new Vector3(
    obj.transform.eulerAngles.x + xAngle,
    obj.transform.eulerAngles.y + yAngle,
    obj.transform.eulerAngles.z + zAngle);
    }
    }

