using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;


public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public TextMeshProUGUI textoPuntuacion;   // nuevo correcto
    public TextMeshProUGUI textoHighScore;    // nuevo correcto

    public int puntuacion = 0;
    private int highScore = 0;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }

        // Cargar highscore guardado
        highScore = PlayerPrefs.GetInt("HighScoreHelix", 0);
        ActualizarUI();
    }

    public void SumarPunto()
    {
        puntuacion++;
        ActualizarUI();

        // Guardar highscore si es nuevo récord
        if (puntuacion > highScore)
        {
            highScore = puntuacion;
            PlayerPrefs.SetInt("HighScoreHelix", highScore);
            PlayerPrefs.Save();
        }
    }

    void ActualizarUI()
    {
        if (textoPuntuacion != null)
            textoPuntuacion.text = "Score: " + puntuacion;

        if (textoHighScore != null)
            textoHighScore.text = "Best: " + highScore;
    }

    // Para reiniciar si la bola se cae mucho
    public void ReiniciarJuego()
    {
        SceneManager.LoadScene("JuegoPrincipal");
    }
}