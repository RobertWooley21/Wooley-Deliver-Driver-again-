using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private object readOnlyCollectionneedtoslowdown;

    void OnCollisionEnter2D(Collision2D other, IReadOnlyCollection readOnlyCollection)           {
        Debug.Log(readOnlyCollectionneedtoslowdown!);
        
    {
    
    }
     void OnCollisionEnter2D(Collision2D Cool) { }

    // Update is called once per frame
    void Update()
    {

    }
}

    private interface IReadOnlyCollection
    {
    }
}
