using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CountDownTimer : MonoBehaviour
{
    public TextMeshProUGUI countdownText;
    private float totalTime = 60f;
    private float timeLeft;

    void Start()
    {
        timeLeft = totalTime;
    }

    void Update()
    {
        timeLeft -= Time.deltaTime;

        if (timeLeft <= 0)
        {
            timeLeft = 0;
            // Aquí puedes agregar cualquier acción que quieras realizar al finalizar la cuenta atrás
            Debug.Log("Cuenta atrás finalizada");
            SceneManager.LoadScene("SampleScene");
        }

        UpdateTimerDisplay();
    }

    void UpdateTimerDisplay()
    {
        int seconds = Mathf.RoundToInt(timeLeft % 60);
        countdownText.text = seconds.ToString();
    }
}

