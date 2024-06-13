using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevelPoint : MonoBehaviour
{
    public string lvlName;
   
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

     void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player" )
        {
            // Adicione a condição para verificar se o jogador coletou 10 objetos
            if(GameController.instance.totalScore >= 10)
            {
                SceneManager.LoadScene(lvlName);
            }
            else
            {
                Debug.Log("Você precisa coletar 10 objetos para passar para o próximo nível!");
            }
        }
    }
}
