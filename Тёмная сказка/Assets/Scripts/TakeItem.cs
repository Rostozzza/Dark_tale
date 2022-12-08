using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TakeItem : MonoBehaviour
{
    public int coins = 0;
    [SerializeField] public TextMeshProUGUI coinsText;

    void Update()
    {
        coinsText.text = "Денги: " + coins.ToString();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Money"))
        {
            coins += 1;
            Destroy(other.gameObject);
        }
    }
}
