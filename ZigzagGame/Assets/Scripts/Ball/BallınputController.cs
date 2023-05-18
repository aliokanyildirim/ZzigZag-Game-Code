using UnityEngine;

public class BallınputController : MonoBehaviour
{
    [HideInInspector] public Vector3 ballDirection;
    void Start()
    {
        ballDirection = Vector3.left;
    }


    void Update()
    {
        HandleBallInputs();
    }

    private void HandleBallInputs()
    {
        if (Input.GetMouseButtonDown(0))  //her ekrana dokundugumuz,tıkladığımızda bir kere çalışsın istediğimizden bunu kullandık . (0) ise mouse un sol tuşunu ifade eder.
        {
            ChangeBallDirection();
        }
    }

    private void ChangeBallDirection()
    {
        if(ballDirection.x == -1)
        {
            ballDirection = Vector3.forward;
        }
        else
        {
            ballDirection = Vector3.left;
        }
    }
}
