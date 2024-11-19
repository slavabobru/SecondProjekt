using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target_Script : MonoBehaviour
{
    public int speed = 10;
    public float vertical;
    public GameObject target;
    void Update()
    {
        vertical = Input.GetAxis("Vertical");
        {
            transform.Translate(Vector3.up * Time.deltaTime * speed * vertical);
        }
    }
}
