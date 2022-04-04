using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory: MonoBehaviour
{
    [SerializeField] private List<InventoryItem> inventory;

    // Use this for initialization
    void Start()
    {
        inventory = new List<InventoryItem>();
    }

    // Update is called once per frame
    void Update()
    {

    }
}