using System.Collections;
using System.Collections.Generic;
using UnityEditor;

using UnityEngine;
using UnityEngine.SceneManagement;


public class MenuDeGameOver : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        FindAnyObjectByType<Musicas>().TocarMusicaDeGameOver();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ReiniciarPartida()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void SairDoJogo()
    {
        Application.Quit();
        Debug.Log("Saiu do Jogo");
    }
}
