using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AIControl : MonoBehaviour
{
    //variavel publica para adicionar o agent da cena
    public NavMeshAgent agent;
    

    void Start()
    {
        //pega o compenente "NavMeshAgent" 
        agent = this.GetComponent<NavMeshAgent>();
    }
}