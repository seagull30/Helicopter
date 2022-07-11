using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class helicopterinput : MonoBehaviour
{
    public float X { get; private set; }
    public bool S { get; private set; }
    public float Z { get; private set; }
    public bool Up { get; private set; }
    public bool Down { get; private set; }



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        S = false;
        Up = false;
        Down = false;

        X = Input.GetAxis("Horizontal");
        Z = Input.GetAxis("Vertical");
        S = Input.GetKeyDown(KeyCode.Space);
        Up = Input.GetKey(KeyCode.LeftShift);
        Down = Input.GetKey(KeyCode.LeftControl);
    }
}
