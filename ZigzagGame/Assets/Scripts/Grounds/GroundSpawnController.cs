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
        groundDirection = Random.Range(0, 2); // burada sýfýr dahilken 2 dahil olmaz 
        
        if(groundDirection == 0)
        {
            newGroundObject = Instantiate(groundPrefab, new Vector3(lastGroundObject.transform.position.x - 1f, lastGroundObject.transform.position.y, lastGroundObject.transform.position.z ), Quaternion.identity);
            lastGroundObject = newGroundObject;
         // Instantiate , örneklendirme ile mevcut bir objeyi yeniden oluþturma ya da klonlama iþlemidir.
         //1-quaternion sýnýfý objelerin dönüþ iþlemlerinde kullanýlýr , transform sýnýfý da öyledir ama bazen hesaplamayla ilgili sorunlar
         //1.1-olur bu yüzden quaternion sýnýfýnýn 4.bir açý mantýðý oldugunda hesaplamalarda daha net sonuclar alýnýr. 
        // identity özelliði sayesinde objede bulunan mevcut rotasyonlarý sýfýrlayabilirsiniz.
         }
        else
        {
            newGroundObject = Instantiate(groundPrefab, new Vector3(lastGroundObject.transform.position.x, lastGroundObject.transform.position.y, lastGroundObject.transform.position.z + 1f), Quaternion.identity);
            lastGroundObject = newGroundObject;
        }
    }
   
}
