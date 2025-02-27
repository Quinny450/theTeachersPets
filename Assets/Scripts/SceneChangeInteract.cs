using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChangeInteract : MonoBehaviour
{
    public void Update()
    {
        void OnTriggerEnter2D(Collider2D collision)
        {
        Debug.Log("Triggered");
        if (collision.CompareTag("Player"))
            {
            Debug.Log("Collided with Peyton Clayton");
            GameObject player = collision.gameObject;
            if (player.name == "Peyton Clayton")
            {
                Debug.Log("Scene Changed");
                SceneManager.LoadScene("Level_2_Alpha");
            }
            }
        }
    }
    
}
