using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Pickup : MonoBehaviour
{
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
                ChangeTrashCount(hit.collider.tag);
                Debug.Log(hit.collider.name);

            }
        }
    }

    public void ChangeTrashCount(string trashType)
    {

    }
}
//780 1280