using UnityEngine;

public class GameController : MonoBehaviour
{
    // Instancia estática del GameController
    public static GameController Instance { get; private set; }

    // Variable estática para almacenar la puntuación
    public static int score = 0;

    private void Awake()
    {
        // Verificar si ya hay una instancia existente
        if (Instance == null)
        {
            // Si no hay instancia, asignar esta a la instancia
            Instance = this;
            // No destruir este objeto al cambiar de escena
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            // Si ya existe una instancia, destruir este objeto
            Destroy(gameObject);
        }
    }

    // Método estático para agregar puntos a la puntuación
    public static void AddScore()
    {
        score++; // Incrementar la puntuación en 1
    }
}
