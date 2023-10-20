using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SilindirDondurme : MonoBehaviour
{
    [SerializeField] float DonusHizi;
    float MouseX;

    void Update()
    {
        MouseX = Input.GetAxis("Mouse X");

        if(Input.GetMouseButton(0))   //mouse sol týka basarak silindiri çevirelim
        {
            transform.Rotate(0f, MouseX * DonusHizi * Time.deltaTime, 0f);   
        }
    }
}
