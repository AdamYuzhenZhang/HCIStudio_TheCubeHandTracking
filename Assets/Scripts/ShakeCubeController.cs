using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShakeCubeController : MonoBehaviour
{
    private Vector3 acceleration;

    private Vector3 distanceMoved = Vector3.zero;

    private Vector3 lastDistMoved = Vector3.zero;

    private Vector3 lastPos;

    public float accThreshold;

    //public GameObject debug;
   // public GameObject debug2;

    private bool taskDone;

    public GameObject shakeTarget;
    // Start is called before the first frame update
    void Start()
    {
        lastPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        distanceMoved = (transform.position - lastPos) * Time.deltaTime;
        acceleration = distanceMoved - lastDistMoved;
        lastDistMoved = distanceMoved;
        lastPos = transform.position;

        //debug.GetComponent<TextMesh>().text = (acceleration.magnitude > accThreshold).ToString();

        if (acceleration.magnitude > accThreshold)
        {
            // perform task
            if (!taskDone)
            {
                taskDone = true;
                //debug2.GetComponent<TextMesh>().text = "task performed";
                shakeTarget.GetComponent<TouchController>().ToggleScale();
            }
        }
        else
        {
            taskDone = false;
            //debug2.GetComponent<TextMesh>().text = "task ready to be performed";
        }
    }
}
