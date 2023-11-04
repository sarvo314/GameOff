using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSize : MonoBehaviour
{

    [SerializeField] private float changeScale = 1.1f; // how much the object increases or decreases in size
    // private float maxSize = 10f;
    // private float minSize = 1f;
    private Vector3 initialScale;

    void Start()    
    {   
        initialScale = transform.localScale; // gets the initial scale of the object
    }

    void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0)) // increases size with left mouse button (0)
        {
            Debug.Log("left mouse down");
            transform.localScale *= changeScale;
        }
    }

    void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(1))
        {
            Debug.Log("right mouse down"); // decreases size with right mouse button (1)
            transform.localScale /= changeScale;
        }
    }
}
