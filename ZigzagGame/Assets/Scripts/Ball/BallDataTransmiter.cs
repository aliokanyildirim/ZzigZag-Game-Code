using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallDataTransmiter : MonoBehaviour
{
    [SerializeField] private Ball�nputController ballInputController;
  

    public Vector3 GetBallDirection()
    {
        return ballInputController.ballDirection;
    }
}
