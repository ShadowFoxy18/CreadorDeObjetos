using UnityEngine;

public class EstadoMover : IEstadoObjeto
{
    private StateMachineObject stateObjetoMenu;

    public void EntrarEstado(StateMachineObject stateObjeto)
    {
        stateObjetoMenu = stateObjeto;

        Debug.Log("Entrando en el estado Mover");
        stateObjeto._canvasMover.SetActive(true);
    }

    public void EjecutarEstado(StateMachineObject stateObjeto)
    {
    }

    public void SalirEstado(StateMachineObject stateObjeto)
    {
        stateObjeto._canvasMover.SetActive(false);
        Debug.Log("Saliendo del estado Mover");
    }
}
