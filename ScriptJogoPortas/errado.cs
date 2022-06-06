using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class errado : MonoBehaviour
{
    public GameObject errado1;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

        //Por layer do objeto
        if (collision.gameObject.CompareTag("Player"))
        {
            errado1.SetActive(true);
        }
    }
}
