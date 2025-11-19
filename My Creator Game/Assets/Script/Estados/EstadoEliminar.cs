using UnityEngine;

public class EstadoEliminar : MonoBehaviour, IEstadoObjeto
{
    public void EntrarEstado(StateMachineObject stateObjeto)
    {
        Debug.Log("Entrando en el estado Eliminar");
    }

    public void EjecutarEstado(StateMachineObject stateObjeto)
    {
        Debug.Log("Ejecutando el estado Eliminar");
    }

    public void SalirEstado(StateMachineObject stateObjeto)
    {
        Debug.Log("Saliendo del estado Eliminar");
    }
}
