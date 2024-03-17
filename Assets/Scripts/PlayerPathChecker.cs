using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Video;

public class PlayerPathChecker : MonoBehaviour
{
    public string NextScene;
    public AudioSource scaryAudio;
    public GameObject Canvas;
    public VideoSource video;
    public GameObject deadzone;



    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("teleporter") )
        {
            SceneManager.LoadScene(NextScene);
            return;
        }

        if (other.CompareTag("death"))
        {
            SceneManager.LoadScene("Assets/Scenes/Intro.unity");
        }

        if (other.CompareTag("scarry"))
        {
            scaryAudio.Play() ;
            Canvas.SetActive(true);
            deadzone.SetActive(false) ;
        }
    }





}