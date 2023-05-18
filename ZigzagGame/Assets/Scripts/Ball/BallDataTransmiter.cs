using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallDataTransmiter : MonoBehaviour
{
    [SerializeField] private BallýnputController ballInputController;
  

    public Vector3 GetBallDirection()
    {
        return ballInputController.ballDirection;
    }
}
