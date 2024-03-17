
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayButton : MonoBehaviour
{
    public void LoadScene()
    {
        SceneManager.LoadScene("Assets/Scenes/Level_1.unity");

    }
}
