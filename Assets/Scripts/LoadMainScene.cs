using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadMainScene : MonoBehaviour
{
    public void LoadMainSceneFunction()
    {
        SceneManager.LoadScene("MainScene");
        
    }
}
