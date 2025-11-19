using UnityEngine;

public class UIButton : MonoBehaviour
{
    [SerializeField]
    private StateMachineObject stateMachine;

    void Start()
    {
        if (stateMachine == null)
        {
            stateMachine = GetComponent<StateMachineObject>();
        }
    }


    public void Crear() 
    {
        stateMachine.CambiarEstado(new EstadoCrear());
    }

    public void Mover()
    {
        stateMachine.CambiarEstado(new EstadoMover());
    }

    public void Rotar()
    {
        stateMachine.CambiarEstado(new EstadoRotar());
    }

    public void Eliminar()
    {
        stateMachine.CambiarEstado(new EstadoEliminar());
    }
    public void Back()
    {
        if (stateMachine.estadoAnterior != null)
        {
            stateMachine.CambiarEstado(stateMachine.estadoAnterior);
        }
    }
}
