using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryUI : MonoBehaviour
{
    public Inventory Inventory;

    void Start()
    {
        Inventory.ItemAdded += InventoryScript_ItemAdded;
        Inventory.ItemRemoved += Inventory_ItemRemoved;
    }

    private void InventoryScript_ItemAdded(object sender, InventoryEventArgs e)
    {
        Transform inventoryPanel = transform.Find("InventoryPanel");
        foreach (Transform slot in inventoryPanel)
        {

            Transform imageTransform = slot.GetChild(0).GetChild(0);
            Image image = imageTransform.GetComponent<Image>();
            ItemDrag itemDrag = imageTransform.GetComponent<ItemDrag>();
            print("aa");

            //if (!image.enabled)
            if (image.sprite == Resources.Load("None"))
            {
                print("free slot");
                image.enabled = true;
                image.sprite = e.Item.Image;

                break;
            }

            //image.enabled = true;
            //image.sprite = e.Item.Image;

        }
    }

    private void Inventory_ItemRemoved(object sender, InventoryEventArgs e)
    {
        Transform inventoryPanel = transform.Find("InventoryPanel");
        foreach (Transform slot in inventoryPanel)
        {
            Transform imageTransform = slot.GetChild(0).GetChild(0);
            Image image = imageTransform.GetComponent<Image>();
            ItemDrag itemDrag = imageTransform.GetComponent<ItemDrag>();

            if (itemDrag.Item.Equals(e.Item))
            {
                print("image enabled");
                image.enabled = false;
                image.sprite = null;
                itemDrag.Item = null;
                break;
            }
        }
    }
}
