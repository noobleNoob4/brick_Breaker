using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextLevelScreen : MonoBehaviour
{


    
    [SerializeField] int breakableBlocks;
    
    
    LoadScene sceneloader;
   



    private void Start()
    {
        sceneloader = FindObjectOfType<LoadScene>();
    }
    
    public void CountBreakableBlocks()
    {
        breakableBlocks++;

    }
    public void BlockDestroyed()
    {
        breakableBlocks--;
        
        
        if(breakableBlocks <= 0)
        {
            sceneloader.LoadNextScene();
        }
        
         



    }
  
    




    
}

