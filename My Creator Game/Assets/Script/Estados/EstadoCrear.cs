using UnityEngine;

public class EstadoCrear : IEstadoObjeto
{

    public enum TiposCrear
    {
        defensa,
        entorno,
        vacio
    }

    private StateMachineObject stateObjetoMenu;
    public TiposCrear tipoCrearActual;

    public void EntrarEstado(StateMachineObject stateObjeto)
    {
        stateObjetoMenu = stateObjeto;
        stateObjeto._canvasDefensas.SetActive(false);
        stateObjeto._canvasEntorno.SetActive(false);
        stateObjeto._cSelecCrear.SetActive(true);
        stateObjeto._canvasCrear.SetActive(true);

    }

    public void EjecutarEstado(StateMachineObject stateObjeto)
    {
        

        switch (tipoCrearActual)
        {
            case TiposCrear.defensa:
                Debug.Log("Creando defensa...");
                TipoX(stateObjeto._prefabsDefensas, stateObjeto._imagenesDefensas);
                // Lógica para crear una defensa
                break;
            case TiposCrear.entorno:
                Debug.Log("Creando entorno...");
                TipoX(stateObjeto._prefabsEntorno, stateObjeto._imagenesEntorno);
                // Lógica para crear un objeto de entorno
                break;
        }
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
