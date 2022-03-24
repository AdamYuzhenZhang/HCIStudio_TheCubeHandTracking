using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConnectionLine : MonoBehaviour
{
    private LineRenderer line;

    public GameObject end1;

    public GameObject end2;
    // Start is called before the first frame update
    void Start()
    {
        line = GetComponent<LineRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        line.SetPosition(0, end1.transform.position);
        line.SetPosition(1, end2.transform.position);
    }
}
