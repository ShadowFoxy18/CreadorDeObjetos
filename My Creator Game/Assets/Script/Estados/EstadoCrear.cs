using UnityEngine;

public class EstadoCrear : MonoBehaviour, IEstadoObjeto
{


    public void EntrarEstado(StateMachineObject stateObjeto)
    {
        Debug.Log("Entrando en el estado Crear");
    }

    public void EjecutarEstado(StateMachineObject stateObjeto)
    {
        
    }

    public void SalirEstado(StateMachineObject stateObjeto)
    {
        Debug.Log("Saliendo del estado Crear");
    }
}
