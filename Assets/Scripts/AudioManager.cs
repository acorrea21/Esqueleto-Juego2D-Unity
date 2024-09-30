using UnityEngine;

//Este es el ejemplo de un posible AudioManager
public class AudioManager : MonoBehaviour
{
    //Encapsulacion, solo puede ser modificado por el mismo
    public static AudioManager Instance { get; private set; }

    public AudioSource soundSource;

    private void Awake()
    {
        // Verificar si ya hay una instancia
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject); // No destruir el objeto al cambiar de escena
        }
        else
        {
            Destroy(gameObject); // Destruir el objeto si ya existe una instancia
        }
    }

    /// <summary>
    /// Reproduce un sonido una vez
    /// </summary>
    /// <param name="clip">     Clip de audio</param>
    /// <param name="volume">   Volumen del sonido, desde 0 a 1</param>
    public static void PlaySound(AudioClip clip, float volume = 1f)
    {
        //Se accede a la instancia en escena y reproduce un sonido en su AudioSource
        Instance.soundSource.PlayOneShot(clip,volume);
    }

}
