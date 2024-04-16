using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Windows.Speech;
using System.Linq;
using TMPro;

public class SpeechRecognition : MonoBehaviour
{

    public TextMeshProUGUI myTMP;

    private KeywordRecognizer reconocePalabras;
    private ConfidenceLevel confidencialidad = ConfidenceLevel.Low;
    private Dictionary<string, Accion> palabrasAccion = new Dictionary<string, Accion>();
    private CamareroRojoController CamareroController;

    //crear Delegado para la acción a ejecutar
    private delegate void Accion();

    // Start is called before the first frame update
    void Start()
    {
        CamareroController = GetComponent<CamareroRojoController>();

        //Camarero rojo
        palabrasAccion.Add("rojo A uno", CamareroController.RojoAuno);
        palabrasAccion.Add("rojo A dos", CamareroController.RojoAdos);
        palabrasAccion.Add("rojo A tres", CamareroController.RojoAtres);
        palabrasAccion.Add("rojo A cuatro", CamareroController.RojoAcuatro);
        palabrasAccion.Add("rojo A cinco", CamareroController.RojoAcinco);
        palabrasAccion.Add("rojo A seis", CamareroController.RojoAseis);

        palabrasAccion.Add("rojo B uno", CamareroController.RojoBuno);
        palabrasAccion.Add("rojo B dos", CamareroController.RojoBdos);
        palabrasAccion.Add("rojo B tres", CamareroController.RojoBtres);
        palabrasAccion.Add("rojo B cuatro", CamareroController.RojoBcuatro);
        palabrasAccion.Add("rojo B cinco", CamareroController.RojoBcinco);
        palabrasAccion.Add("rojo B seis", CamareroController.RojoBseis);

        palabrasAccion.Add("rojo C uno", CamareroController.RojoCuno);
        palabrasAccion.Add("rojo C dos", CamareroController.RojoCdos);
        palabrasAccion.Add("rojo C tres", CamareroController.RojoCtres);
        palabrasAccion.Add("rojo C cuatro", CamareroController.RojoCcuatro);
        palabrasAccion.Add("rojo C cinco", CamareroController.RojoCcinco);
        palabrasAccion.Add("rojo C seis", CamareroController.RojoCseis);

        palabrasAccion.Add("rojo D uno", CamareroController.RojoDuno);
        palabrasAccion.Add("rojo D dos", CamareroController.RojoDdos);
        palabrasAccion.Add("rojo D tres", CamareroController.RojoDtres);
        palabrasAccion.Add("rojo D cuatro", CamareroController.RojoDcuatro);
        palabrasAccion.Add("rojo D cinco", CamareroController.RojoDcinco);
        palabrasAccion.Add("rojo D seis", CamareroController.RojoDseis);

        /*
        //Camarero Azul
        palabrasAccion.Add("azul A uno", CamareroController.AzulAuno);
        palabrasAccion.Add("azul A dos", CamareroController.MoveForward);
        palabrasAccion.Add("azul A tres", CamareroController.MoveForward);
        palabrasAccion.Add("azul A cuatro", CamareroController.MoveForward);
        palabrasAccion.Add("azul A cinco", CamareroController.MoveForward);
        palabrasAccion.Add("azul A seis", CamareroController.MoveForward);

        palabrasAccion.Add("azul B uno", CamareroController.MoveForward);
        palabrasAccion.Add("azul B dos", CamareroController.MoveForward);
        palabrasAccion.Add("azul B tres", CamareroController.MoveForward);
        palabrasAccion.Add("azul B cuatro", CamareroController.MoveForward);
        palabrasAccion.Add("azul B cinco", CamareroController.MoveForward);
        palabrasAccion.Add("azul B seis", CamareroController.MoveForward);

        palabrasAccion.Add("azul C uno", CamareroController.MoveForward);
        palabrasAccion.Add("azul C dos", CamareroController.MoveForward);
        palabrasAccion.Add("azul C tres", CamareroController.MoveForward);
        palabrasAccion.Add("azul C cuatro", CamareroController.MoveForward);
        palabrasAccion.Add("azul C cinco", CamareroController.MoveForward);
        palabrasAccion.Add("azul C seis", CamareroController.MoveForward);

        palabrasAccion.Add("azul D uno", CamareroController.MoveForward);
        palabrasAccion.Add("azul D dos", CamareroController.MoveForward);
        palabrasAccion.Add("azul D tres", CamareroController.MoveForward);
        palabrasAccion.Add("azul D cuatro", CamareroController.MoveForward);
        palabrasAccion.Add("azul D cinco", CamareroController.MoveForward);
        palabrasAccion.Add("azul D seis", CamareroController.MoveForward);

        //Camarero Verde

        palabrasAccion.Add("verde A uno", CamareroController.MoveForward);
        palabrasAccion.Add("verde A dos", CamareroController.MoveForward);
        palabrasAccion.Add("verde A tres", CamareroController.MoveForward);
        palabrasAccion.Add("verde A cuatro", CamareroController.MoveForward);
        palabrasAccion.Add("verde A cinco", CamareroController.MoveForward);
        palabrasAccion.Add("verde A seis", CamareroController.MoveForward);

        palabrasAccion.Add("verde B uno", CamareroController.MoveForward);
        palabrasAccion.Add("verde B dos", CamareroController.MoveForward);
        palabrasAccion.Add("verde B tres", CamareroController.MoveForward);
        palabrasAccion.Add("verde B cuatro", CamareroController.MoveForward);
        palabrasAccion.Add("verde B cinco", CamareroController.MoveForward);
        palabrasAccion.Add("verde B seis", CamareroController.MoveForward);

        palabrasAccion.Add("verde C uno", CamareroController.MoveForward);
        palabrasAccion.Add("verde C dos", CamareroController.MoveForward);
        palabrasAccion.Add("verde C tres", CamareroController.MoveForward);
        palabrasAccion.Add("verde C cuatro", CamareroController.MoveForward);
        palabrasAccion.Add("verde C cinco", CamareroController.MoveForward);
        palabrasAccion.Add("verde C seis", CamareroController.MoveForward);

        palabrasAccion.Add("verde D uno", CamareroController.MoveForward);
        palabrasAccion.Add("verde D dos", CamareroController.MoveForward);
        palabrasAccion.Add("verde D tres", CamareroController.MoveForward);
        palabrasAccion.Add("verde D cuatro", CamareroController.MoveForward);
        palabrasAccion.Add("verde D cinco", CamareroController.MoveForward);
        palabrasAccion.Add("verde D seis", CamareroController.MoveForward);

        */


        reconocePalabras = new KeywordRecognizer(palabrasAccion.Keys.ToArray(), confidencialidad);
        reconocePalabras.OnPhraseRecognized += OnKeywordsRecognized;
        reconocePalabras.Start();
    }

    void OnDestroy()
    {
        if (reconocePalabras != null && reconocePalabras.IsRunning)
        {
            reconocePalabras.Stop();
            reconocePalabras.Dispose();
        }
    }

    private void OnKeywordsRecognized(PhraseRecognizedEventArgs args)
    {
        myTMP.text = args.text;
        palabrasAccion[args.text].Invoke();
    }
}
