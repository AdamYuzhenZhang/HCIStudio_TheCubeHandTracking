using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchDetach : MonoBehaviour
{
    public Vector3 targetScale;
    public Vector3 originalScale;
    public GameObject table;
    public GameObject parent;
   
    //private Transform originalTransform;
    private Vector3 originalPos;
    private Vector3 originalRot;
    
    private void Start()
    {
        originalScale = transform.localScale;
        //originalTransform = transform;
        originalPos = transform.localPosition;
        originalRot = transform.localEulerAngles;
    }

    public void ToggleScale()
    {
        if (transform.localScale == originalScale)
        {
            transform.localScale = targetScale;
            detach();
        }
        else
        { 
            attach();
            transform.localScale = originalScale;
        }
    }

    private void detach()
    {
        transform.parent = table.transform;
    }

    private void attach()
    {
        transform.parent = parent.transform;
        transform.localPosition = originalPos;
        transform.localEulerAngles = originalRot;
    }
}
