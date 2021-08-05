using UnityEngine.SceneManagement;
using UnityEngine;

public class Events : MonoBehaviour
{
    public void ReplayGame(){
    	SceneManager.LoadScene("funrun");

    }
    public void QuitGame(){
    	Application.Quit();
    }

    public void level2(){
    	SceneManager.LoadScene("level2");
    }
}
