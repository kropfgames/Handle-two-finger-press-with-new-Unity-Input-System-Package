using System.Collections;
using System.Collections.Generic;
using UnityEngine; 
using UnityEngine.InputSystem;

public class Move : MonoBehaviour
{ 
    [SerializeField] public GameObject Player;   
 
    //add Touchscreen.TwoFingers binding (button) to Touch 1 (not multi touch)
    public void OnTwoFingers(InputValue input)
    {    
            Debug.Log("  two fingers triggered " ); 
            Player.transform.position = new Vector3(Player.transform.position.x,
            Player.transform.position.y + 0.1f, Player.transform.position.z);

    }  
}