using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Pickup : MonoBehaviour
{
    public PlayerClass player;
    //public Manager mng;

    public float rayLength;
    public LayerMask whatToHit; //LayerMask onde apenas o lixo deve ser selecionado
    public Camera playerCamera;

    void Start()
    {
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = playerCamera.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit, rayLength, whatToHit)) //se acertar um lixo
            {
                if (hit.collider.gameObject.layer == LayerMask.NameToLayer("Lixeira")) //Se a layer significar que é uma lixeira
                {
                    DeployTrash(hit.collider.tag);
                }
                else // Se não, é um lixo
                {
                    ChangeTrashCount(hit.collider.gameObject);
                    Debug.Log(hit.collider.tag);
                }
            }
        }
    }

    public void ChangeTrashCount(GameObject hitObject)
    {
        for (int i = 0; i < player.inventory.Length; i++)
        {
            if (player.inventory[i] == "")
            {
                player.inventory[i] = hitObject.tag;
                Destroy(hitObject);
                switch (hitObject.tag)
                {
                    case "Metal":
                        player.trashAmount[0]++;
                        break;

                    case "Vidro":
                        player.trashAmount[1]++;
                        break;

                    case "Papel":
                        player.trashAmount[2]++;
                        break;

                    case "Plastico":
                        player.trashAmount[3]++;
                        break;

                    default:
                        Debug.Log("tu é uma anta provavelmente");
                        break;
                }
                Debug.Log(player.trashAmount[0]);
                break;
            }
        }
    }

    public void DeployTrash(string trashType)
    {
        for (int i = 0; i < player.inventory.Length; i++)
        {
            if (player.inventory[i] == trashType)
            {
                player.inventory[i] = "";
                player.score++;
                switch (trashType)
                {
                    case "Metal":
                        player.trashAmount[0] = 0;
                        break;

                    case "Vidro":
                        player.trashAmount[1] = 0;
                        break;

                    case "Papel":
                        player.trashAmount[2] = 0;
                        break;

                    case "Plastico":
                        player.trashAmount[3] = 0;
                        break;

                    default:
                        Debug.Log("do you are have stupid?");
                        break;
                }
            }
        }
    }
}
//780 1280


    // quem precisa de bloco de notas xDDDD
    // sumario
    /// caragglio
    /// mto pyka
    /// e agora?
    /// 
    /// montar a cena
    /// spawn de lixo aleatorio (done!)
    /// desafios
    /// UI
    /// menu/tela de instrução né
    /// som na caixa
    /// 