using System;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.SceneManagement;

public class test : MonoBehaviour
{
        public String sceneName;
        public bool isNextScene = true;

        [SerializeField]
        public SceneInfo sceneInfo;
    void OnTriggerEnter2D(Collider2D collision)
    {
        sceneInfo.isNextScene = isNextScene;
        SceneManager.LoadScene("Level_2_Alpha");
    }
}
