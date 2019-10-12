using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldClass : MonoBehaviour
{
    public float timer;
    public int currentTrashAmountByArea; //also an array, 4 positions
    public int maxTrashAmountByArea;

    public GameObject[] area; // (0 = 1; 1 = 2; 2 = 3; 3 = 4)
    public int[] trashAmountAreas = new int[4]; // (0 = 1; 1 = 2; 2 = 3; 3 = 4)

    
}
