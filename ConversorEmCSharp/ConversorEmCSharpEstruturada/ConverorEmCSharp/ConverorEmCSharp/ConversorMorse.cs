using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConverorEmCSharp
{
    class ConversorMorse
    {
        string DadosInformados;
        public ConversorMorse(string DadosInformados)
        {
            this.DadosInformados = DadosInformados;
        }

        public string Converter()
        {
            char teste = ' ';
            for(int contador = 0; contador < DadosInformados.Length; contador++)
            {
                teste = DadosInformados[contador];
                return (teste.ToString());
            }
            return (teste.ToString());
        }
    }
}
