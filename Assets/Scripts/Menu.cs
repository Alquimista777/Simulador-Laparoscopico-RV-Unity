using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{


    public void openNuevaPartida()
    {
        Application.LoadLevel("Nivel1-Colores");

    }


    public void openNivel1()
    {
        Application.LoadLevel("Nivel1-Colores");
    }

    public void openNivel2() {
        Application.LoadLevel("Nivel2-Agarrar");
    }

    public void openNivel3()
    {
        Application.LoadLevel("Nivel3-Cortar");
    }
    public void openNivel4()
    {
        Application.LoadLevel("Nivel4-Quirofano");
    }
	public void openTurorial()
	{
		Application.LoadLevel("Tutorials");
	}
    public void OpenUi() {
        Application.LoadLevel("UI");
    }

	public void iniciarTimer(){
		GameObject.Find ("Robot1").SendMessage ("Inicar");
	}

	public void pauseTimer(){
		GameObject.Find ("Robot1").SendMessage ("Finnish");
	}



    public void salirApp() { Application.Quit(); }


}




