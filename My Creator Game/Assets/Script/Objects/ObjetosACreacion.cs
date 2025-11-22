using UnityEngine;

public class ObjetosACreacion : MonoBehaviour
{
    [SerializeField]
    private StateMachineObject stateMachine;

    public enum TiposDeCreacion
    {
        Def_Torre,
        Def_Solado,

        Ent_Arbol,
        Ent_Roca
    }

    public GameObject objetoCreado;
    public GameObject objetoImagen;

    public TiposDeCreacion tipoDeCreacion;
    bool objectCreated = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        stateMachine = FindAnyObjectByType<StateMachineObject>();
        if (stateMachine == null)
        {
            stateMachine = GetComponent<StateMachineObject>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (objectCreated)
        {
            switch (tipoDeCreacion)
        {
            case TiposDeCreacion.Def_Torre:
                objetoCreado = stateMachine._prefabsDefensas[0];
                objetoImagen = stateMachine._imagenesDefensas[0];
                // Lógica específica para crear una torre de defensa
                break;
            case TiposDeCreacion.Def_Solado:
                objetoCreado = stateMachine._prefabsDefensas[1];
                objetoImagen = stateMachine._imagenesDefensas[1];
                // Lógica específica para crear un soldado de defensa
                break;

            case TiposDeCreacion.Ent_Arbol:
                objetoCreado = stateMachine._prefabsEntorno[0];
                objetoImagen = stateMachine._imagenesEntorno[0];
                // Lógica específica para crear un árbol de entorno
                break;
            case TiposDeCreacion.Ent_Roca:
                objetoCreado = stateMachine._prefabsEntorno[1];
                objetoImagen = stateMachine._imagenesEntorno[1]; 
                // Lógica específica para crear una roca de entorno
                break;
            default:
                Debug.LogWarning("Tipo de creación no reconocido.");
                break;
        }
            objectCreated = false;
        }
        
    }

    public void CrearObjeto()
    {
        objectCreated = true;
    }
}
