using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] float moveSpeed = 3f;
    //[SerializeField] float Drivingcontrol = 0.1f;
    [SerializeField] float streerSpeed;
    [SerializeField] float slowSpeed = f15;
    [SerializeField] float boostSpeed = f50; 

    // Start is called before the first frame update
    void Start()
    {
     
    }
    private void OnAnimatorIK(int layerIndex)
    {
        On tirgger
            if (tag == "Boost") ;

     
      
        Debug.Log("you are boosting!")
            movementSpeed = boostSpeed; 

        moveSpeed = slowSpeed
    }
    // Update is called once per frame
    void Update()
    {
        float steerAmount = Input.GetAxis("Horizontal") * streerSpeed * Time.deltaTime;
        float moveAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        transform.Rotate(0, 0, steerAmount);
        transform.Translate(0, moveAmount, 0);
    }

    private Input GetAxis(string v)
    {
        throw new NotImplementedException();
    }
}
