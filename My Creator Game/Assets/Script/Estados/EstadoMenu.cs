using UnityEngine;

public class EstadoMenu : MonoBehaviour, IEstadoObjeto
{
    [SerializeField]
    GameObject canvasElegir, canvasCrear, canvasMover, canvasRotar, canvasEliminar;

    public void EntrarEstado(StateMachineObject stateObjeto)
    {
        Debug.Log("Entrando en el estado Menú");
    }

    public void EjecutarEstado(StateMachineObject stateObjeto)
    {
        Debug.Log("Ejecutando el estado Menú");
    }

    public void SalirEstado(StateMachineObject stateObjeto)
    {
        Debug.Log("Saliendo del estado Menú");
    }
}
