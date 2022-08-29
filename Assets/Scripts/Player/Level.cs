using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Level1End"))
        {
            SceneManager.LoadScene("Level2");
        }

        if (other.gameObject.CompareTag("Level2End"))
        {
            SceneManager.LoadScene("Level3");
        }

        if (other.gameObject.CompareTag("Level3End"))
        {
            SceneManager.LoadScene("Level1");
        }
    }

    
}
