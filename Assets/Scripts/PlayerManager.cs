using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
	public static bool gameover;
    public static bool youwon;
	public GameObject GameOverPanel;
    public GameObject YouWonPanel;


    void Start()
    {
    	gameover = false;
        Time.timeScale = 1;

        youwon = false;

        
    }

    // Update is called once per frame
    void Update()
    {
    	if(gameover){
    		Time.timeScale = 0;
    		GameOverPanel.SetActive(true);
    	}
        else if(youwon){
            Time.timeScale = 0;
            YouWonPanel.SetActive(true);

        }
        
    }
}
