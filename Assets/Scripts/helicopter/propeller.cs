using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class propeller : MonoBehaviour
{
    Transform _ptf;
    public helicopterinput _input;
    public float speed;
    float updeltatime = 0.0f;
    float downdeltatime = 0.0f;
    bool start = false;
    // Start is called before the first frame update
    void Start()
    {
        _ptf = GetComponent<Transform>();

    }

    // Update is called once per frame
    void Update()
    {
        if(_input.S)
        {
            start = !start;
        }
        if (start)
        {
            downdeltatime = 0.0f;
            updeltatime += Time.deltaTime / 1000;
            speed = Mathf.Lerp(speed, 20, updeltatime * updeltatime);
        }
        else
        {
            updeltatime = 0.0f;
            downdeltatime += Time.deltaTime / 1000;
            speed = Mathf.Lerp(speed, 0, downdeltatime * downdeltatime);
        }
        _ptf.Rotate(0f, speed, 0f);

    }
}
