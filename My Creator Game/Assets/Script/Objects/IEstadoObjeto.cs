public interface IEstadoObjeto
{
    void EntrarEstado(StateMachineObject stateObjeto);
    void EjecutarEstado(StateMachineObject stateObjeto);
    void SalirEstado(StateMachineObject stateObjeto);
}
