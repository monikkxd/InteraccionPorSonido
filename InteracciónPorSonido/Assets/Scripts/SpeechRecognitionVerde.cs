using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Windows.Speech;
using System.Linq;
using TMPro;

public class SpeechRecognitionVerde : MonoBehaviour
{

    public TextMeshProUGUI myTMP;

    private KeywordRecognizer reconocePalabras;
    private ConfidenceLevel confidencialidad = ConfidenceLevel.Low;
    private Dictionary<string, Accion> palabrasAccion = new Dictionary<string, Accion>();
    private CamareroVerdeController CamareroController;

    //crear Delegado para la acción a ejecutar
    private delegate void Accion();

    // Start is called before the first frame update
    void Start()
    {
        CamareroController = GetComponent<CamareroVerdeController>();

        
        //Camarero Verde

        palabrasAccion.Add("verde A uno", CamareroController.VerdeAuno);
        palabrasAccion.Add("verde A dos", CamareroController.VerdeAdos);
        palabrasAccion.Add("verde A tres", CamareroController.VerdeAtres);
        palabrasAccion.Add("verde A cuatro", CamareroController.VerdeAcuatro);
        palabrasAccion.Add("verde A cinco", CamareroController.VerdeAcinco);
        palabrasAccion.Add("verde A seis", CamareroController.VerdeAseis);

        palabrasAccion.Add("verde B uno", CamareroController.VerdeBuno);
        palabrasAccion.Add("verde B dos", CamareroController.VerdeBdos);
        palabrasAccion.Add("verde B tres", CamareroController.VerdeBtres);
        palabrasAccion.Add("verde B cuatro", CamareroController.VerdeBcuatro);
        palabrasAccion.Add("verde B cinco", CamareroController.VerdeBcinco);
        palabrasAccion.Add("verde B seis", CamareroController.VerdeBseis);

        palabrasAccion.Add("verde C uno", CamareroController.VerdeCuno);
        palabrasAccion.Add("verde C dos", CamareroController.VerdeCdos);
        palabrasAccion.Add("verde C tres", CamareroController.VerdeCtres);
        palabrasAccion.Add("verde C cuatro", CamareroController.VerdeCcuatro);
        palabrasAccion.Add("verde C cinco", CamareroController.VerdeCcinco);
        palabrasAccion.Add("verde C seis", CamareroController.VerdeCseis);

        palabrasAccion.Add("verde D uno", CamareroController.VerdeDuno);
        palabrasAccion.Add("verde D dos", CamareroController.VerdeDdos);
        palabrasAccion.Add("verde D tres", CamareroController.VerdeDtres);
        palabrasAccion.Add("verde D cuatro", CamareroController.VerdeDcuatro);
        palabrasAccion.Add("verde D cinco", CamareroController.VerdeDcinco);
        palabrasAccion.Add("verde D seis", CamareroController.VerdeDseis);

        


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
