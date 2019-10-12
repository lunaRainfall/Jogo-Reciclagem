using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashPerArea : MonoBehaviour
{
    /// <summary>
    /// Este Script tem como função indicar as entradas e saídas de lixo nos Triggers e passar para o WorldClass
    /// </summary>

    public int areaNumber;
    public WorldClass world;

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("Lixo"))
        {
            world.trashAmountAreas[areaNumber]++;
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("Lixo"))
        {
            world.trashAmountAreas[areaNumber]--;
        }
    }
}
