using UnityEngine;

public class EstadoCrear : MonoBehaviour, IEstadoObjeto
{
    [SerializeField]
    GameObject canvasCrear, canvasDefensas, canvasEntorno;

    public enum TiposCrear
    {
        defensa,
        entorno,
        vacio
    }


    //Prefabs e imágenes de los objetos a crear
    [SerializeField]  
    GameObject[] prefabsDefensas, imagenesDefensas;

    [SerializeField]
    GameObject[] prefabsEntorno, imagenesEntorno;

    /*
    public TextMeshProUGUI[] textodefensas, textoentorno;
    */
    //


    public TiposCrear tipoCrearActual;

    public void EntrarEstado(StateMachineObject stateObjeto)
    {
        canvasDefensas.SetActive(false);
        canvasEntorno.SetActive(false);
        canvasCrear.SetActive(true);

    }

    public void EjecutarEstado(StateMachineObject stateObjeto)
    {
        switch (tipoCrearActual)
        {
            case TiposCrear.defensa:
                Debug.Log("Creando defensa...");
                TipoDefensa();
                // Lógica para crear una defensa
                break;
            case TiposCrear.entorno:
                Debug.Log("Creando entorno...");
                TipoEntorno();
                // Lógica para crear un objeto de entorno
                break;
        }
    }


    void TipoDefensa()
    {
        Debug.Log("Función para crear defensa ejecutada.");
        // Aquí iría la lógica específica para crear defensas
    }


    void TipoEntorno()
    {
        Debug.Log("Función para crear entorno ejecutada.");
        // Aquí iría la lógica específica para crear objetos de entorno
    }


    public void SalirEstado(StateMachineObject stateObjeto)
    {
        Debug.Log("Saliendo del estado Crear");
        canvasCrear.SetActive(false);
    }
}
