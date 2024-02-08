using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndGoal : MonoBehaviour
{
    public GameObject winText;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        winText.SetActive(true);
    }
}
