using UnityEngine;

public class EstadoRotar : IEstadoObjeto
{
    private StateMachineObject stateObjetoMenu;

    public void EntrarEstado(StateMachineObject stateObjeto)
    {
        stateObjetoMenu = stateObjeto;

        Debug.Log("Entrando en el estado Rotar");
        stateObjeto._canvasRotar.SetActive(true);
    }

    public void EjecutarEstado(StateMachineObject stateObjeto)
    {
        Debug.Log("Ejecutando el estado Rotar");
    }

    public void SalirEstado(StateMachineObject stateObjeto)
    {
        stateObjeto._canvasRotar.SetActive(false);
        Debug.Log("Saliendo del estado Rotar");
    }
}
