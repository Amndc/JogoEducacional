using System.Collections;
using System.Collections.Generic;
using System.Net.Sockets;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerController : MonoBehaviour
{
    public float speed;
    public Animator anim;
    
    
    Rigidbody2D Rig;
    public string nomedaCena;

    
  



[System.Obsolete]
    void Start()
    {
        Rig = GetComponent<Rigidbody2D>();

        nomedaCena = SceneManager.GetActiveScene().name;

        
        
    }

    // Start is called before the first frame update
    void Update()
    {
        Move();






         
       
        
    }

    // Update is called once per frame

    void Move()
    {
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
       


        anim.SetFloat("Horizontal", movement.x);
        anim.SetFloat("Vertical", movement.y);
        anim.SetFloat("Speed", movement.magnitude);

      
        transform.position = transform.position + movement * speed * Time.deltaTime; 

        


    }
    // PERSONAGEM TELETRANSPORTAR
    private void OnTriggerEnter2D(Collider2D collision)
    {

        //Por layer do objeto

        if (collision.name == "Op1" || collision.name == "Op2" || collision.name == "Op3" || collision.name == "Op4")
        {
            anim.transform.position = new Vector3(-3, -3, 0);   
        }


    }

}


