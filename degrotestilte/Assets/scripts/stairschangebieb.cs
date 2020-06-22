using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stairschangebieb : MonoBehaviour
{
    public GameObject stairsOn;
    public GameObject wallOff;
public GameObject stairsoff1;
public GameObject stairsoff2;
public GameObject stairsoff3;
public GameObject stairsoff4;
public GameObject stairsoff5;

public GameObject wallOn1;

public GameObject wallOn2;
public GameObject wallOn3;
public GameObject wallOn4;
public GameObject wallOn5;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
     private void OnTriggerEnter(Collider Player)

    {stairsOn.SetActive(true);

    wallOff.SetActive(false);

        stairsoff1.SetActive(false);
        stairsoff2.SetActive(false);
        stairsoff3.SetActive(false);
        stairsoff4.SetActive(false);
        stairsoff5.SetActive(false);

        wallOn1.SetActive(true);
        wallOn2.SetActive(true);
        wallOn3.SetActive(true);
        wallOn4.SetActive(true);
        wallOn5.SetActive(true);
        
    }

}
