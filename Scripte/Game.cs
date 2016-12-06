using UnityEngine;
using System.Collections;
 
[System.Serializable]
public class Game { 
 
    public static Game current;
    public Inventory inventory;
    public Vector3 position;
    public Mission currentMission;
 
    public Game () {
        position = gameObject.transform.position;
        inventory = new Inventory();
        currentMission = new Mission();
    }
         
}