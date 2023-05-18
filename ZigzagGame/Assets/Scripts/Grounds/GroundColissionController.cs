using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundColissionController : MonoBehaviour
{
    [SerializeField] private GroundDataTrasmitter groundDataTrasmitter;



    private void OnCollisionExit(Collision other)
    {
        if(other.gameObject.CompareTag("Ball"))
        {
            groundDataTrasmitter.SetGroundRigidbodyValues();
        }
    }
}
