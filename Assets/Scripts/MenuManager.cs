using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    // Casilla para arrastrar el panel que contiene el botón de reinicio
    public GameObject pantallaFinJuego;

    // 🌟 ASEGÚRATE DE QUE ESTA FUNCIÓN EXISTA Y SEA PUBLIC
    public void MostrarPantallaFin()
    {
        if (pantallaFinJuego != null)
        {
            pantallaFinJuego.SetActive(true);
        }
    }

    public void ReiniciarJuego()
    {
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name);
    }
}
