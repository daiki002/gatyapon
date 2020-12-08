using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

 

public class ButManager : MonoBehaviour
{

    public GameObject Panel;

   public void ResetGame()
    {
        SceneManager.LoadScene("Game");
    }

    public void TiteSceen()
    {
        SceneManager.LoadScene("Titel");
    }

    public void ClosePanel()
    {
        Panel.SetActive(false);
    }
   
}
