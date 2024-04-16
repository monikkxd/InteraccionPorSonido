using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagerUwu : MonoBehaviour
{
    // Start is called before the first frame update
    public void Salir()
    {
        Application.Quit();
    }

    // Update is called once per frame
    public void Empezarjuego()
    {
        SceneManager.LoadScene("CarScene");
    }
}
