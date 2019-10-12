using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerClass : MonoBehaviour
{
    public string[] inventory = new string[10]; //make an array, around 10 slots max
    public int actualInventory;
    public float grabRange;
    public int score = 0;
    public int[] trashAmount = new int[4]; //Cada valor significa um tipo de lixo (0 metal, 1 vidro, 2 papel, 3 plástico);

}
