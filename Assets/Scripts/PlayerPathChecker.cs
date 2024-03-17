using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerPathChecker : MonoBehaviour
{
    private bool enteredNewPath = false;
    public string NextScene;

    private void OnTriggerExit2D(Collider2D other)
    {
       
        if (other.CompareTag("path"))
        {
            enteredNewPath = false; 
            
        }
        Check();
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
  
        if (other.CompareTag("path"))
        {
            enteredNewPath = true; 
        }
        if (other.CompareTag("teleporter") && !enteredNewPath)
        {
            SceneManager.LoadScene(NextScene);
            return;
        }

    }

    private void Check()
    {

        if (enteredNewPath == false);
        {
            SceneManager.LoadScene("Assets/Scenes/Intro.unity");
        }
    }


}