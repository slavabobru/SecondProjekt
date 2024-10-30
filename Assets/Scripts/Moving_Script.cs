using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving_Script : MonoBehaviour
{
    // Start is called before the first frame update
    public int speed = 15;
    public float horizontal;
    public float vertical;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed * vertical);
            // transform.Translate(Vector3.back * Time.deltaTime * speed * horizontal);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0, -1 ,0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, 1, 0);
        }
    }
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("removable"))
        {
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.CompareTag("Stopper"))
        {
            vertical = 0;
        }
    }
}
