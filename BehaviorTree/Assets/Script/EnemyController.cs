using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.UI;

public class EnemyController : GameController
{
    [SerializeField] private Canvas deadCanvas;
    public void Start()
    {
        deadCanvas.gameObject.SetActive(false);
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            map.gameObject.SetActive(false);
            deadCanvas.gameObject.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
