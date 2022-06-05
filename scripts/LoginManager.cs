using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;


public class LoginManager : MonoBehaviour
{


    public GameObject MenuCerto;
    public GameObject MenuErrado;

    [SerializeField]
    private InputField Email = null;
    [SerializeField]
    private InputField Senha = null;

    private string url = "http://localhost/unity/api/login.php";







    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void FazerLogin()
    {
        string email = Email.text;
        string senha1 = Senha.text;

        WWW www = new WWW (url + "?email=" + email + "&senha=" + senha1);
        StartCoroutine(ValidaLogin(www));
    }


    IEnumerator ValidaLogin(WWW www)
    {
        yield return www;

        if(www.error == null)
        {
            print(www.text);
            if (www.text == " 1")
            {
                MenuCerto.SetActive(true);
            }
            else
            {
                MenuErrado.SetActive(true);
                
            }
        }
        else
        {
            print(www.error);
        }
    }
     
}
