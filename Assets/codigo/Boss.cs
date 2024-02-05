using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour
{
    public float vida = 100;
    public float da�oNormal = 8;
    public float da�oEspecial = 10;
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

    public float Da�arBoss(bool isParry, bool isEspecial)
    {
        float da�o = 0;

        if (isParry)
        {
            vida -= parry;
            da�o += parry;
        }

        if (isEspecial)
        {
            vida -= da�oEspecial;
            da�o += parry;
        }
        else
        {
            vida -= da�oNormal;
            da�o += parry;
        }

        return da�o;
    }
}
