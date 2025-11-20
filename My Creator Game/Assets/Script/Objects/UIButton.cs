using UnityEngine;

public class UIButton : MonoBehaviour
{
    [SerializeField]
    private StateMachineObject stateMachine;

    [SerializeField]
    public enum TipoDeCrear {vacio, Defensas, Entorno, back}
    public TipoDeCrear tipoDeCrear;
    private TipoDeCrear tipoActual;


    void Start()
    {
        stateMachine = FindAnyObjectByType<StateMachineObject>();
        if (stateMachine == null)
        {
            stateMachine = GetComponent<StateMachineObject>();
        }
    } 

    void Update()
    {
        if (stateMachine == null) return;

        switch (tipoActual)
        {
            case TipoDeCrear.Defensas:
                stateMachine._cSelecCrear.SetActive(false);
                stateMachine._canvasDefensas.SetActive(true);
                break;
            case TipoDeCrear.Entorno:
                stateMachine._cSelecCrear.SetActive(false);
                stateMachine._canvasEntorno.SetActive(true);
                break;
            

            //boton de volver
            case TipoDeCrear.back:
                stateMachine._canvasDefensas.SetActive(false);
                stateMachine._canvasEntorno.SetActive(false);
                stateMachine._cSelecCrear.SetActive(true);
                break;
            case TipoDeCrear.vacio:
                break;
        }   
        tipoActual = TipoDeCrear.vacio;
    }

    /// <summary>
    /// Botones del menú principal
    /// </summary>
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
    //
    
    /// <summary>
    /// Boton de elegir crear
    /// </summary>
    public void ElegirCrear()
    {
        tipoActual = tipoDeCrear;
    }
/*
    public void ElegirDefensas()
    {
        GameObject[] objecto = 
    }
*/

    /// <summary>
    /// Boton de volver al estado anterior
    /// </summary>
    public void Back()
    {
        if (stateMachine == null) return;
        if (stateMachine.estadoAnterior != null)
        {
            stateMachine.CambiarEstado(stateMachine.estadoAnterior);
        }
    }
}
