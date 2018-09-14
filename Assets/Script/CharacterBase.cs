using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface CharacterSystem
{

    void Motor(Vector3 charactervector);

}

public class CharacterControllers : CharacterSystem
{

    GameObject Character;

    Vector3 CharacterVector;

    float Speed;

    float Gravity;

    float VectorY;

    float JumpTime;

    float JumpDownTime;

    float JumpTimeUpdate;

    float JumpPower;

    float JumpupdateMax;

    float DashTime;

    float DashDownTime;

    float DashTimeUpdate;

    float DashPower;

    float DashupdateMax;

    bool JumpCoolBool;

    CharacterController characterController;

    public CharacterControllers(GameObject character,float speed,float gravity,float jumpPower,float jumptimemax,float jumpdowntime,float jumptimeupdate)
    {

        Character = character;

        Speed = speed;

        Gravity = gravity;

        JumpDownTime=jumpdowntime;

        JumpPower=jumpPower;

        JumpupdateMax=jumptimemax;

        JumpTimeUpdate = jumptimeupdate;



    }

    public void Motor(Vector3 charactervector)
    {

        CharacterVector = charactervector;

        CharacterVector.y = VectorY;

        Character.GetComponent<CharacterController>().Move(CharacterVector*Time.deltaTime);

        VectorY -= Gravity * Time.deltaTime;

    }

    public void Jump()
    {

        if (Input.GetButton("Jump"))
        {

            if (JumpCoolBool == false)
            {

                if (JumpTime <= JumpupdateMax)
                {

                    JumpTime += JumpTimeUpdate * Time.deltaTime;

                    VectorY = JumpPower;

                }
                else
                {

                    JumpCoolBool = true;

                }

            }

        }

        if (JumpCoolBool)
        {

            if (JumpTime <= 0)
            {

                JumpCoolBool = false;

            }
            else
            {

                JumpTime -= JumpDownTime * Time.deltaTime;

            }

        }

    }

    public void Dash()
    {

        if (Input.GetButton("Jump"))
        {

            if (JumpCoolBool == false)
            {

                if (JumpTime <= JumpupdateMax)
                {

                    JumpTime += JumpTimeUpdate * Time.deltaTime;

                    VectorY = JumpPower;

                }
                else
                {

                    JumpCoolBool = true;

                }

            }

        }

        if (JumpCoolBool)
        {

            if (JumpTime <= 0)
            {

                JumpCoolBool = false;

            }
            else
            {

                JumpTime -= JumpDownTime * Time.deltaTime;

            }

        }

    }

}
