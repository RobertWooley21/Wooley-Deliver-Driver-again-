using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] float moveSpeed = 3f;
    [SerializeField] float Drivingcontrol = 0.1f;
    private Input streerSpeed;
    private Time deltaTime;

    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
        _ = Input./GetAxis("Horizontal") * streerSpeed * Time.deltaTime;
        float moveAmount = Input. GetAxis("Vertical") * moveSpeed * Time. deltaTime;
        transform.Rotate(0, 1, Drivingcontrol);
        transform.Translate(0, 0.02f, 0);
    }

    private Input GetAxis(string v)
    {
        throw new NotImplementedException();
    }
}
