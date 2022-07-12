using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Propeller : MonoBehaviour
{
    Transform _trnasform;
    public Helicopterinput _input;
    public float _speed;
    float updeltatime = 0.0f;
    float downdeltatime = 0.0f;
    bool _start = false;
    // Start is called before the first frame update
    void Start()
    {
        _trnasform = GetComponent<Transform>();

    }

    // Update is called once per frame
    void Update()
    {
        if (_input.start)
        {
            _start = !_start;
        }
        if (_start)
        {
            downdeltatime = 0.0f;
            updeltatime += Time.deltaTime / 1000;
            _speed = Mathf.Lerp(_speed, 20, updeltatime * updeltatime);
        }
        else
        {
            updeltatime = 0.0f;
            downdeltatime += Time.deltaTime / 1000;
            _speed = Mathf.Lerp(_speed, 0, downdeltatime * downdeltatime);
        }
        _trnasform.Rotate(0f, _speed, 0f);

    }
}
