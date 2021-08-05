using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDown : MonoBehaviour
{
   int countdownstart = 10;
   public Text timer;
   public AudioClip failed;
   public AudioSource audioplayer;

    void Start()
    {
    	countDownTimer();
        
    }

    void countDownTimer(){
    	if(countdownstart > 0){
    		timer.text = "Time Left: " + countdownstart;
    		countdownstart--;
    		Invoke("countDownTimer",1.0f);
    	}
    	else{
            PlayerManager.gameover = true;
            audioplayer.PlayOneShot(failed);


    	}
    }

    
    void Update()
    {
    
        
    }
}

