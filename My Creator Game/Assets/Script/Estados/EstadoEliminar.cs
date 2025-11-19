using UnityEngine;

public class EstadoEliminar : IEstadoObjeto
{
    private StateMachineObject stateObjetoMenu;

    public void EntrarEstado(StateMachineObject stateObjeto)
    {
        stateObjetoMenu = stateObjeto;

        Debug.Log("Entrando en el estado Eliminar");
        stateObjeto._canvasEliminar.SetActive(true);
    }

    public void EjecutarEstado(StateMachineObject stateObjeto)
    {
        Debug.Log("Ejecutando el estado Eliminar");
    }

    public void SalirEstado(StateMachineObject stateObjeto)
    {
        stateObjeto._canvasEliminar.SetActive(false);
        Debug.Log("Saliendo del estado Eliminar");
    }
}
