using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Hasaryemek : MonoBehaviour
{


    public CanBari canBari;
    

    
    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag=="b")
        {
            if(canBari)
            {
                canBari.onTakeDamage(15);
                
                
                    
            
                
                
            }
            
            
        }
       
    }
    
    

    
    

    

}
