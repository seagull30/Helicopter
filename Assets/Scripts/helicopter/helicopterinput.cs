using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Helicopterinput : MonoBehaviour
{
    public float x { get; private set; }
    public bool start { get; private set; }
    public float z { get; private set; }
    public bool up { get; private set; }
    public bool down { get; private set; }



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        start = false;
        up = false;
        down = false;

        x = Input.GetAxis("Horizontal");
        z = Input.GetAxis("Vertical");
        start = Input.GetKeyDown(KeyCode.Space);
        up = Input.GetKey(KeyCode.LeftShift);
        down = Input.GetKey(KeyCode.LeftControl);
    }
}
