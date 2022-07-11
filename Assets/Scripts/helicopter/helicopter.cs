using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class helicopter : MonoBehaviour
{
    Rigidbody _hrb;
    Transform _htf;
    helicopterinput _input;
    public GameObject _pro;
    float speed = 5;
    public float _pSpeed;

    // Start is called before the first frame update
    void Start()
    {
        _hrb = GetComponent<Rigidbody>();
        _htf = GetComponent<Transform>();
        _input = GetComponent<helicopterinput>();
        _pro = GameObject.Find("Cube");
    }

    // Update is called once per frame
    void Update()
    {
        _pSpeed = _pro.GetComponent<propeller>().speed;
        if (_pSpeed > 3.0f)
        {
            if (_input.Up)
            {
                _hrb.AddForce(0, 50, 0);
            }
            if(_input.Down)
            {
                _hrb.AddForce(0, -50, 0);
            }

            _htf.Translate(new Vector3(0.0f, 0.0f, speed * _input.Z));
            _htf.Rotate(0f, _input.X/10, 0f);
        }

    }
}
