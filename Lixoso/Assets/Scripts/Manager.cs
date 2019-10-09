using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public PlayerClass player;

    public string[] trashTypes = new string[4];
    
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void CheckTrash()
    {
        for(int i = 0; i < trashTypes.Length; i++)
        {
            for(int j = 0; i < player.inventory.Length; j++)
            {
                if (trashTypes[i] == player.inventory[j])
                {
                    player.trashAmount[i]++;
                }
            }
        }
    }
}
