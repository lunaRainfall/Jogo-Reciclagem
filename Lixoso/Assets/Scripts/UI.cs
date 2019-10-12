using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UI : MonoBehaviour
{

    public Animator animFullInventory;

    public int[] trashInInventory = new int[4]; //Cada valor significa um tipo de lixo(0 metal, 1 vidro, 2 papel, 3 plástico);
    public TextMeshProUGUI[] trashTypesUI = new TextMeshProUGUI[4];
    public TextMeshProUGUI alert;

    void Start()
    {

    }

    void Update()
    {
        for (int i = 0; i < 4; i++)
        {
            trashTypesUI[i].text = trashInInventory[i].ToString();
        }
    }

    public void FullInventoryAlert()
    {
        animFullInventory.SetTrigger("Full");
    }
}
