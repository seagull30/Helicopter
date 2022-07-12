using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cameramove : MonoBehaviour
{
    public Transform target;

    private Transform tr;

    // Start is called before the first frame update
    void Start()
    {
        tr = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        tr.transform.position = new Vector3(target.transform.position.x + 10, target.transform.position.y + 20, target.transform.position.z + 10);
        tr.LookAt(target);
    }
}
