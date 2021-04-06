using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class opcionesmenu : MonoBehaviour
{
    // Start is called before the first frame update
    public void Salir()
    {
        Application.Quit();
    }
    public void Pausa() {
        Time.timeScale = 0f;
    }
    public void Volver()
    {
        Time.timeScale = 1f;
    }
}
