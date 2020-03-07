using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class PlayerMove : MonoBehaviour
{
        
    	PlayerInput controls;
        Vector2 move;

        void Awake(){
            controls = new PlayerInput();
            controls.Gameplay.Move.performed += ctx => move = ctx.ReadValue<Vector2>();
            controls.Gameplay.Move.canceled += ctx => move = Vector2.zero;
        }

        void Update(){
            Vector2 m = new Vector2(-move.x, move.y) * Time.deltaTime;
            transform.Translate(m, Space.World);
        }

        void OnEnable(){
            controls.Gameplay.Enable();
        }
        
        void OnDisable(){
            controls.Gameplay.Disable();
        }

}
