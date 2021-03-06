using UnityEngine; 
using System.Collections;
using System.Collections.Generic;
//Item class.
//Items have a number of attributes and a type (weapon or block). 
[System.Serializable]
public class Item {
    public string itemName;
    public int itemID; 
    public string itemDesc; 
    public Texture2D itemIcon;
    public int itemPower; 
    public int itemSpeedStone;
    public int itemSpeedDirt; 
    public ItemType itemType; 
    public enum ItemType{
        Weapon,
        Block
    }
    public GameObject itemWorld;
    public Item(string name,int id, string desc, int power, int speedstone,int speeddirt, ItemType type, GameObject itemWorlderu){
        itemName = name; 
        itemID = id; 
        itemDesc = desc; 
        itemIcon = Resources.Load<Texture2D>("Item Icons/"+ name); 
        itemPower = power;
        itemSpeedStone = speedstone; 
        itemSpeedDirt = speeddirt;
        itemType = type;
        itemWorld = itemWorlderu;


    }
    public Item(){
        
    }
    


}