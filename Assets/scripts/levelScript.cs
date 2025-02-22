using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelScript : MonoBehaviour
{
    public GameObject level2;
    public GameObject game;
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            level2.SetActive(true);
            game.SetActive(false);
        }
    }   
}
