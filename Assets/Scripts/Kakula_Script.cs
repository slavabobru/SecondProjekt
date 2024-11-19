using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kakula_Script : MonoBehaviour
{
    public GameObject[] Kakuli;
    public int Kaka_index;
    void Start()
    {
        InvokeRepeating("Scary_Spawn", 2, 1);
    }
    void Scary_Spawn()
    {
        Kaka_index = Random.Range(0, Kakuli.Length);
        Instantiate(Kakuli[Kaka_index]);
    }
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime);
    }
}