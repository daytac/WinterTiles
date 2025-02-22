using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menuScript : MonoBehaviour
{ 
    public GameObject menu;
    public GameObject game;
    public GameObject level2;
   public void anaMenuGit()
   {
       menu.SetActive(true);
       game.SetActive(false);
       level2.SetActive(false);

   }

   public void oyunGit()
   {
       menu.SetActive(false);   
       level2.SetActive(false);
       Time.timeScale=1;
       game.SetActive(true);
   }
}
