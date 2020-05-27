using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class imagefadeinandout : MonoBehaviour
{
    private CanvasGroup _canvasGroup;
    [SerializeField] private float _duration = 3f;
        public float waitsbeforefade;
         public float waitsbeforestartfade;
 
    private void Awake() {
        _canvasGroup = GetComponent<CanvasGroup>();
    }
 
    private void Start() {
      
    _canvasGroup.alpha = 0f;
         StartCoroutine(waiter());
    }
 

IEnumerator waiter()
{
     yield return new WaitForSeconds(waitsbeforestartfade);
          StartCoroutine(FadeCGAlpha(0f, 1f, _duration));
    yield return new WaitForSeconds(waitsbeforefade);
 StartCoroutine(FadeCGAlpha(1f, 0f, _duration));
}
    private IEnumerator FadeCGAlpha(float from, float to, float duration) {
        float elaspedTime = 0f;
        while (elaspedTime <= duration) {
            elaspedTime += Time.deltaTime;
            _canvasGroup.alpha = Mathf.Lerp(from, to, elaspedTime / duration);
            yield return null;
        }
        _canvasGroup.alpha = to;
         
    }
 
}
