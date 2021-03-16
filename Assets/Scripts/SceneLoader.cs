using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void BtnChangeScene(string scene_name)
    {
        Debug.Log("Onclick");
        SceneManager.LoadScene(scene_name);
    }
}
