using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputPlayer : MonoBehaviour
{
    FloatingJoystick inputMove;
    private void Awake()
    {
        if(inputMove == null){
            this.inputMove = GetComponent<FloatingJoystick>();
        }   
    }

    public float GetHorizontal(){
        return inputMove.Horizontal;
    }
    public float GetVertical(){
        return inputMove.Vertical;
    }

    public Vector2 GetDirection(){

        return this.inputMove.Direction;
    }
}
