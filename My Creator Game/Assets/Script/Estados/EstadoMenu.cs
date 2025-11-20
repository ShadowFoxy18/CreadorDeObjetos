using UnityEngine;

public class EstadoMenu : IEstadoObjeto
{

    public void EntrarEstado(StateMachineObject stateObjeto)
    {
        stateObjeto._canvasElegir.SetActive(true);  
        Debug.Log("Entrando en el estado Menú");
    }

    public void EjecutarEstado(StateMachineObject stateObjeto)
    {
    }

    public void SalirEstado(StateMachineObject stateObjeto)
    {
        stateObjeto._canvasElegir.SetActive(false);
        Debug.Log("Saliendo del estado Menú");
    }
}
