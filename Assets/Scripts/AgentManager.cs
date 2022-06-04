using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AgentManager : MonoBehaviour
{
    //cria um array de gameobjects
    GameObject[] agents;

    //armazena a posi��o do mouse
    RaycastHit hit;

    void Start()
    {
        //busca na cena os objetos com a tag "ai" e adiciona no array
        agents = GameObject.FindGameObjectsWithTag("ai");
    }
    

    void Update()
    {
        //verifica se clicar o bot�o esquerdo do mouse
        if (Input.GetMouseButtonDown(0))
        {
            //cria um raycast na posi��o do mouse
            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, 500))
            {
                //pega os objetos dentro de "agents"
                foreach (GameObject a in agents)
                    //pega o componente "AIControl" do objeto e adiciona o destino do agent para a posi��o do mouse
                    a.GetComponent<AIControl>().agent.SetDestination(hit.point);
            }
        }
    }
}
