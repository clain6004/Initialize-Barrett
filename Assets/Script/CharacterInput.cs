using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterInput : MonoBehaviour {

    [SerializeField]
    float Speed;

    [SerializeField]
    float JumpPower;

    [SerializeField]
    float JumpTimeMax;

    [SerializeField]
    float JumpTimeUpdate;

    [SerializeField]
    float JumpDownTime;

    [SerializeField]
    float Gravity;

    bool Isground;

    CharacterControllers characterControllers;

    Vector3 CharacterVector;

    // Use this for initialization
    void Start () {

        characterControllers = new CharacterControllers(this.gameObject,Speed,Gravity,JumpPower,JumpTimeMax,JumpDownTime,JumpTimeUpdate);

    }
	
	// Update is called once per frame
	void Update () {

        CharacterVector = new Vector3(Input.GetAxis("Horizontal") * Speed,0, Input.GetAxis("Vertical") * Speed);

        characterControllers.Motor(CharacterVector);

        characterControllers.Jump();

	}
}
