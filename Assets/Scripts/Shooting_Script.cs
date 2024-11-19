using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting_Script : MonoBehaviour
{
    public GameObject bullet;
    public GameObject endOfGun;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Instantiate(bullet, endOfGun.transform.position, endOfGun.transform.rotation); // transform.Translate(Vector3.forward * Time.deltaTime
        }
        
    }
}
