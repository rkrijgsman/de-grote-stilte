using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptnaarscene2 : MonoBehaviour
{
    public string scene;
    public Color loadToColor = Color.black;
    // Start is called before the first frame update
    void Start()
    {
        Initiate.Fade(scene,loadToColor,1f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
