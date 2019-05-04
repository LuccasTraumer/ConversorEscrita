using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConverorEmCSharp
{
    class Program
    {
        static void EsperarEnter()
        {
            WriteLine("Presseione [ENTER] para Finalizar.");
            ReadLine();
        }
        static void Menu()
        {
            WriteLine("-==--=-=---=-=--=-=-=--=-=--=-=-=-=-=-=--==");
            WriteLine("    Projeto Feito por: Luccas Traumer      ");
            WriteLine("    Desenvolvimento de Sistema(2019)       ");
            WriteLine("   Colegio Tecnico de Campinas(UNICAMP)    ");
            WriteLine("-==--=-=---=-=--=-=-=--=-=--=-=-=-=-=-=--==");
            WriteLine("   Digite [Morse] para Conversor Morse.    ");
            WriteLine("  Digite [FIM] para Finalizar o Programa.  ");
            WriteLine("-==--=-=---=-=--=-=-=--=-=--=-=-=-=-=-=--==");
            Write("Qual Opção Deseja Realizar?: ");

        }
        static void AlfabetoParaMorse()
        {
            Clear();
            WriteLine("-==--=-=---=-=--=-=-=--=-=--=-=-=-=-=-=--==");
            WriteLine("       Alfabeto para Codigo Morse.         ");
            WriteLine("-==--=-=---=-=--=-=-=--=-=--=-=-=-=-=-=--==");
            Write("O que Deseja Converter: ");
            string DadosInformados = ReadLine().ToUpper();

            char letras = ' ';
            string letrasMorse = "";
            string palavraMorse = "";
            WriteLine("-==-==- Caracter por Caracter.-=-=-==-");
            WriteLine("Letra no Alfabeto         Cod.Morse   ");
            for (int contador = 0; contador < DadosInformados.Length; contador++)
            {
                letras = DadosInformados[contador];
                WriteLine(letras);

                if (letras == 'A')
                {
                    letrasMorse = ".-";
                    WriteLine("                   .-");
                }
                else
                if (letras == 'B') {
                    letrasMorse = "-...";
                    WriteLine("                   -...");
                }
                else
                if (letras == 'C')
                {
                letrasMorse = "-.-.";
                WriteLine("                   -.-.");
                }
                else
                if (letras == 'D')
                {
                    letrasMorse = "-..";
                    WriteLine("                   -..");
                }
                else

                if (letras == 'E')
                {
                    letrasMorse = ".";
                    WriteLine("                   .");
                }
                else

                if (letras == 'F')
                {
                letrasMorse = "..-.";
                WriteLine("                   ..-.");
                }
                else
                if (letras == 'G')
                {
                    letrasMorse = "--.";
                    WriteLine("                   --.");
                }
                else
                if (letras == 'H') {
                    letrasMorse = "....";
                    WriteLine("                   ....");
                }
                else
                if (letras == 'I') {
                    letrasMorse = "..";
                    WriteLine("                   ..");
                }
                else
                if (letras == 'J') {
                    letrasMorse = ".---";
                    WriteLine("                   .---");
                }
                else
                if (letras == 'K') {
                    letrasMorse = "-.-";
                    WriteLine("                   -.-");
                }
                else
                if (letras == 'L') {
                    letrasMorse = ".-..";
                    WriteLine("                   .-..");
                }
                else
                if (letras == 'M') {
                    letrasMorse = "--";
                    WriteLine("                   --");
                }
                else
                if (letras == 'N') {
                    letrasMorse = "-.";
                    WriteLine("                   -.");
                }
                else
                if (letras == 'O') {
                    letrasMorse = "---";
                    WriteLine("                   ---");
                }
                else
                if (letras == 'P') {
                    letrasMorse = ".--.";
                    WriteLine("                   .--.");
                }
                else
                if (letras == 'Q') {
                    letrasMorse = "--.-";
                    WriteLine("                   --.-");
                }
                else
                if (letras == 'R') {
                    letrasMorse = ".-.";
                    WriteLine("                   .-.");
                }
                else
                if (letras == 'S') {
                    letrasMorse = "...";
                    WriteLine("                   ...");
                }
                else
                if (letras == 'T') {
                    letrasMorse = "-";
                    WriteLine("                   -");
                }
                else
                if (letras == 'U') {
                    letrasMorse = "..-";
                    WriteLine("                   ..-");
                }
                else
                if (letras == 'V') {
                    letrasMorse = "...-";
                    WriteLine("                   ...-");
                }
                else
                if (letras == 'W') {
                    letrasMorse = ".--";
                    WriteLine("                   .--");
                }
                else
                if (letras == 'X') {
                    letrasMorse = "-..-";
                    WriteLine("                   -..-");
                }
                else
                if (letras == 'Y') {
                    letrasMorse = "-.--";
                    WriteLine("                   -.--");
                }
                else
                if (letras == 'Z') {
                    letrasMorse = "--..";
                    WriteLine("                   --..");
                }
                else
                if (letras == '1') {
                    letrasMorse = ".----";
                    WriteLine("                   .----");
                }
                else
                if (letras == '2')
                {
                    letrasMorse = "..---";
                    WriteLine("                   ..---");
                }
                else
                if (letras == '3')
                {
                    letrasMorse = "...--";
                    WriteLine("                   ...--");
                }
                else
                if (letras == '4')
                {
                    letrasMorse = "....-";
                    WriteLine("                   ....-");
                }
                else
                if (letras == '5')
                {
                    letrasMorse = ".....";
                    WriteLine("                   .....");
                }
                else
                if (letras == '6')
                {
                    letrasMorse = "-....";
                    WriteLine("                   -....");
                }
                else
                if (letras == '7')
                {
                    letrasMorse = "--...";
                    WriteLine("                   --...");
                }
                else
                if (letras == '8')
                {
                    letrasMorse = "---..";
                    WriteLine("                   ---..");
                }
                else
                if (letras == '9')
                { 
                    letrasMorse = "----.";
                    WriteLine("                   ----.");
                }
                else
                if (letras == '0')
                {
                    letrasMorse = "-----";
                    WriteLine("                   -----");
                }
                
                palavraMorse += letrasMorse;
                

                
            }
            WriteLine("-------- Palavras Completas.--=-=-=-=-");
            WriteLine("Palavra                 Codigo Morse  ");
            WriteLine(DadosInformados+"             "+palavraMorse);

            }
        
           
        static void Seletor()
        {
            string opcao = "";
            do
            {
                
                Menu();
                opcao = ReadLine().ToUpper();
                switch (opcao)
                {
                    case ("MORSE"):
                        AlfabetoParaMorse();
                        EsperarEnter();
                        Clear();
                        break;
                    default:
                        WriteLine("Opção Invalida!");
                        break;
                }
                

            } while (opcao != "FIM");

        }
        static void Main(string[] args)
        {
            Seletor();
        }
    }
}
