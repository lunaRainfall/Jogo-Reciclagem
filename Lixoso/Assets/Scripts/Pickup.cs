using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Pickup : MonoBehaviour
{
    public PlayerClass player;
    public WorldClass world;
    public UI uiScript;

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
                }
            }
        }
    }

    public void ChangeTrashCount(GameObject hitObject)
    {
        if (player.actualInventory == 10)
        {
            uiScript.FullInventoryAlert();
        }

        for (int i = 0; i < player.inventory.Length; i++)
        {
            if (player.inventory[i] == "")
            {
                player.inventory[i] = hitObject.tag;
                player.actualInventory++;
                hitObject.transform.position = new Vector3(transform.position.x, -200, transform.position.z);
                Destroy(hitObject, 0.1f);
                switch (hitObject.tag)
                {
                    case "Metal":
                        player.trashAmount[0]++;
                        uiScript.trashInInventory[0]++;
                        break;

                    case "Vidro":
                        player.trashAmount[1]++;
                        uiScript.trashInInventory[1]++;
                        break;

                    case "Papel":
                        player.trashAmount[2]++;
                        uiScript.trashInInventory[2]++;
                        break;

                    case "Plastico":
                        player.trashAmount[3]++;
                        uiScript.trashInInventory[3]++;
                        break;

                    default:
                        Debug.Log("tu é uma anta provavelmente");
                        break;
                }
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
                player.actualInventory--;
                switch (trashType)
                {
                    case "Metal":
                        player.trashAmount[0] = 0;
                        uiScript.trashInInventory[0] = 0;
                        break;

                    case "Vidro":
                        player.trashAmount[1] = 0;
                        uiScript.trashInInventory[1] = 0;
                        break;

                    case "Papel":
                        player.trashAmount[2] = 0;
                        uiScript.trashInInventory[2] = 0;
                        break;

                    case "Plastico":
                        player.trashAmount[3] = 0;
                        uiScript.trashInInventory[3] = 0;
                        break;

                    default:
                        Debug.Log("do you are have stupid?");
                        break;
                }
            }
        }
    }

    public void CheckPosition(GameObject hitObject)
    {

    }
}
//780 1280 17


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