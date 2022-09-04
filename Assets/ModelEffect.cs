using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModelEffect : MonoBehaviour
{
    private MeshRenderer meshRenderer;
    public float blinkTime;
    private float nextBlinkTime;

    private bool isBlinking;
    void Start()
    {
        meshRenderer = GetComponentInChildren<MeshRenderer>();
    }

    void Update(){
        if(isBlinking && Time.time > nextBlinkTime){
            nextBlinkTime = Time.time + blinkTime;
            meshRenderer.enabled = !meshRenderer.enabled;
        }
    }

    public void SetIsBlinking(bool val){
        isBlinking = val;
    }
    
}
