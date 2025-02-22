using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    
     public  void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag.Equals("Player"))//Player tagındaki nesne ile 
        //çarpışma olduğunda algılanmasını sağlar
        {
            playerHareket oyuncu=collision.gameObject.GetComponent<playerHareket>();
            //oyuncuHareket classını içe aktardık
            oyuncu.skor+=5; //oyuncu nun içindeki score u 5 arttırdık
            gameObject.SetActive(false);//oyun objesini(coini) görünmez hale getirdik
        }
    }
}
