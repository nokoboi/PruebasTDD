using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour
{
    public float vida = 100;
    public float dañoNormal = 8;
    public float dañoEspecial = 10;
    public float parry = 20;
    public bool muerto = false;

   

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(vida<=0) muerto = true;
    }

    public float DañarBoss(bool isParry, bool isEspecial)
    {
        float daño = 0;

        if (isParry)
        {
            vida -= parry;
            daño += parry;
        }

        if (isEspecial)
        {
            vida -= dañoEspecial;
            daño += parry;
        }
        else
        {
            vida -= dañoNormal;
            daño += parry;
        }

        return daño;
    }
}
