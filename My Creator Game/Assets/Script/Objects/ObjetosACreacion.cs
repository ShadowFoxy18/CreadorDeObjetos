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
        
    }
}
