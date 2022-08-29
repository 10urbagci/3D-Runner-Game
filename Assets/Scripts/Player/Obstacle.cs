using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Obstacle : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Obstacle"))
        {
            //SceneManager.LoadScene("Level1");
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
