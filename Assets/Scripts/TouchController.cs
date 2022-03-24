using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TouchController : MonoBehaviour
{
    public Vector3 targetScale;
    public Vector3 originalScale;

    private void Start()
    {
        originalScale = transform.localScale;
    }

    public void ToggleScale()
    {
        if (transform.localScale == originalScale)
        {
            transform.localScale = targetScale;
        }
        else
        { 
            transform.localScale = originalScale;
        }
    }
}
