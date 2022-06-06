using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BalaoDeFala : MonoBehaviour
{
  
    private float distancia;

    private GameObject player;

    [SerializeField]
    public float DistMin;

    [SerializeField] GameObject Importante;

    [SerializeField] GameObject Lousa;


    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        Balao();
        
    }

    public void Balao()
    {
        distancia = Vector3.Distance(transform.position, player.transform.position);

        if (distancia <= DistMin)
        {
            Importante.SetActive(true);
        }

    }

    public void OnMouseDown()
    {

        Destroy(Importante);          
        Lousa.SetActive(true);
            
    }
}

