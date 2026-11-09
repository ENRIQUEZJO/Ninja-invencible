using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FruitManager : MonoBehaviour
{
    public TextMeshProUGUI textoContador;
    private int frutasRecogidas = 0; // Esta variable debe volver a cero

    void Awake()
    {
        // Forzamos el reinicio manual de la variable matemática al cargar la escena
        frutasRecogidas = 0; 
    }

    void Start()
    {
        // Aseguramos que el texto visual en pantalla muestre "Frutas: 0" al arrancar
        ActualizarTexto();
    }

    public void AllFruitCollected()
    {
        frutasRecogidas++;
        ActualizarTexto();

        // Tu lógica original basada en los objetos hijo del manager
        if (transform.childCount == 1)
        {
            Debug.Log("No quedan frutas, Victoria");

            MenuManager menu = FindFirstObjectByType<MenuManager>();
            if (menu != null)
            {
                menu.MostrarPantallaFin();
            }
        }
    }

    void ActualizarTexto()
    {
        if (textoContador != null)
        {
            textoContador.text = "Frutas: " + frutasRecogidas;
        }
    }
}
