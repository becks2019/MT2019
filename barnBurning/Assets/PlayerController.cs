using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class PlayerController : MonoBehaviour
{
        
    	PlayerMove controls;
        Vector3 move;

        void Awake(){
            controls = new PlayerMove();
            controls.Gameplay.Move.performed += ctx => move = ctx.ReadValue<Vector3>();
            controls.Gameplay.Move.canceled += ctx => move = Vector3.zero;
        }

        void Update(){
            Vector3 m = new Vector3(move.x, move.y, move.z) * Time.deltaTime;
            transform.Translate(m, Space.World);
        }

        void OnEnable(){
            controls.Gameplay.Enable();
        }
        
        void OnDisable(){
            controls.Gameplay.Disable();
        }

}
