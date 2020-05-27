using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class FadeInOut : MonoBehaviour
{
    public float max = 1f;
public float speed = 5.0f;

public SpriteRenderer sprite;

void Update () {
    sprite.color = new Color(1f, 1f, 1f, Mathf.PingPong(Time.time * speed, max));
}
}   