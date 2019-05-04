using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConverorEmCSharp
{
    class ConversorMorse
    {
        char DadosInformados;
        public ConversorMorse(char DadosInformados)
        {
            this.DadosInformados = DadosInformados;
        }

        public string Converter()
        {
            string letrasMorse = "";
            
            if (DadosInformados == 'A')
            {
                letrasMorse = ".-";
                return(".-");
            }
            else
                if (DadosInformados == 'B')
                {
                letrasMorse = "-...";
                return ("-...");
                }
            else
                if (DadosInformados == 'C')
                {
                letrasMorse = "-.-.";
                return ("-.-.");
                }
            else
                if (DadosInformados == 'D')
                {
                letrasMorse = "-..";
                return ("-..");
                }
            else

                if (DadosInformados == 'E')
                {
                letrasMorse = ".";
                return (".");
                }
            else

                if (DadosInformados == 'F')
                {
                letrasMorse = "..-.";
                return ("..-.");
                }
            else
                if (DadosInformados == 'G')
                {
                letrasMorse = "--.";
                return ("--.");
                }
            else
                if (DadosInformados == 'H')
                {
                letrasMorse = "....";
                return ("....");
                }
            else
                if (DadosInformados == 'I')
                {
                letrasMorse = "..";
                return ("..");
                }
            else
                if (DadosInformados == 'J')
                {
                letrasMorse = ".---";
                return (".---");
                }
            else
                if (DadosInformados == 'K')
                {
                letrasMorse = "-.-";
                return ("-.-");
                }
            else
                if (DadosInformados == 'L')
                {
                letrasMorse = ".-..";
                return (".-..");
                }
            else
                if (DadosInformados == 'M')
                {
                letrasMorse = "--";
                return ("--");
                }
            else
                if (DadosInformados == 'N')
                {
                letrasMorse = "-.";
                return ("-.");
                }
            else
                if (DadosInformados == 'O')
                {
                letrasMorse = "---";
                return ("---");
                }
            else
                if (DadosInformados == 'P')
                {
                letrasMorse = ".--.";
                return (".--.");
                }
            else
                if (DadosInformados == 'Q')
                {
                letrasMorse = "--.-";
                return ("--.-");
                }
            else
                if (DadosInformados == 'R')
                {
                letrasMorse = ".-.";
                return (".-.");
                }
            else
                if (DadosInformados == 'S')
                {
                letrasMorse = "...";
                return ("...");
                }
            else
                if (DadosInformados == 'T')
                {
                letrasMorse = "-";
                return ("-");
                }
            else
                if (DadosInformados == 'U')
                {
                letrasMorse = "..-";
                return ("..-");
                }
            else
                if (DadosInformados == 'V')
                {
                letrasMorse = "...-";
                return ("...-");
                }   
            else
                if (DadosInformados == 'W')
                {
                letrasMorse = ".--";
                return (".--");
                }
            else
                if (DadosInformados == 'X')
                {
                letrasMorse = "-..-";
                return ("-..-");
                }
            else
                if (DadosInformados == 'Y')
                {
                letrasMorse = "-.--";
                return ("-.--");
                }
            else
                if (DadosInformados == 'Z')
                {
                letrasMorse = "--..";
                return ("--..");
                }
            else
                if (DadosInformados == '1')
                {
                letrasMorse = ".----";
                return (".----");
                }
            else
                if (DadosInformados == '2')
                {
                letrasMorse = "..---";
                return ("..---");
                }
            else
                if (DadosInformados == '3')
                {
                letrasMorse = "...--";
                return ("...--");
                }
            else
                if (DadosInformados == '4')
                {
                letrasMorse = "....-";
                return ("....-");
                }
            else
                if (DadosInformados == '5')
                {
                letrasMorse = ".....";
                return (".....");
                }
            else
                if (DadosInformados == '6')
                {
                letrasMorse = "-....";
                return ("-....");
                }
            else
                if (DadosInformados == '7')
                {
                letrasMorse = "--...";
                return ("--...");
                }
            else
                if (DadosInformados == '8')
                {
                letrasMorse = "---..";
                return ("---..");
                }
            else
                if (DadosInformados == '9')
                {
                letrasMorse = "----.";
                return ("----.");
                }
            else
                if (DadosInformados == '0')
                {
                letrasMorse = "-----";
                return ("-----");
                }
            return letrasMorse;
        }
    }
}
