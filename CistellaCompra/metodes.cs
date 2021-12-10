using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace CistellaCompra
{
    public class metodes
    {
        String name;
        StreamReader sr;




        public void fitxersValidar()

        {
            string ruta = @"./CistellaCompra/Productes";
            String nomFitxer = Path.GetFileNameWithoutExtension(ruta);
            int counter = 0;
            
            string[] arxiusDirectori = Directory.GetFiles(ruta);
            

            for(int i=0; i<arxiusDirectori.Length; i++)
            {
                if(counter==2)
                {
                    
                }
                else
                {

                    break;
                }
            }



        }





       
    }
}