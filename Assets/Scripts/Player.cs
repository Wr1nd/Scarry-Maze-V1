using UnityEngine;

public class Player : MonoBehaviour
{
   
    void Update()
    {
        
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePosition.z = 0f; 

        transform.position = mousePosition;
    }
}