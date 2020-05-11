using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class skybox : MonoBehaviour {

 public Material skybox1;

 // Use this for initialization
 void Start () {
    RenderSettings.skybox = skybox1;
 }
 
 // Update is called once per frame
 void Update () { 
 }
}