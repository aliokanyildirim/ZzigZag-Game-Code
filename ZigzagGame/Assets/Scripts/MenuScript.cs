using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 
//sahne y�netimi komutlar� i�in bu k�t�phaneyi import etmeliyiz.

public class MenuScript : MonoBehaviour
{
   public void PlayButton()
    {
        SceneManager.LoadScene(1);
    }

    public void QuitButton()
    {
        Application.Quit(); // bu fonksiyonla oyunu kapat�r.
    }
}
