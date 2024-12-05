using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trampoline : MonoBehaviour
{
    //Задаем во сколько раз увеличиться сила прыжка
    public float jumpFactor = 5f;

    //Функция увеличивающая силу прыжка при входе на батут
    void OnTriggerEnter(Collider other)
    {
        other.GetComponent<Jump>().jumpStrength *= jumpFactor;
    }

    //Функция уменьшающая силу прыжка при выходе из батута
    void OnTriggerExit(Collider other)
    {
        other.GetComponent<Jump>().jumpStrength /= jumpFactor;
    }
}
