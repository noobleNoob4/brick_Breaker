using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paddel : MonoBehaviour
{
    [SerializeField] float paddelunits = 20f;
    [SerializeField] float minX= 1.07f;
    [SerializeField] float maxX = 18.896f;
    
    void Start()
    {
        Debug.Log(Input.mousePosition); //bunu buraya yazamayız çünkü 1 kere çalıştırır ve durur.
        
    } 
   
    void Update()
    {
        //paddle konum değiştirme.
        float mouseposition = Input.mousePosition.x/ Screen.width * paddelunits;    
        Vector2 paddlePos = new Vector2(transform.position.x,transform.position.y);
        paddlePos.x = Mathf.Clamp(mouseposition,minX,maxX);

        transform.position = paddlePos;

       
    }


    
}
