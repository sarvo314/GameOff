using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeSize : MonoBehaviour
{

    [SerializeField] public float changeScale = 1.1f; // how much the object increases or decreases in size
    public float maxSize = 10f;
    public float minSize = 1f;
    private Vector3 initialScale;

    void Start()    
    {   
        initialScale = transform.localScale; // gets the initial scale of the object
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // increases size with left mouse button (0)
        {
            transform.localScale *= changeScale;
        }
        else if (Input.GetMouseButtonDown(1)) // decreases size with right mouse buutton (1)
        {
            transform.localScale /= changeScale;
        }

    }
}
