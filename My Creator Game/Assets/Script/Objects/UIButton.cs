using UnityEngine;

public class UIButton : MonoBehaviour
{
    [SerializeField]
    private StateMachineObject stateMachine;

    //Menu 
    public enum TipoBotonInit
    {
        Crear,
        Mover,
        Rotar,
        Eliminar,
        vacio
    }

    private TipoBotonInit tipoBotonMenu;
    [SerializeField]
    private TipoBotonInit tipoBotonMenuButton;
    //


    // back
    public enum TipoBotonBack
    {
        menu,
        crear,
        //selCrear,
    }
    [SerializeField]
    private TipoBotonBack tipoBotonBack;
    //


    void Start()
    {
        tipoBotonMenu = TipoBotonInit.vacio;
        if (stateMachine == null)
        {
            stateMachine = GetComponent<StateMachineObject>();
        }
    }

    void Update()
    {
        // back
        switch (tipoBotonBack)
        {
            case TipoBotonBack.menu:
                ElegirMenu(TipoBotonInit.vacio);
                break;
            case TipoBotonBack.crear:
                break;
        }
        //
        // menu
        switch (tipoBotonMenu)
        {
            case TipoBotonInit.Crear:
                stateMachine.CambiarEstado(new EstadoCrear());
                break;
            case TipoBotonInit.Mover:
                stateMachine.CambiarEstado(new EstadoMover());
                break;
            case TipoBotonInit.Rotar:
                stateMachine.CambiarEstado(new EstadoRotar());
                break;
            case TipoBotonInit.Eliminar:
                stateMachine.CambiarEstado(new EstadoEliminar());
                break;
            case TipoBotonInit.vacio:
                break;
        }   
        //
    }

    /// <summary>
    /// Botones del menú principal
    /// </summary>
    public void ElegirMenu()
    {
        tipoBotonMenu = tipoBotonMenuButton; 
    }

    public void ElegirMenu(TipoBotonInit tipo)
    {
        tipoBotonMenu = tipo; 
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
    //
    
    /// <summary>
    /// Boton de elegir crear
    /// </summary>
    public void ElegirCrear()
    {
        
    }


    /// <summary>
    /// Boton de volver al estado anterior
    /// </summary>
    public void Back()
    {
        stateMachine = FindAnyObjectByType<StateMachineObject>();
        if (stateMachine.estadoAnterior != null)
        {
            stateMachine.CambiarEstado(stateMachine.estadoAnterior);
        }
    }
}
