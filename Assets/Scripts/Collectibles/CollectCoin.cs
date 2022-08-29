using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CollectCoin : MonoBehaviour
{

    [SerializeField] private TMP_Text coinCount;

    int score;

    private void Start()
    {
        score = 0;
    }

    private void Update()
    {
        coinCount.text = score.ToString();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Coin"))
        {
            score++;
            Destroy(other.gameObject);
        }
    }

}
