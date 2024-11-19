using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun_Controller : MonoBehaviour
{
    // public float horizontal;
    public float vertical = -24;
    public float sensitivity = 2;

    private void Start()
    {
        // transform.Rotate(0, 0, 0)
    }

    // Update is called once per frame
    void Update()
    {
        // horizontal = Input.GetAxis("Mouse X") * sensitivity;
        vertical = Input.GetAxis("Mouse Y") * sensitivity;
        transform.Rotate(-1 * vertical, 0, 0);
    }
}
