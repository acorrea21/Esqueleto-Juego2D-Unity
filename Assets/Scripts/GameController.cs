using UnityEngine;

public class GameController : MonoBehaviour
{
    // Instancia est�tica del GameController
    public static GameController Instance { get; private set; }

    // Variable est�tica para almacenar la puntuaci�n
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

    // M�todo est�tico para agregar puntos a la puntuaci�n
    public static void AddScore()
    {
        score++; // Incrementar la puntuaci�n en 1
    }
}
