using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameramove : MonoBehaviour
{
    public Transform target;

    private Transform tr;

    // Start is called before the first frame update
    void Start()
    {
        tr = GetComponent<Transform>();
        target = GameObject.Find("heli").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        tr.transform.position = new Vector3(target.transform.position.x + 10, target.transform.position.y + 20, target.transform.position.z + 10);
        tr.LookAt(target);
    }
}
