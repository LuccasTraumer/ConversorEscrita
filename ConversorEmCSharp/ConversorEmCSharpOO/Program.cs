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
                var convertida = new ConversorMorse(letras);

                letrasMorse = convertida.Converter();



                WriteLine(letras+"                          "+letrasMorse);
                
                
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
