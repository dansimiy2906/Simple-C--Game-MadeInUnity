using UnityEngine.SceneManagement;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public void PlayGame(){
    	SceneManager.LoadScene("funrun");

    }
    public void QuitGame(){
    	Application.Quit();
    }
}
