using UnityEngine;

public class EstadoMenu : MonoBehaviour, IEstadoObjeto
{
    [SerializeField]
    GameObject canvasElegir, canvasCrear, canvasMover, canvasRotar, canvasEliminar;

    public void EntrarEstado(StateMachineObject stateObjeto)
    {
        canvasElegir.SetActive(true);  
        Debug.Log("Entrando en el estado Menú");
    }


    public void ButtonCrear(StateMachineObject stateObjeto)
    {
        stateObjeto.CambiarEstado(new EstadoCrear());
        canvasElegir.SetActive(false);
        canvasCrear.SetActive(true);
    }


    public void ButtonMover(StateMachineObject stateObjeto)
    {
        stateObjeto.CambiarEstado(new EstadoMover());
        canvasCrear.SetActive(false);
        canvasMover.SetActive(true);
    }


    public void ButtonRotar(StateMachineObject stateObjeto)
    {
        stateObjeto.CambiarEstado(new EstadoRotar());
        canvasCrear.SetActive(false);
        canvasRotar.SetActive(true);
    }


    public void ButtonEliminar(StateMachineObject stateObjeto)
    {
        stateObjeto.CambiarEstado(new EstadoEliminar());
        canvasCrear.SetActive(false);
        canvasEliminar.SetActive(true);
    }


    public void EjecutarEstado(StateMachineObject stateObjeto)
    {
        Debug.Log("Ejecutando el estado Menú");
    }

    public void SalirEstado(StateMachineObject stateObjeto)
    {
        canvasElegir.SetActive(false);
        Debug.Log("Saliendo del estado Menú");
    }
}
