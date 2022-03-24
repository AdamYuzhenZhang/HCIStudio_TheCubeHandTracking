using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TouchColor : MonoBehaviour
{
    public Vector3 targetScale;
    public Vector3 originalScale;

    public GameObject theCube;
    private bool RotationLimited;
    private float rotX;
    private float rotY;
    public GameObject colorDial;

    //public GameObject debug;
    private void Start()
    {
        originalScale = transform.localScale;
    }
    public void ToggleColorAndScale()
    {
        if (transform.localScale == originalScale)
        {
            transform.localScale = targetScale;
            limitRotation();
        }
        else
        { 
            transform.localScale = originalScale;
            stopLimitation();
        }
    }

    private void limitRotation()
    {
        //rotX = theCube.transform.eulerAngles.x;
        //rotY = theCube.transform.eulerAngles.y;
        RotationLimited = true;
    }

    private void stopLimitation()
    {
        RotationLimited = false;
    }
    
    protected void LateUpdate()
    {
        //if (RotationLimited)
        //{
            //theCube.transform.eulerAngles = new Vector3(rotX, rotY, theCube.transform.eulerAngles.z);
            
        //}
    }

    private void Update()
    {
        if (RotationLimited)
        {
            rotationToColor();
        }
    }

    private void rotationToColor()
    {
        float hue = theCube.transform.eulerAngles.z / 360;
        //debug.GetComponent<TextMesh>().text = theCube.transform.eulerAngles.z.ToString();
        Color color = Color.HSVToRGB(hue, 0.5f, 0.8f);
        colorDial.GetComponent<Renderer>().material.color = color;
    }
}
