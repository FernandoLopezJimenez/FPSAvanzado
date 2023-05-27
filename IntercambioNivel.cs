using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class IntercambioNivel : MonoBehaviour
{

    public Image fade;
    public Color alpha;
    //public GameObject Player;
    public GameObject objetoMuerte;
    public bool estasEnSuelo = true;
    public bool gameOver = false;
    


    // Start is called before the first frame update
    void Start()
    {
        alpha = fade.color; 
    }


    public void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Suelo"))
        {
            estasEnSuelo = true;
        }
        else if ((collision.gameObject.CompareTag("Muerte")) || (collision.gameObject.CompareTag("Enemigo")))
        {
            gameOver = true;
            StartCoroutine(FinDelJuego());
        }
        
        IEnumerator FinDelJuego()
        {
            while (alpha.a < 1)
            {
                alpha.a += 0.05f;
                fade.color = alpha;
                yield return new WaitForSeconds(0.01f);
            }
            SceneManager.LoadScene("Derrota");
        }

    }

     
}
