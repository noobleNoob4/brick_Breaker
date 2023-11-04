using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Deletegameobject : MonoBehaviour
{
 [SerializeField] AudioClip breakSound;
 
 NextLevelScreen buttonlevel;
 private void Start()
 {
    buttonlevel = FindObjectOfType<NextLevelScreen>();
    buttonlevel.CountBreakableBlocks();
    

 }
  [SerializeField]  Transform a;
  void OnCollisionEnter2D(Collision2D collision)
   {
      if(collision.transform.gameObject){
         Instantiate(a,collision.transform.position,collision.transform.rotation);
         


      }
      
      
       
     



      DestroyBlock();
          
      

       
       
       
       
   }
   private void DestroyBlock()
      {
        
               
               FindObjectOfType<GameStatus>().AddToScore();
               AudioSource.PlayClipAtPoint(breakSound,Camera.main.transform.position);
               Destroy (gameObject);
              buttonlevel.BlockDestroyed();

      
         
      }
      
      
    
    
      
   
         
      

      
       
   
        
       
   
}  
