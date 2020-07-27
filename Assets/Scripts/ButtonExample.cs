using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonExample : MonoBehaviour
{
    public enum DiasSemana { Lunes, Martes, Miercoles, Jueves, Viernes, Sabado, Domingo, End};

    [Header("Ejemplos")]
    [SerializeField] int var;
    [HideInInspector] public int noQuieroVerte;
    [SerializeField] Animator anim;

    [Header("Nose")]
    [SerializeField] bool visible;

    DiasSemana dia;

    private void Reset()
    {
        visible = true;
        var = 5;
    }

    void Awake()
    {
        
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    void FixedUpdate()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        switch(dia)
        {
            case DiasSemana.Lunes:
                break;
            case DiasSemana.Martes:
                break;
            default:
                break;
        }

        dia = (DiasSemana) ((int)(dia + 1) % (int)DiasSemana.End);
        if (dia == DiasSemana.End) dia = (DiasSemana)0;

        dia = (DiasSemana)5;
        noQuieroVerte = (int)dia;
    }

    void OnDestroy()
    {
        
    }

    void OnGUI()
    {
        
    }

    public void OnClickButton()
    {
        anim.SetTrigger("Move");
    }

    public void LogFunct(int test)
    {
        Debug.Log("Hey " + test);
    }

    private void OnEnable()
    {
        Debug.Log("test");
    }

    private void OnDisable()
    {
        Debug.Log("destest");
    }
}
