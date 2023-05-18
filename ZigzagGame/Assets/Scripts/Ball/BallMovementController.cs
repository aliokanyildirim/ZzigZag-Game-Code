using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BallMovementController : MonoBehaviour
{
    [HideInInspector] public Vector3 ballDirection;

    [SerializeField] private BallDataTransmiter ballDataTransmiter;

    [SerializeField] private float ballMoveSpeed;

    public int puan = 0;
    private void Start()
    {
        puan = 0;
        ballDirection = Vector3.left;
       
    }
    private void Update()
    {
        SetBallMovement();
        oyunBitti();
        esc();
        if (Input.GetMouseButtonDown(0))
        {
            puan = puan + 1;
        }

    }

    private void SetBallMovement()
    {
        transform.position += ballDataTransmiter.GetBallDirection() * ballMoveSpeed * Time.deltaTime;
    }
    
   void oyunBitti()
    {
        if(gameObject.transform.position.y < -8 )
        {
            Time.timeScale = 0;
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
             Time.timeScale = 1;
            
        }

    }
    void esc()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene(0);
        }
        
    }

    private void Dokunmatik()
    {
        if(Input.touchCount> 0)
        {
           Touch týklama = Input.GetTouch(0);

            if (ballDirection.x == -1)
            {
                ballDirection = Vector3.forward;
            }
            else
            {
                ballDirection = Vector3.left;
            }
        }
    }
}
