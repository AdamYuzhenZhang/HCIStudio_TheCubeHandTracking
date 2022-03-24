using System.Collections;
using System.Collections.Generic;
//using UnityEditor.UI;
using UnityEngine;

public class TableSetter : MonoBehaviour
{
    //private Rigidbody selfRigidbody;

    //private OVRGrabbable grabbable;
    //public GameObject Table;

    //private bool isFrozen = false;
    // Start is called before the first frame update
    void Start()
    {
        //selfRigidbody = GetComponent<Rigidbody>();
        //grabbable = GetComponent<OVRGrabbable>();
    }
    
    protected void LateUpdate()
     {
         transform.localEulerAngles = new Vector3(0, transform.localEulerAngles.y, 0);
     }

    public void SetTable()
    {
        
        //selfRigidbody.velocity = new Vector3(0, 0, 0);
        //selfRigidbody.angularVelocity = new Vector3(0, 0, 0);
        //grabbable.enabled = isFrozen;
        //isFrozen = !isFrozen;
        GameObject table = GameObject.CreatePrimitive(PrimitiveType.Cube);
        table.transform.position = transform.position;
        table.transform.eulerAngles = transform.eulerAngles;
        table.transform.localScale = transform.localScale;
        Destroy(this);
    }
    
}
