﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interact
{
    private readonly string _ItemTag = "Item";
    /// <summary>
    /// Picks up the gear that the player is standing on.
    /// </summary>
    public void PickupItem() //Important
    {

    }
    /// <summary>
    /// Try to open the door.
    /// </summary>
    public void TryOpenDoor()
    {

    }
    /// <summary>
    /// Close an opened door.
    /// </summary>
    public void CloseDoor() //Slam door?
    {

    }
    /// <summary>
    /// Try to open a chest.
    /// </summary>
    public void TryOpenChest()
    {
        //DESTROY CHEST ON EXECUTE FUNCTION
    }
    /// <summary>
    /// Can the player equip the gear or not?
    /// </summary>
    /// <param name="PlayerLevel">The players current level</param>
    /// <param name="RequiredLevel">The level the player is required to be to equip the gear</param>
    /// <returns> returns wether or not the player is the right level to equip the gear</returns>
    public bool CanEquip(int PlayerLevel, int RequiredLevel)
    {
        if (RequiredLevel > PlayerLevel)
        {
            return false;
        }
        else
        {
            return true;
        }
    }
    /// <summary>
    /// Equip the gear in the specified slot and unequips the item in said slot if need be.
    /// </summary>
    /// <param name="OccupiedSlot">Is the slot occupied or not.</param>
    /// <param name="GearSlot">The slot to put the item in.</param>
    public void EquipGear(bool OccupiedSlot, byte GearSlot)//Important
    {

    }
    /// <summary>
    /// Equips the gear in the specified slot, regardless of wether or not there is an item in it.
    /// </summary>
    /// <param name="GearSlot">The slot to put the item in.</param>
    public void EquipGear(byte GearSlot)
    {

    }
    /// <summary>
    /// Unequips the gear in the specified slot
    /// </summary>
    /// <param name="GearSlot">The slot that the gear is in.</param>
    /// <param name="DestroyItem">Wether or not the unequiped item will be destroyed.</param>
    public void UnEquipGear(byte GearSlot, bool DestroyItem = false)//Important
    {

    }
    /// <summary>
    /// Uses the item.
    /// </summary>
    public void UseItem()//Item item)//Important
    {

    }
    /// <summary>
    /// Drops the selected item.
    /// </summary>
    public void DropItem()//Important
    {

    }
    /// <summary>
    /// Sell the selected item.  
    /// </summary>
    /// <param name="ItemValue">The value of the item being sold.</param>
    public void SellItem(int ItemValue)
    {

    }
    /// <summary>
    /// Buys the selected item.
    /// </summary>
    /// <param name="ItemValue">The value of the item being bought.</param>
    public void BuyItem(int ItemValue)
    {

    }
    /// <summary>
    /// Creates a radius of noise for the enemies to go towards if heard.
    /// </summary>
    /// <param name="ProducedNoise">How much noise the object would make.</param>
    public void ProduceNoise(int ProducedNoise)
    {

    }
    /// <summary>
    /// wether or not the item can be unequiped.
    /// </summary>
    /// <param name="FreeInventorySlot">the amount of free inventory slots.</param>
    /// <param name="CursedItem">wethere the item is cursed or not.</param>
    /// <returns>Returns wethere the item can be unequiped</returns>
    public bool CanUnequip(int FreeInventorySlot, bool CursedItem = false)
    {
        return true;
    }

    /// <summary>
    /// Wether or not the item can be used (i.e. a health potion when you health is full)
    /// </summary>
    /// <returns>Returns if the item can be used.</returns>
    public bool CanUse()
    {
        return true;
    }
    /// <summary>
    /// Wether or not the item can be dropped on the ground.
    /// </summary>
    /// <returns></returns>
    public bool CanDrop()
    {
        return true;
    }

}
