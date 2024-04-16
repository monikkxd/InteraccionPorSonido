using UnityEngine;
using System.Collections;

public class Pedidos : MonoBehaviour
{
    public GameObject[] objetos; // Array que contiene los GameObjects que deseas activar y desactivar

    IEnumerator Start()
    {
        while (true)
        {
            // Seleccionar aleatoriamente un objeto del array
            int indiceAleatorio = Random.Range(0, objetos.Length);
            GameObject objetoAleatorio = objetos[indiceAleatorio];

            // Activar el objeto seleccionado
            objetoAleatorio.SetActive(true);

            // Esperar 5 segundos
            yield return new WaitForSeconds(5f);

            // Desactivar el objeto después de 5 segundos
            objetoAleatorio.SetActive(false);

            // Esperar 5 segundos antes de continuar con el siguiente ciclo
            yield return new WaitForSeconds(5f);
        }
    }
}

