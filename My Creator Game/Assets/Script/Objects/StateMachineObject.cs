using UnityEngine;
using TMPro;

public class StateMachineObject : MonoBehaviour
{
    [SerializeField]
    GameObject canvasElegir, canvasCrear, canvasMover, canvasRotar, canvasEliminar;
    // getters
    public GameObject _canvasElegir { get { return canvasElegir; } }
    public GameObject _canvasCrear { get { return canvasCrear; } }
    public GameObject _canvasMover { get { return canvasMover; } }
    public GameObject _canvasRotar { get { return canvasRotar; } }
    public GameObject _canvasEliminar { get { return canvasEliminar; } }


    public IEstadoObjeto estadoActual;
    public IEstadoObjeto estadoAnterior;

    /// <summary>
    /// Estado Crear
    /// Canvas de creación
    
    [SerializeField] GameObject canvasSeleccionCrear;
    //getter
    public GameObject _cSelecCrear { get { return canvasSeleccionCrear; } }


    [SerializeField]
    GameObject canvasDefensas, canvasEntorno;
    //getters
    public GameObject _canvasDefensas { get { return canvasDefensas; } }
    public GameObject _canvasEntorno { get { return canvasEntorno; } }

    //Prefabs e imágenes de los objetos a crear
    [SerializeField]  
    GameObject[] prefabsDefensas, imagenesDefensas;
    //getters
    public GameObject[] _prefabsDefensas { get { return prefabsDefensas; } }
    public GameObject[] _imagenesDefensas { get { return imagenesDefensas; } }

    [SerializeField]
    GameObject[] prefabsEntorno, imagenesEntorno;
    //getters
    public GameObject[] _prefabsEntorno { get { return prefabsEntorno; } }
    public GameObject[] _imagenesEntorno { get { return imagenesEntorno; } }
    /// </summary>


    public TextMeshProUGUI[] textoAtack, tectoAtackSpeed, textoExp;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StateInit();
    }

    void StateInit()
    {
        canvasElegir.SetActive(true);
        canvasCrear.SetActive(false);
        canvasMover.SetActive(false);
        canvasRotar.SetActive(false);
        canvasEliminar.SetActive(false);
        CambiarEstado(new EstadoMenu());
    }

    public void CambiarEstado(IEstadoObjeto nuevoEstado)
    {
        if (estadoActual != null)
        {
            estadoActual.SalirEstado(this);
        }

        estadoAnterior = estadoActual;
        estadoActual = nuevoEstado;

        estadoActual.EntrarEstado(this);
    }

    // Update is called once per frame
    void Update()
    {
        if (estadoActual != null)
        {
            estadoActual.EjecutarEstado(this);
        }
    }
}
