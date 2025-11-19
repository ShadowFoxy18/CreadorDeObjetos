using UnityEngine;

public class StateMachineObject : MonoBehaviour
{
    [SerializeField]
    GameObject canvasElegir, canvasCrear, canvasMover, canvasRotar, canvasEliminar;


    public IEstadoObjeto estadoActual;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StateInit();
    }


    void SalirEstado()
    {
        if (estadoActual != null)
        {
            estadoActual.SalirEstado(this);
            estadoActual = null;
        }
    }


    void CambiarEstado(IEstadoObjeto nuevoEstado)
    {
        if (estadoActual != null)
        {
            estadoActual.SalirEstado(this);
        }

        estadoActual = nuevoEstado;

        estadoActual.EntrarEstado(this);
    }


    void StateInit()
    {
        canvasElegir.SetActive(true);
        canvasCrear.SetActive(false);
    }


    public void ButtonCrear()
    {
        CambiarEstado(new EstadoCrear());
        canvasElegir.SetActive(false);
        canvasCrear.SetActive(true);
    }


    public void ButtonMover()
    {
        canvasCrear.SetActive(false);
        canvasMover.SetActive(true);
    }


    public void ButtonRotar()
    {
        canvasCrear.SetActive(false);
        canvasRotar.SetActive(true);
    }


    public void ButtonEliminar()
    {
        canvasCrear.SetActive(false);
        canvasEliminar.SetActive(true);
    }


    // Update is called once per frame
    void Update()
    {
        if (estadoActual != null)
        {
            estadoActual.EjecutarEstado(this);
        }
    }
}
