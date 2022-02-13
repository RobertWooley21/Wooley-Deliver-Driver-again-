using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FllowingCamra : MonoBehaviour
{
    private Vector3 transformpostion;

    // This is the camrea 
    // Start is called before the first frame update
    void Start()
    {
        [SerializeField] gameObject thingtoFollow;
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transformpostion + new Vector3(0, 0, 10);
    }
}
