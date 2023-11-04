using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballmove : MonoBehaviour
{
   
    
    
    [SerializeField] AudioClip[] soundball;    //sesin duvardan sekmemesi içina array kullandık.
    // top ve pedalın birlikte hareket etmesi için paddel C# ile ballmove'u attachladık
    [SerializeField] paddel paddle1;
    [SerializeField] float xPush = 1f;
    [SerializeField] float yPush = 18.5f;

     AudioSource myAudioSource;
   
    
    Vector2 paddleToBallVector;
    bool hasStarted = false;


    void Start()
    {
        paddleToBallVector = transform.position - paddle1.transform.position;  // oyun başladığında pedal ile top arasındaki mesafe.
        myAudioSource = GetComponent<AudioSource>();
    }

    void Update()
    {   
      

        //if(hasStarted == false ile aynı anlamda)
        if(!hasStarted)
        {
           ConnectBalltoPaddle();
           LaunchOnSpaceClick();

        }
      

        

    }
    private void ConnectBalltoPaddle()
        {
            Vector2 paddlePos = new Vector2(paddle1.transform.position.x,paddle1.transform.position.y);
            transform.position = paddlePos + paddleToBallVector; //top ve pedal iç içe girmesin.
        }
        private void LaunchOnSpaceClick()
        {
            if(Input.GetKeyDown("space"))
            {
                hasStarted = true;
                GetComponent<Rigidbody2D>().velocity = new Vector2(xPush,yPush);
            }

        }
        //Sound Part.
        private void OnCollisionEnter2D(Collision2D collision)
        {
             if(hasStarted)  // ünlemsiz hali burası hasStarted = true demek.
         {
           AudioClip clip = soundball[UnityEngine.Random.Range(0,soundball.Length)];
           myAudioSource.PlayOneShot(clip); 
         } 
           
            
        
           
        }
        
       






        //Mouse tuşu ile oyun başlar
        // private void LaunchOnMouseClick()
        // {
           // if(Input.GetMouseButtonDown(0))
           // {
             //   hasStarted = true;
               // GetComponent<Rigidbody2D>().velocity = new Vector2(xPush,yPush);
         //   }

       //  }
      // void OnCollisionEnter2D(Collision2D collision)
      // {
       //    if(collision.transform.CompareTag("Squares"))
       //    {
         //      Destroy(collision.gameObject);
          // }
      // }
      
  
       
       
       
   
      
      


}
