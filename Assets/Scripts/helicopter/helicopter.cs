using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Helicopter : MonoBehaviour
{

    Rigidbody _rigidbody;
    Transform _transfom;
    Helicopterinput _input;
    public GameObject _pro;
    float _speed = 5;
    Propeller _propeller;

    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _transfom = GetComponent<Transform>();
        _input = GetComponent<Helicopterinput>();
        _propeller = _pro.GetComponent<Propeller>();
    }

    // Update is called once per frame
    void Update()
    {
        if (_propeller._speed > 3.0f)
        {
            if (_input.up)
            {
                _rigidbody.AddForce(0, _speed, 0);
            }
            if (_input.down)
            {
                _rigidbody.AddForce(0, -_speed, 0);
            }

            _transfom.Translate(new Vector3(0.0f, 0.0f, _speed * _input.z));
            _transfom.Rotate(0f, _input.x / 10, 0f);
        }

    }
}
