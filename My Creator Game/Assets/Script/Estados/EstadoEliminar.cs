using UnityEngine;

public class EstadoEliminar : MonoBehaviour, IEstadoObjeto
{
    [SerializeField]
    GameObject canvasEliminar;

    public void EntrarEstado(StateMachineObject stateObjeto)
    {
        Debug.Log("Entrando en el estado Eliminar");
        canvasEliminar.SetActive(true);
    }

    public void EjecutarEstado(StateMachineObject stateObjeto)
    {
        Debug.Log("Ejecutando el estado Eliminar");
    }

    public void SalirEstado(StateMachineObject stateObjeto)
    {
        canvasEliminar.SetActive(false);
        Debug.Log("Saliendo del estado Eliminar");
    }
}
