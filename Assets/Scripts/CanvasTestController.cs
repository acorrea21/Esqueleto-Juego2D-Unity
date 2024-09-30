using TMPro;
using UnityEngine;

public class CanvasTestController : MonoBehaviour
{
    // Clip de audio que se reproducirá
    [SerializeField] private AudioClip clip;

    // Referencia al texto donde se mostrará el puntaje
    [SerializeField] private TextMeshProUGUI scoreText;

    private void Update()
    {
        // Actualizar el texto en la UI para mostrar el puntaje actual
        scoreText.text = "Puntaje: " + GameController.score.ToString();
    }

    // Este método se llamará al hacer OnClick en el boton
    public void PlayClip()
    {
        // Reproducir el clip de audio usando el AudioManager
        AudioManager.PlaySound(clip);
    }

    // Este método se llamará al hacer OnClick en el boton
    public void AddScore()
    {
        // Agregar puntos a la puntuación del juego
        GameController.AddScore();
    }
}
