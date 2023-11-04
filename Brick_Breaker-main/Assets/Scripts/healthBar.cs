using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class CanBari : MonoBehaviour
{
    
   public Image canbari;
    public float can;
    public float startcan;
    public void onTakeDamage(int damage)
    {
        can = can - damage;
        canbari.fillAmount = can / startcan;
    }
    // boss canı 0 olunca win sahnesine geçsin
    void Update()
    {
        if(can<=0)
        {

           SceneManager.LoadScene("win");
           
        }
        
        
    }
    
    



    
}
