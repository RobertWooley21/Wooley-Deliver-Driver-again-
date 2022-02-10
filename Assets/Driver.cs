using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] float moveSpeed = 1f;
    [SerializeField] float Drivingcontrol = 0.1f;
   
    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, Drivingcontrol);
        transform.Translate(0, 0.01f, 0);
    }
}
