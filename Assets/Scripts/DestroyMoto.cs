using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DestroyMoto : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
            
            Destroy(other.gameObject);
        SceneManager.LoadScene("Menu");

    }


}
