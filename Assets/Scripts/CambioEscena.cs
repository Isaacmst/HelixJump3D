using UnityEngine;
using UnityEngine.SceneManagement;

public class CambioEscena : MonoBehaviour
{
    public void IrAJuegoPrincipal()
    {
        SceneManager.LoadScene("JuegoPrincipal");
    }

    public void IrAMenuPrincipal()
    {
        SceneManager.LoadScene("MenuPrincipal");
    }
}