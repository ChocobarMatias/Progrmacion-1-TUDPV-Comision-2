//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Super_Mario
//{
//    internal class BloqueInterrogacion
//    {
//        public bool abierto = false;
//        public bool TienePowerUp = false;

//        private static Random recompensa = new Random();

//        public void Golpear(PersonajeMario pj)
//        {
            
//            int resultado_recompensa = recompensa.Next(1, 3);
           
            

//            if (abierto == false)
//            {


//                if (resultado_recompensa == 1)
//                {
//                    pj.setMonedas(1);
//                    Console.WriteLine("Conseguiste una moneda. Ahora tienes más monedas $$$");
//                }
//                else if (resultado_recompensa == 2 && resultado_powerUp == 1)
//                {
//                    Console.WriteLine("Recibiste el power up Normal");
//                    TienePowerUp = true;
//                }
//                else if (resultado_recompensa == 2 && resultado_powerUp == 2)
//                {
//                    Console.WriteLine("Recibiste el power up Super");
//                    TienePowerUp = true;
//                }


//                else
//                {
//                    Console.WriteLine("Recibiste el power up Fuego");
//                    TienePowerUp = true;
//                }
//                    abierto = true;
//                    return;

//                }
//                else
//                {
//                    Console.WriteLine("Este bloque ya fue roto o consumido. No se puede golpear dos veces");
//                }

//            }
//        }
//    }
//}
