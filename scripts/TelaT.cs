using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TelaT : MonoBehaviour
{



    public float DistMin;
    private float distancia;
    private GameObject player;
    public string fasePCarregar;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        Distancia();
        
    }

    void Distancia()
    {
        distancia = Vector3.Distance(transform.position, player.transform.position);

        if (distancia <= DistMin )
        {
            SceneManager.LoadScene(fasePCarregar);
        }
    }
}
