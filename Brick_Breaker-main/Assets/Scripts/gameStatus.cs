using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameStatus : MonoBehaviour
{
    [Range(0.1f,10f)][SerializeField] float gameSpeed = 1f;
    [SerializeField] int pointBlockDestroyed = 20;
     

    
    
    [SerializeField]  TextMeshProUGUI textscore;
 
    [SerializeField] int currentScore =0;
    
    private void Awake()
    {
        int gameStatusCount = FindObjectsOfType<GameStatus>().Length;
        if(gameStatusCount > 1)
        {
            gameObject.SetActive(false);
            Destroy(gameObject);

        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }







    void Start()
    {
        textscore.text = currentScore.ToString();

    }








    
    void Update()
    {
        Time.timeScale = gameSpeed;
    }

    public void AddToScore()
    {

        currentScore += pointBlockDestroyed;
        textscore.text = currentScore.ToString();
        
    }
    
    
}
