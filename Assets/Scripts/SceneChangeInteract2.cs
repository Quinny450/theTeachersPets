using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChangeInteract2 : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        SceneManager.LoadScene("Level_Alpha");
    }
}
