using UnityEngine;

public class EstadoRotar : MonoBehaviour, IEstadoObjeto
{
    [SerializeField]
    GameObject canvasRotar;

    public void EntrarEstado(StateMachineObject stateObjeto)
    {
        Debug.Log("Entrando en el estado Rotar");
        canvasRotar.SetActive(true);
    }

    public void EjecutarEstado(StateMachineObject stateObjeto)
    {
        Debug.Log("Ejecutando el estado Rotar");
    }

    public void SalirEstado(StateMachineObject stateObjeto)
    {
        canvasRotar.SetActive(false);
        Debug.Log("Saliendo del estado Rotar");
    }
}
