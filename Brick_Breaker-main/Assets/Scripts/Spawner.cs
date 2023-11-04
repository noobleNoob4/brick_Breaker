using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
   
   
    
    public GameObject[] spawners;
    public GameObject yumaklar;

    private void Start()
    {
        spawners = new GameObject[5];

        for(int i =0; i < spawners.Length; i++)
        {
            spawners[i] = transform.GetChild(i).gameObject;
            

        }
       
       
        

    }
    private void Update()
    {
    
        if(Input.GetKeyDown("space"))
        {
            SpawnEnemy();
        }
        
        
            
        
    }



        private void SpawnEnemy()
    {
        int spawnersgiris = Random.Range(0,spawners.Length);
        Instantiate(yumaklar,spawners[spawnersgiris].transform.position,spawners[spawnersgiris].transform.rotation);
    }

    




    
         

      
        
        
           
        


    
    




    
    
    




    











}
