using System;
using System.Collections.Generic;
using System.Text;

namespace Grupo_3_Semana_2_Zelda
{
    public class ItemZelda
    {
       protected string nombre;
        protected int durabilidad;
        public ItemZelda(string nombre, int durabilidad)
        {
            this.nombre = nombre;
            this.durabilidad = durabilidad;

        }
        public virtual void usar(Link link)
        {

        }

    }
}
