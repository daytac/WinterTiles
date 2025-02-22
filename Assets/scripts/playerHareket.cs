using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class playerHareket : MonoBehaviour
{

    Rigidbody2D rb2d;
    Vector3 hareket;
    float hiz=5f;
    float ziplaHiz=7f;
    public int skor;
    public Animator anim;
    public TextMeshProUGUI skorText;
    // Start is called before the first frame update
    void Start()
    {
        rb2d=GetComponent<Rigidbody2D>();
        skor=0;
    }

    // Update is called once per frame
    void Update()
    {
        skorText.text = skor.ToString();
        hareket=new Vector3(Input.GetAxis("Horizontal"),0f);
        transform.position+=hareket*hiz*Time.deltaTime;

        anim.SetFloat("speed", Mathf.Abs(Input.GetAxis("Horizontal")));

        if(Input.GetButtonDown("Jump")&&Mathf.Approximately(rb2d.velocity.y,0))
        {
            rb2d.AddForce(Vector3.up* ziplaHiz, ForceMode2D.Impulse);  
            anim.SetBool("jumping",true); 
        }

        if(anim.GetBool ("jumping") && Mathf.Approximately(rb2d.velocity.y,0))  
        {
            anim.SetBool("jumping",false);
        }
        if(Input.GetAxisRaw("Horizontal") == -1)
        {
            transform.rotation = Quaternion.Euler(0f, 180f, 0f); 
        }
        else if(Input.GetAxisRaw("Horizontal") == 1)
        {
            transform.rotation = Quaternion.Euler(0f, 0f, 0f); 
        }
    }
}
