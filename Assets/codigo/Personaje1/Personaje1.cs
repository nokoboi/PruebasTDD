using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Personajes{
public class Personaje1
{
    private int vida = 100;

        private int fuerza;

        public Personaje1()
        {
            this.fuerza = 100; // Se inicializa la fuerza con un valor arbitrario
        }

        public int darPuñetazo(int intensidad)
        {
            // Resta la intensidad al valor de fuerza, no puede ser negativo
            fuerza = Mathf.Max(0, fuerza - intensidad);
            return intensidad;
        }

        public bool peleaCon(Personaje1 p2)
        {
            // Compara las fuerzas y devuelve true si el personaje actual tiene más fuerza que p2
            return this.fuerza > p2.getFuerza();
        }

        public float getFuerza()
        {
            return fuerza;
        }

        public bool estaVivo()
        {
            // Devuelve true si el personaje está vivo (tiene fuerza mayor que 0)
            return fuerza > 0;
        }
    }
}

