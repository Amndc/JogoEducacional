using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GerencExp : MonoBehaviour
{
    [SerializeField]
    public TextMeshProUGUI tituloText;

    [SerializeField]
    public TextMeshProUGUI ExpText;

    public Animator anim;


    private Queue<string> sentences;

    public string fasePCarregar;

    // Start is called before the first frame update
    void Start()
    {
        sentences = new Queue<string>();
    }

    public void StartDialogo(Dialogo dialogo)
    {
        anim.SetBool("IsOpen", true);
        tituloText.text = dialogo.nameNPC;

        sentences.Clear();

        foreach (string sentence in dialogo.sentences)
        {
            sentences.Enqueue(sentence);
        }

        DisplayNextSentence();
    }

    public void DisplayNextSentence()
    {
        if (sentences.Count == 0)
        {
            EndDialogo();
            return;
        }

        string sentence = sentences.Dequeue();
        ExpText.text = sentence;
    }

    void EndDialogo()
    {
        anim.SetBool("IsOpen", false);
        SceneManager.LoadScene(fasePCarregar);
    }
}
