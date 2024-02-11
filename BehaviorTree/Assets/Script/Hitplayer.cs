using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Image = UnityEngine.UI.Image;
public class Hitplayer : MonoBehaviour
{
    public Canvas deadCanvas;
    public Image map;
    
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
