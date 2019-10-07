using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Pickup : MonoBehaviour
{
    public PlayerClass player;

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
            }
        }
    }
}
//780 1280