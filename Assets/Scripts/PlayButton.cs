
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayButton : MonoBehaviour
{
    public void LoadScene1()
    {
        SceneManager.LoadScene(1);
        Debug.LogError("pressed");
    }
}
