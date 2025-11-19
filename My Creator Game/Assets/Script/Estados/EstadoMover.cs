using UnityEngine;

public class EstadoMover : MonoBehaviour, IEstadoObjeto
{
    [SerializeField]
    GameObject canvasMover;

    public void EntrarEstado(StateMachineObject stateObjeto)
    {
        Debug.Log("Entrando en el estado Mover");
        canvasMover.SetActive(true);
    }

    public void EjecutarEstado(StateMachineObject stateObjeto)
    {
        Debug.Log("Ejecutando el estado Mover");
    }

    public void SalirEstado(StateMachineObject stateObjeto)
    {
        canvasMover.SetActive(false);
        Debug.Log("Saliendo del estado Mover");
    }
}
