using UnityEngine.SceneManagement;
using UnityEngine;

public class Level2Events : MonoBehaviour
{
    public void ReplayGame(){
    	SceneManager.LoadScene("level2");

    }
    public void QuitGame(){
    	Application.Quit();
    }

    public void level2(){
    	SceneManager.LoadScene("funrun");
    }
}
