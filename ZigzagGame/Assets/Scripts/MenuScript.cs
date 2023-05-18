using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 
//sahne yönetimi komutlarý için bu kütüphaneyi import etmeliyiz.

public class MenuScript : MonoBehaviour
{
   public void PlayButton()
    {
        SceneManager.LoadScene(1);
    }

    public void QuitButton()
    {
        Application.Quit(); // bu fonksiyonla oyunu kapatýr.
    }
}
