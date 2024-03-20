using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReloadOnEscape : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().name);
        }
    }
    void Start()
    {
        
    }

}
