using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
    public class MainClass
    {
        public void DataTypes()
        {
            //Atribuicao explicita
            //int 
            int i = 0;
            //float
            float f = 10.9f;
            //double
            double d = 20.9d;
            //decimal
            decimal c = 30.8m;
            //bool
            bool b = true;
            bool c1 = false;
            //char
            char c2 = 'A';
            //string
            string s = "Evandre Dev";

            //Atribuicao Implicita
            var city = "Luanda";
            var idade = 18;
            idade = 67;

            //Valore Constantes
            const string conutry = "Angola";
            //country = "Angola"; dá erro porque o compilador enetende que esse valor é inalteravél

            //Conversão de tipos de dados
            // 1 - Conversao implicita
            f = idade;

            // 2 Conversao Explicita
            // f = c;
            // Dá erro porque o compilador não consegue converter implicitamente
            f = (float)c;





        }

    }
}
