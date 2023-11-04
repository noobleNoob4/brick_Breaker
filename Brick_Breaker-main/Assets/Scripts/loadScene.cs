using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
   
   
    public void LoadNextScene()
    {
        int a = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(a + 1);

    }
    public void LoadStartScene()
    {
        SceneManager.LoadScene(1);

    }
    public void QuitGame()
    {
        Application.Quit();
    }
    
    






}
