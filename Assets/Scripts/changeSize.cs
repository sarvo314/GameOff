using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSize : MonoBehaviour
{

    [SerializeField] private float changeScale = 1.1f; // how much the object increases or decreases in size
    private Vector3 initialScale;


    void Start()    
    {   
        initialScale = transform.localScale; // gets the initial scale of the object
    }

    void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0)) // increases size with left mouse button (0)
        {
            transform.localScale *= changeScale;
        }
    }

    void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(1)) // decreases size with right mouse button (1)
        {
            transform.localScale /= changeScale; 
        }
    }
}
