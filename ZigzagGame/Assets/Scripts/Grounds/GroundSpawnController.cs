using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundSpawnController : MonoBehaviour
{
    public GameObject lastGroundObject;

    [SerializeField] private GameObject groundPrefab;

    private GameObject newGroundObject;

    private int groundDirection;
   
    void Start()
    {
        GenerateRandomNewGrounds();
    }

    public void GenerateRandomNewGrounds()
    {
      for(int i= 0; i < 75; i++)
        {
            CreateNewGround();
        }
    }

    private void CreateNewGround()
    {
        groundDirection = Random.Range(0, 2); // burada s�f�r dahilken 2 dahil olmaz 
        
        if(groundDirection == 0)
        {
            newGroundObject = Instantiate(groundPrefab, new Vector3(lastGroundObject.transform.position.x - 1f, lastGroundObject.transform.position.y, lastGroundObject.transform.position.z ), Quaternion.identity);
            lastGroundObject = newGroundObject;
         // Instantiate , �rneklendirme ile mevcut bir objeyi yeniden olu�turma ya da klonlama i�lemidir.
         //1-quaternion s�n�f� objelerin d�n�� i�lemlerinde kullan�l�r , transform s�n�f� da �yledir ama bazen hesaplamayla ilgili sorunlar
         //1.1-olur bu y�zden quaternion s�n�f�n�n 4.bir a�� mant��� oldugunda hesaplamalarda daha net sonuclar al�n�r. 
        // identity �zelli�i sayesinde objede bulunan mevcut rotasyonlar� s�f�rlayabilirsiniz.
         }
        else
        {
            newGroundObject = Instantiate(groundPrefab, new Vector3(lastGroundObject.transform.position.x, lastGroundObject.transform.position.y, lastGroundObject.transform.position.z + 1f), Quaternion.identity);
            lastGroundObject = newGroundObject;
        }
    }
   
}
