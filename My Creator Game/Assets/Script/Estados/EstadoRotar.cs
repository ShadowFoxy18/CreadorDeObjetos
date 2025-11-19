using UnityEngine;

public class EstadoRotar : MonoBehaviour, IEstadoObjeto
{
    public void EntrarEstado(StateMachineObject stateObjeto)
    {
        Debug.Log("Entrando en el estado Rotar");
    }

    public void EjecutarEstado(StateMachineObject stateObjeto)
    {
        Debug.Log("Ejecutando el estado Rotar");
    }

    public void SalirEstado(StateMachineObject stateObjeto)
    {
        Debug.Log("Saliendo del estado Rotar");
    }
}
