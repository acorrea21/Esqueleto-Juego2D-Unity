using TMPro;
using UnityEngine;

public class CanvasTestController : MonoBehaviour
{
    // Clip de audio que se reproducir�
    [SerializeField] private AudioClip clip;

    // Referencia al texto donde se mostrar� el puntaje
    [SerializeField] private TextMeshProUGUI scoreText;

    private void Update()
    {
        // Actualizar el texto en la UI para mostrar el puntaje actual
        scoreText.text = "Puntaje: " + GameController.score.ToString();
    }

    // Este m�todo se llamar� al hacer OnClick en el boton
    public void PlayClip()
    {
        // Reproducir el clip de audio usando el AudioManager
        AudioManager.PlaySound(clip);
    }

    // Este m�todo se llamar� al hacer OnClick en el boton
    public void AddScore()
    {
        // Agregar puntos a la puntuaci�n del juego
        GameController.AddScore();
    }
}
