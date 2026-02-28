using UnityEngine;
using UnityEngine.SceneManagement;

public class GhostController : MonoBehaviour
{
    public Animator animator;
    public GameObject botonSiguiente;

    void Start()
    {
        if (botonSiguiente != null)
        {
            botonSiguiente.SetActive(false);
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            animator.SetTrigger("Burn");
        }
    }

    // Esta función se llamará desde la animación de Smoke
    public void MostrarBoton()
    {
        if (botonSiguiente != null)
        {
            botonSiguiente.SetActive(true);
        }
    }

    // Esta función será para el botón
    public void IrASiguienteEscena()
    {
        SceneManager.LoadScene("NombreDeTuEscena");
    }
}