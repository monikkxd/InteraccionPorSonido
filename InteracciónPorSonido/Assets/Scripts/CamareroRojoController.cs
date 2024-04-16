using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CamareroRojoController : MonoBehaviour
{
    
    [SerializeField]
    private bool useVoiceRecognition; // si se usa o no reconocimiento de voz

    public Transform platoA;
    public Transform platoB;
    public Transform platoC;
    public Transform platoD;

    public Transform mesa1;
    public Transform mesa2;
    public Transform mesa3;
    public Transform mesa4;
    public Transform mesa5;
    public Transform mesa6;

    public Transform camareroRojoPos;

    public GameObject FoodA;
    public GameObject FoodB;
    public GameObject FoodC;
    public GameObject FoodD;

    public GameObject PlatoAmesa1;
    public GameObject PlatoAmesa2;
    public GameObject PlatoAmesa3;
    public GameObject PlatoAmesa4;
    public GameObject PlatoAmesa5;
    public GameObject PlatoAmesa6;

    public GameObject PlatoBmesa1;
    public GameObject PlatoBmesa2;
    public GameObject PlatoBmesa3;
    public GameObject PlatoBmesa4;
    public GameObject PlatoBmesa5;
    public GameObject PlatoBmesa6;

    public GameObject PlatoCmesa1;
    public GameObject PlatoCmesa2;
    public GameObject PlatoCmesa3;
    public GameObject PlatoCmesa4;
    public GameObject PlatoCmesa5;
    public GameObject PlatoCmesa6;

    public GameObject PlatoDmesa1;
    public GameObject PlatoDmesa2;
    public GameObject PlatoDmesa3;
    public GameObject PlatoDmesa4;
    public GameObject PlatoDmesa5;
    public GameObject PlatoDmesa6;


    public float velocidad = 5.0f;

    

    private Transform objetivo;

    public void FixedUpdate()
    {
        
    }

    //Acciones de Movimiento para reconocimiento de Voz

    public void RojoAuno()
    {

        objetivo = platoA;
        StartCoroutine(MoverObjeto(objetivo));

        IEnumerator MoverObjeto(Transform destino)
        {
            Vector3 origen = transform.position;
            float distancia = Vector3.Distance(origen, destino.position);
            float tiempoInicio = Time.time;

            while (transform.position != destino.position)
            {
                float tiempoTranscurrido = (Time.time - tiempoInicio) * velocidad;
                float fraccionDeRecorrido = tiempoTranscurrido / distancia;
                transform.position = Vector3.Lerp(origen, destino.position, fraccionDeRecorrido);
                yield return null;
            }

            // Cambiar el destino al siguiente punto
            if (destino == platoA)
            {
                FoodA.SetActive(true);
                objetivo = mesa1;
            }

            else if (destino == mesa1)
            {
                objetivo = camareroRojoPos;
                FoodA.SetActive(false);
                PlatoAmesa1.SetActive(true);
            }
            else
            {

                // Si llega al punto C, terminar la corutina
                yield break;
            }

            // Iniciar la corutina para mover el GameObject al próximo punto
            StartCoroutine(MoverObjeto(objetivo));
        }
    }

    public void RojoAdos()
    {
        objetivo = platoA;
        StartCoroutine(MoverObjeto(objetivo));

        IEnumerator MoverObjeto(Transform destino)
        {
            Vector3 origen = transform.position;
            float distancia = Vector3.Distance(origen, destino.position);
            float tiempoInicio = Time.time;

            while (transform.position != destino.position)
            {
                float tiempoTranscurrido = (Time.time - tiempoInicio) * velocidad;
                float fraccionDeRecorrido = tiempoTranscurrido / distancia;
                transform.position = Vector3.Lerp(origen, destino.position, fraccionDeRecorrido);
                yield return null;
            }

            // Cambiar el destino al siguiente punto
            if (destino == platoA)
            {
                FoodA.SetActive(true);
                objetivo = mesa2;
            }

            else if (destino == mesa2)
            {
                objetivo = camareroRojoPos;
                FoodA.SetActive(false);
                PlatoAmesa2.SetActive(true);
            }
            else
            {

                // Si llega al punto C, terminar la corutina
                yield break;
            }

            // Iniciar la corutina para mover el GameObject al próximo punto
            StartCoroutine(MoverObjeto(objetivo));
        }
    }

    public void RojoAtres()
    {
        objetivo = platoA;
        StartCoroutine(MoverObjeto(objetivo));

        IEnumerator MoverObjeto(Transform destino)
        {
            Vector3 origen = transform.position;
            float distancia = Vector3.Distance(origen, destino.position);
            float tiempoInicio = Time.time;

            while (transform.position != destino.position)
            {
                float tiempoTranscurrido = (Time.time - tiempoInicio) * velocidad;
                float fraccionDeRecorrido = tiempoTranscurrido / distancia;
                transform.position = Vector3.Lerp(origen, destino.position, fraccionDeRecorrido);
                yield return null;
            }

            // Cambiar el destino al siguiente punto
            if (destino == platoA)
            {
                FoodA.SetActive(true);
                objetivo = mesa3;
            }

            else if (destino == mesa3)
            {
                objetivo = camareroRojoPos;
                FoodA.SetActive(false);
                PlatoAmesa3.SetActive(true);
            }
            else
            {

                // Si llega al punto C, terminar la corutina
                yield break;
            }

            // Iniciar la corutina para mover el GameObject al próximo punto
            StartCoroutine(MoverObjeto(objetivo));
        }
    }

    public void RojoAcuatro()
    {
        objetivo = platoA;
        StartCoroutine(MoverObjeto(objetivo));

        IEnumerator MoverObjeto(Transform destino)
        {
            Vector3 origen = transform.position;
            float distancia = Vector3.Distance(origen, destino.position);
            float tiempoInicio = Time.time;

            while (transform.position != destino.position)
            {
                float tiempoTranscurrido = (Time.time - tiempoInicio) * velocidad;
                float fraccionDeRecorrido = tiempoTranscurrido / distancia;
                transform.position = Vector3.Lerp(origen, destino.position, fraccionDeRecorrido);
                yield return null;
            }

            // Cambiar el destino al siguiente punto
            if (destino == platoA)
            {
                FoodA.SetActive(true);
                objetivo = mesa4;
            }

            else if (destino == mesa4)
            {
                objetivo = camareroRojoPos;
                FoodA.SetActive(false);
                PlatoAmesa4.SetActive(true);
            }
            else
            {

                // Si llega al punto C, terminar la corutina
                yield break;
            }

            // Iniciar la corutina para mover el GameObject al próximo punto
            StartCoroutine(MoverObjeto(objetivo));
        }
    }

    public void RojoAcinco()
    {
        objetivo = platoA;
        StartCoroutine(MoverObjeto(objetivo));

        IEnumerator MoverObjeto(Transform destino)
        {
            Vector3 origen = transform.position;
            float distancia = Vector3.Distance(origen, destino.position);
            float tiempoInicio = Time.time;

            while (transform.position != destino.position)
            {
                float tiempoTranscurrido = (Time.time - tiempoInicio) * velocidad;
                float fraccionDeRecorrido = tiempoTranscurrido / distancia;
                transform.position = Vector3.Lerp(origen, destino.position, fraccionDeRecorrido);
                yield return null;
            }

            // Cambiar el destino al siguiente punto
            if (destino == platoA)
            {
                FoodA.SetActive(true);
                objetivo = mesa5;
            }

            else if (destino == mesa5)
            {
                objetivo = camareroRojoPos;
                FoodA.SetActive(false);
                PlatoAmesa5.SetActive(true);
            }
            else
            {

                // Si llega al punto C, terminar la corutina
                yield break;
            }

            // Iniciar la corutina para mover el GameObject al próximo punto
            StartCoroutine(MoverObjeto(objetivo));
        }
    }

    public void RojoAseis()
    {
        objetivo = platoA;
        StartCoroutine(MoverObjeto(objetivo));

        IEnumerator MoverObjeto(Transform destino)
        {
            Vector3 origen = transform.position;
            float distancia = Vector3.Distance(origen, destino.position);
            float tiempoInicio = Time.time;

            while (transform.position != destino.position)
            {
                float tiempoTranscurrido = (Time.time - tiempoInicio) * velocidad;
                float fraccionDeRecorrido = tiempoTranscurrido / distancia;
                transform.position = Vector3.Lerp(origen, destino.position, fraccionDeRecorrido);
                yield return null;
            }

            // Cambiar el destino al siguiente punto
            if (destino == platoA)
            {
                FoodA.SetActive(true);
                objetivo = mesa6;
            }

            else if (destino == mesa6)
            {
                objetivo = camareroRojoPos;
                FoodA.SetActive(false);
                PlatoAmesa6.SetActive(true);
            }
            else
            {

                // Si llega al punto C, terminar la corutina
                yield break;
            }

            // Iniciar la corutina para mover el GameObject al próximo punto
            StartCoroutine(MoverObjeto(objetivo));
        }
    }

    public void RojoBuno()
    {
        objetivo = platoB;
        StartCoroutine(MoverObjeto(objetivo));

        IEnumerator MoverObjeto(Transform destino)
        {
            Vector3 origen = transform.position;
            float distancia = Vector3.Distance(origen, destino.position);
            float tiempoInicio = Time.time;

            while (transform.position != destino.position)
            {
                float tiempoTranscurrido = (Time.time - tiempoInicio) * velocidad;
                float fraccionDeRecorrido = tiempoTranscurrido / distancia;
                transform.position = Vector3.Lerp(origen, destino.position, fraccionDeRecorrido);
                yield return null;
            }

            // Cambiar el destino al siguiente punto
            if (destino == platoB)
            {
                FoodB.SetActive(true);
                objetivo = mesa1;
            }

            else if (destino == mesa1)
            {
                objetivo = camareroRojoPos;
                FoodB.SetActive(false);
                PlatoBmesa1.SetActive(true);
            }
            else
            {

                // Si llega al punto C, terminar la corutina
                yield break;
            }

            // Iniciar la corutina para mover el GameObject al próximo punto
            StartCoroutine(MoverObjeto(objetivo));
        }

    }

    public void RojoBdos()
    {
        objetivo = platoB;
        StartCoroutine(MoverObjeto(objetivo));

        IEnumerator MoverObjeto(Transform destino)
        {
            Vector3 origen = transform.position;
            float distancia = Vector3.Distance(origen, destino.position);
            float tiempoInicio = Time.time;

            while (transform.position != destino.position)
            {
                float tiempoTranscurrido = (Time.time - tiempoInicio) * velocidad;
                float fraccionDeRecorrido = tiempoTranscurrido / distancia;
                transform.position = Vector3.Lerp(origen, destino.position, fraccionDeRecorrido);
                yield return null;
            }

            // Cambiar el destino al siguiente punto
            if (destino == platoB)
            {
                FoodB.SetActive(true);
                objetivo = mesa2;
            }

            else if (destino == mesa2)
            {
                objetivo = camareroRojoPos;
                FoodB.SetActive(false);
                PlatoBmesa2.SetActive(true);
            }
            else
            {

                // Si llega al punto C, terminar la corutina
                yield break;
            }

            // Iniciar la corutina para mover el GameObject al próximo punto
            StartCoroutine(MoverObjeto(objetivo));
        }
    }

    public void RojoBtres()
    {
        objetivo = platoB;
        StartCoroutine(MoverObjeto(objetivo));

        IEnumerator MoverObjeto(Transform destino)
        {
            Vector3 origen = transform.position;
            float distancia = Vector3.Distance(origen, destino.position);
            float tiempoInicio = Time.time;

            while (transform.position != destino.position)
            {
                float tiempoTranscurrido = (Time.time - tiempoInicio) * velocidad;
                float fraccionDeRecorrido = tiempoTranscurrido / distancia;
                transform.position = Vector3.Lerp(origen, destino.position, fraccionDeRecorrido);
                yield return null;
            }

            // Cambiar el destino al siguiente punto
            if (destino == platoB)
            {
                FoodB.SetActive(true);
                objetivo = mesa3;
            }

            else if (destino == mesa3)
            {
                objetivo = camareroRojoPos;
                FoodB.SetActive(false);
                PlatoBmesa3.SetActive(true);
            }
            else
            {

                // Si llega al punto C, terminar la corutina
                yield break;
            }

            // Iniciar la corutina para mover el GameObject al próximo punto
            StartCoroutine(MoverObjeto(objetivo));
        }
    }

    public void RojoBcuatro()
    {
        objetivo = platoB;
        StartCoroutine(MoverObjeto(objetivo));

        IEnumerator MoverObjeto(Transform destino)
        {
            Vector3 origen = transform.position;
            float distancia = Vector3.Distance(origen, destino.position);
            float tiempoInicio = Time.time;

            while (transform.position != destino.position)
            {
                float tiempoTranscurrido = (Time.time - tiempoInicio) * velocidad;
                float fraccionDeRecorrido = tiempoTranscurrido / distancia;
                transform.position = Vector3.Lerp(origen, destino.position, fraccionDeRecorrido);
                yield return null;
            }

            // Cambiar el destino al siguiente punto
            if (destino == platoB)
            {
                FoodB.SetActive(true);
                objetivo = mesa4;
            }

            else if (destino == mesa4)
            {
                objetivo = camareroRojoPos;
                FoodB.SetActive(false);
                PlatoBmesa4.SetActive(true);
            }
            else
            {

                // Si llega al punto C, terminar la corutina
                yield break;
            }

            // Iniciar la corutina para mover el GameObject al próximo punto
            StartCoroutine(MoverObjeto(objetivo));
        }
    }

    public void RojoBcinco()
    {
        objetivo = platoB;
        StartCoroutine(MoverObjeto(objetivo));

        IEnumerator MoverObjeto(Transform destino)
        {
            Vector3 origen = transform.position;
            float distancia = Vector3.Distance(origen, destino.position);
            float tiempoInicio = Time.time;

            while (transform.position != destino.position)
            {
                float tiempoTranscurrido = (Time.time - tiempoInicio) * velocidad;
                float fraccionDeRecorrido = tiempoTranscurrido / distancia;
                transform.position = Vector3.Lerp(origen, destino.position, fraccionDeRecorrido);
                yield return null;
            }

            // Cambiar el destino al siguiente punto
            if (destino == platoB)
            {
                FoodB.SetActive(true);
                objetivo = mesa5;
            }

            else if (destino == mesa5)
            {
                objetivo = camareroRojoPos;
                FoodB.SetActive(false);
                PlatoBmesa5.SetActive(true);
            }
            else
            {

                // Si llega al punto C, terminar la corutina
                yield break;
            }

            // Iniciar la corutina para mover el GameObject al próximo punto
            StartCoroutine(MoverObjeto(objetivo));
        }
    }

    public void RojoBseis()
    {
        objetivo = platoB;
        StartCoroutine(MoverObjeto(objetivo));

        IEnumerator MoverObjeto(Transform destino)
        {
            Vector3 origen = transform.position;
            float distancia = Vector3.Distance(origen, destino.position);
            float tiempoInicio = Time.time;

            while (transform.position != destino.position)
            {
                float tiempoTranscurrido = (Time.time - tiempoInicio) * velocidad;
                float fraccionDeRecorrido = tiempoTranscurrido / distancia;
                transform.position = Vector3.Lerp(origen, destino.position, fraccionDeRecorrido);
                yield return null;
            }

            // Cambiar el destino al siguiente punto
            if (destino == platoB)
            {
                FoodB.SetActive(true);
                objetivo = mesa6;
            }

            else if (destino == mesa6)
            {
                objetivo = camareroRojoPos;
                FoodB.SetActive(false);
                PlatoBmesa6.SetActive(true);
            }
            else
            {

                // Si llega al punto C, terminar la corutina
                yield break;
            }

            // Iniciar la corutina para mover el GameObject al próximo punto
            StartCoroutine(MoverObjeto(objetivo));
        }
    }

    public void RojoCuno()
    {
        objetivo = platoC;
        StartCoroutine(MoverObjeto(objetivo));

        IEnumerator MoverObjeto(Transform destino)
        {
            Vector3 origen = transform.position;
            float distancia = Vector3.Distance(origen, destino.position);
            float tiempoInicio = Time.time;

            while (transform.position != destino.position)
            {
                float tiempoTranscurrido = (Time.time - tiempoInicio) * velocidad;
                float fraccionDeRecorrido = tiempoTranscurrido / distancia;
                transform.position = Vector3.Lerp(origen, destino.position, fraccionDeRecorrido);
                yield return null;
            }

            // Cambiar el destino al siguiente punto
            if (destino == platoC)
            {
                FoodC.SetActive(true);
                objetivo = mesa1;
            }

            else if (destino == mesa1)
            {
                objetivo = camareroRojoPos;
                FoodC.SetActive(false);
                PlatoCmesa1.SetActive(true);
            }
            else
            {

                // Si llega al punto C, terminar la corutina
                yield break;
            }

            // Iniciar la corutina para mover el GameObject al próximo punto
            StartCoroutine(MoverObjeto(objetivo));
        }
    }

    public void RojoCdos()
    {
        objetivo = platoC;
        StartCoroutine(MoverObjeto(objetivo));

        IEnumerator MoverObjeto(Transform destino)
        {
            Vector3 origen = transform.position;
            float distancia = Vector3.Distance(origen, destino.position);
            float tiempoInicio = Time.time;

            while (transform.position != destino.position)
            {
                float tiempoTranscurrido = (Time.time - tiempoInicio) * velocidad;
                float fraccionDeRecorrido = tiempoTranscurrido / distancia;
                transform.position = Vector3.Lerp(origen, destino.position, fraccionDeRecorrido);
                yield return null;
            }

            // Cambiar el destino al siguiente punto
            if (destino == platoC)
            {
                FoodC.SetActive(true);
                objetivo = mesa2;
            }

            else if (destino == mesa2)
            {
                objetivo = camareroRojoPos;
                FoodC.SetActive(false);
                PlatoCmesa2.SetActive(true);
            }
            else
            {

                // Si llega al punto C, terminar la corutina
                yield break;
            }

            // Iniciar la corutina para mover el GameObject al próximo punto
            StartCoroutine(MoverObjeto(objetivo));
        }
    }

    public void RojoCtres()
    {
        objetivo = platoC;
        StartCoroutine(MoverObjeto(objetivo));

        IEnumerator MoverObjeto(Transform destino)
        {
            Vector3 origen = transform.position;
            float distancia = Vector3.Distance(origen, destino.position);
            float tiempoInicio = Time.time;

            while (transform.position != destino.position)
            {
                float tiempoTranscurrido = (Time.time - tiempoInicio) * velocidad;
                float fraccionDeRecorrido = tiempoTranscurrido / distancia;
                transform.position = Vector3.Lerp(origen, destino.position, fraccionDeRecorrido);
                yield return null;
            }

            // Cambiar el destino al siguiente punto
            if (destino == platoC)
            {
                FoodC.SetActive(true);
                objetivo = mesa3;
            }

            else if (destino == mesa3)
            {
                objetivo = camareroRojoPos;
                FoodC.SetActive(false);
                PlatoCmesa3.SetActive(true);
            }
            else
            {

                // Si llega al punto C, terminar la corutina
                yield break;
            }

            // Iniciar la corutina para mover el GameObject al próximo punto
            StartCoroutine(MoverObjeto(objetivo));
        }
    }

    public void RojoCcuatro()
    {
        objetivo = platoC;
        StartCoroutine(MoverObjeto(objetivo));

        IEnumerator MoverObjeto(Transform destino)
        {
            Vector3 origen = transform.position;
            float distancia = Vector3.Distance(origen, destino.position);
            float tiempoInicio = Time.time;

            while (transform.position != destino.position)
            {
                float tiempoTranscurrido = (Time.time - tiempoInicio) * velocidad;
                float fraccionDeRecorrido = tiempoTranscurrido / distancia;
                transform.position = Vector3.Lerp(origen, destino.position, fraccionDeRecorrido);
                yield return null;
            }

            // Cambiar el destino al siguiente punto
            if (destino == platoC)
            {
                FoodC.SetActive(true);
                objetivo = mesa4;
            }

            else if (destino == mesa4)
            {
                objetivo = camareroRojoPos;
                FoodC.SetActive(false);
                PlatoCmesa4.SetActive(true);
            }
            else
            {

                // Si llega al punto C, terminar la corutina
                yield break;
            }

            // Iniciar la corutina para mover el GameObject al próximo punto
            StartCoroutine(MoverObjeto(objetivo));
        }
    }

    public void RojoCcinco()
    {
        objetivo = platoC;
        StartCoroutine(MoverObjeto(objetivo));

        IEnumerator MoverObjeto(Transform destino)
        {
            Vector3 origen = transform.position;
            float distancia = Vector3.Distance(origen, destino.position);
            float tiempoInicio = Time.time;

            while (transform.position != destino.position)
            {
                float tiempoTranscurrido = (Time.time - tiempoInicio) * velocidad;
                float fraccionDeRecorrido = tiempoTranscurrido / distancia;
                transform.position = Vector3.Lerp(origen, destino.position, fraccionDeRecorrido);
                yield return null;
            }

            // Cambiar el destino al siguiente punto
            if (destino == platoC)
            {
                FoodC.SetActive(true);
                objetivo = mesa5;
            }

            else if (destino == mesa5)
            {
                objetivo = camareroRojoPos;
                FoodC.SetActive(false);
                PlatoCmesa5.SetActive(true);
            }
            else
            {

                // Si llega al punto C, terminar la corutina
                yield break;
            }

            // Iniciar la corutina para mover el GameObject al próximo punto
            StartCoroutine(MoverObjeto(objetivo));
        }
    }

    public void RojoCseis()
    {
        objetivo = platoC;
        StartCoroutine(MoverObjeto(objetivo));

        IEnumerator MoverObjeto(Transform destino)
        {
            Vector3 origen = transform.position;
            float distancia = Vector3.Distance(origen, destino.position);
            float tiempoInicio = Time.time;

            while (transform.position != destino.position)
            {
                float tiempoTranscurrido = (Time.time - tiempoInicio) * velocidad;
                float fraccionDeRecorrido = tiempoTranscurrido / distancia;
                transform.position = Vector3.Lerp(origen, destino.position, fraccionDeRecorrido);
                yield return null;
            }

            // Cambiar el destino al siguiente punto
            if (destino == platoC)
            {
                FoodC.SetActive(true);
                objetivo = mesa6;
            }

            else if (destino == mesa6)
            {
                objetivo = camareroRojoPos;
                FoodC.SetActive(false);
                PlatoCmesa6.SetActive(true);
            }
            else
            {

                // Si llega al punto C, terminar la corutina
                yield break;
            }

            // Iniciar la corutina para mover el GameObject al próximo punto
            StartCoroutine(MoverObjeto(objetivo));
        }
    }

    public void RojoDuno()
    {
        objetivo = platoD;
        StartCoroutine(MoverObjeto(objetivo));

        IEnumerator MoverObjeto(Transform destino)
        {
            Vector3 origen = transform.position;
            float distancia = Vector3.Distance(origen, destino.position);
            float tiempoInicio = Time.time;

            while (transform.position != destino.position)
            {
                float tiempoTranscurrido = (Time.time - tiempoInicio) * velocidad;
                float fraccionDeRecorrido = tiempoTranscurrido / distancia;
                transform.position = Vector3.Lerp(origen, destino.position, fraccionDeRecorrido);
                yield return null;
            }

            // Cambiar el destino al siguiente punto
            if (destino == platoD)
            {
                FoodD.SetActive(true);
                objetivo = mesa1;
            }

            else if (destino == mesa1)
            {
                objetivo = camareroRojoPos;
                FoodD.SetActive(false);
                PlatoDmesa1.SetActive(true);
            }
            else
            {

                // Si llega al punto C, terminar la corutina
                yield break;
            }

            // Iniciar la corutina para mover el GameObject al próximo punto
            StartCoroutine(MoverObjeto(objetivo));
        }
    }

    public void RojoDdos()
    {
        objetivo = platoD;
        StartCoroutine(MoverObjeto(objetivo));

        IEnumerator MoverObjeto(Transform destino)
        {
            Vector3 origen = transform.position;
            float distancia = Vector3.Distance(origen, destino.position);
            float tiempoInicio = Time.time;

            while (transform.position != destino.position)
            {
                float tiempoTranscurrido = (Time.time - tiempoInicio) * velocidad;
                float fraccionDeRecorrido = tiempoTranscurrido / distancia;
                transform.position = Vector3.Lerp(origen, destino.position, fraccionDeRecorrido);
                yield return null;
            }

            // Cambiar el destino al siguiente punto
            if (destino == platoD)
            {
                FoodD.SetActive(true);
                objetivo = mesa2;
            }

            else if (destino == mesa2)
            {
                objetivo = camareroRojoPos;
                FoodD.SetActive(false);
                PlatoDmesa2.SetActive(true);
            }
            else
            {

                // Si llega al punto C, terminar la corutina
                yield break;
            }

            // Iniciar la corutina para mover el GameObject al próximo punto
            StartCoroutine(MoverObjeto(objetivo));
        }
    }

    public void RojoDtres()
    {
        objetivo = platoD;
        StartCoroutine(MoverObjeto(objetivo));

        IEnumerator MoverObjeto(Transform destino)
        {
            Vector3 origen = transform.position;
            float distancia = Vector3.Distance(origen, destino.position);
            float tiempoInicio = Time.time;

            while (transform.position != destino.position)
            {
                float tiempoTranscurrido = (Time.time - tiempoInicio) * velocidad;
                float fraccionDeRecorrido = tiempoTranscurrido / distancia;
                transform.position = Vector3.Lerp(origen, destino.position, fraccionDeRecorrido);
                yield return null;
            }

            // Cambiar el destino al siguiente punto
            if (destino == platoD)
            {
                FoodD.SetActive(true);
                objetivo = mesa3;
            }

            else if (destino == mesa3)
            {
                objetivo = camareroRojoPos;
                FoodD.SetActive(false);
                PlatoDmesa3.SetActive(true);
            }
            else
            {

                // Si llega al punto C, terminar la corutina
                yield break;
            }

            // Iniciar la corutina para mover el GameObject al próximo punto
            StartCoroutine(MoverObjeto(objetivo));
        }
    }

    public void RojoDcuatro()
    {
        objetivo = platoD;
        StartCoroutine(MoverObjeto(objetivo));

        IEnumerator MoverObjeto(Transform destino)
        {
            Vector3 origen = transform.position;
            float distancia = Vector3.Distance(origen, destino.position);
            float tiempoInicio = Time.time;

            while (transform.position != destino.position)
            {
                float tiempoTranscurrido = (Time.time - tiempoInicio) * velocidad;
                float fraccionDeRecorrido = tiempoTranscurrido / distancia;
                transform.position = Vector3.Lerp(origen, destino.position, fraccionDeRecorrido);
                yield return null;
            }

            // Cambiar el destino al siguiente punto
            if (destino == platoD)
            {
                FoodD.SetActive(true);
                objetivo = mesa4;
            }

            else if (destino == mesa4)
            {
                objetivo = camareroRojoPos;
                FoodD.SetActive(false);
                PlatoDmesa4.SetActive(true);
            }
            else
            {

                // Si llega al punto C, terminar la corutina
                yield break;
            }

            // Iniciar la corutina para mover el GameObject al próximo punto
            StartCoroutine(MoverObjeto(objetivo));
        }
    }

    public void RojoDcinco()
    {
        objetivo = platoD;
        StartCoroutine(MoverObjeto(objetivo));

        IEnumerator MoverObjeto(Transform destino)
        {
            Vector3 origen = transform.position;
            float distancia = Vector3.Distance(origen, destino.position);
            float tiempoInicio = Time.time;

            while (transform.position != destino.position)
            {
                float tiempoTranscurrido = (Time.time - tiempoInicio) * velocidad;
                float fraccionDeRecorrido = tiempoTranscurrido / distancia;
                transform.position = Vector3.Lerp(origen, destino.position, fraccionDeRecorrido);
                yield return null;
            }

            // Cambiar el destino al siguiente punto
            if (destino == platoD)
            {
                FoodD.SetActive(true);
                objetivo = mesa5;
            }

            else if (destino == mesa5)
            {
                objetivo = camareroRojoPos;
                FoodD.SetActive(false);
                PlatoDmesa5.SetActive(true);
            }
            else
            {

                // Si llega al punto C, terminar la corutina
                yield break;
            }

            // Iniciar la corutina para mover el GameObject al próximo punto
            StartCoroutine(MoverObjeto(objetivo));
        }
    }

    public void RojoDseis()
    {
        objetivo = platoD;
        StartCoroutine(MoverObjeto(objetivo));

        IEnumerator MoverObjeto(Transform destino)
        {
            Vector3 origen = transform.position;
            float distancia = Vector3.Distance(origen, destino.position);
            float tiempoInicio = Time.time;

            while (transform.position != destino.position)
            {
                float tiempoTranscurrido = (Time.time - tiempoInicio) * velocidad;
                float fraccionDeRecorrido = tiempoTranscurrido / distancia;
                transform.position = Vector3.Lerp(origen, destino.position, fraccionDeRecorrido);
                yield return null;
            }

            // Cambiar el destino al siguiente punto
            if (destino == platoD)
            {
                FoodD.SetActive(true);
                objetivo = mesa6;
            }

            else if (destino == mesa6)
            {
                objetivo = camareroRojoPos;
                FoodD.SetActive(false);
                PlatoDmesa6.SetActive(true);
            }
            else
            {

                // Si llega al punto C, terminar la corutina
                yield break;
            }

            // Iniciar la corutina para mover el GameObject al próximo punto
            StartCoroutine(MoverObjeto(objetivo));
        }
    }
}


