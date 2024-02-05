using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Personajes{
public class Personaje2
{
    private int vida = 100;

    public int darPuñetazo(int fuerza)
    {
        if (fuerza < 50)
        {
            return 0;
        }
        else if (fuerza >= 50 && fuerza <= 100)
        {
            return 1;
        }
        else if (fuerza > 100 && fuerza <= 150)
        {
            return 2;
        }
        else if (fuerza > 150)
        {
            return 3;
        }
        return -1;
    }
}
}

