using UnityEngine;

public class EstadoCrear : IEstadoObjeto
{
    private GameObject[] prefabDefensa;
    private GameObject[] prefabEntorno;


    private StateMachineObject stateObjetoMenu;
    private ObjetosACreacion objetosCreate;

    public void EntrarEstado(StateMachineObject stateObjeto)
    {
        stateObjetoMenu = stateObjeto;
        stateObjeto._canvasDefensas.SetActive(false);
        stateObjeto._canvasEntorno.SetActive(false);
        stateObjeto._cSelecCrear.SetActive(true);
        stateObjeto._canvasCrear.SetActive(true);
        prefabDefensa = stateObjeto._prefabsDefensas;
        prefabEntorno = stateObjeto._prefabsEntorno;
    }

    public void EjecutarEstado(StateMachineObject stateObjeto)
    {
    }


    void TipoX(GameObject[] stateObjetoCrear, GameObject[] stateObjetoImagen)
    {
        Debug.Log("Función para crear defensa ejecutada.");
        // Aquí iría la lógica específica para crear defensas


    }


    public void SalirEstado(StateMachineObject stateObjeto)
    {
        Debug.Log("Saliendo del estado Crear");
        stateObjetoMenu._canvasCrear.SetActive(false);
    }
}
