using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConversorArrays
{
    class Program
    {
        static void Menu()
        {
            WriteLine("-==-=-=-==--==-=-=-==--==-=-=-==--==-=-=-==--==-=-=-==--=");
            WriteLine("-==-=-=-==-Create by: Luccas Träumer.-==-==-==-==-=-=-==-");
            WriteLine("-==-=-=-==--==-=-=-==--==-=-=-==--==-=-=-==--==-=-=-==--=");
            WriteLine("  Pressione A: Para Conversor Morse. ");

            WriteLine("Pressione E para Finalizar.");

        }

        static void ExercicioA()
        {
            WriteLine("-=--=-==--= Conversor Morse.-=-=-=-=--=-=");
            WriteLine("O que Deseja converter?: ");
            string dadosInfo = ReadLine().ToUpper();
            int tamanhoDadoInfo = dadosInfo.Length; // TtAMANHO DA STRING DIGITADA
            int contador_Nome = 0; //Contado da String Nome
            int contador_Alfabeto = 0; // Contador do Alfabeto

            string PalavraMorse = "";
            // Alfabeto Normal
            char[] alfabeto_Normal = {'A','B','C','D','E','F','G','H','I','J','K','L','M',
                   'N','O','P','Q','R','S','T','U','V','W','X','Y','Z',' ' }; 
            // Alfabeto Morse
            string[] alfabeto_Morse = {".-","-...","-.-.","-..",".","..-.","--.","....","..",".---","-.-",".-..","--",
                  "-.","---",".--.","--.-",".-.","...","-",
                  "..-","...-",".--","-..-","-.--","--.."," " };

            char letras_DadosInfo = dadosInfo[contador_Nome];
            char letras_Alfabeto = alfabeto_Normal[contador_Alfabeto];
            string letras_Morse = alfabeto_Morse[contador_Alfabeto];
            WriteLine(" -=-=-=---= Letra a Letra.-==-=-=-=-=-=-==- ");
            WriteLine("  Alfabeto                       Cod.Morse  ");

            //Condiçoes
            while ( tamanhoDadoInfo > contador_Nome) 
            {
                if (contador_Alfabeto <= 27 && contador_Nome < dadosInfo.Length)
                {
                    letras_DadosInfo = dadosInfo[contador_Nome];
                    letras_Alfabeto = alfabeto_Normal[contador_Alfabeto];
                    letras_Morse = alfabeto_Morse[contador_Alfabeto];

                    if (letras_DadosInfo == letras_Alfabeto)
                    {
                        WriteLine(letras_DadosInfo + "                                  " + letras_Morse);
                        contador_Nome++;
                        contador_Alfabeto++;
                        contador_Alfabeto = 0;
                        PalavraMorse += letras_Morse;
                    }
                    else
                    {
                        contador_Alfabeto++;
                    }
                    
                }
                
            }
            WriteLine($"Palvra Completa                           Palavra em Morse");
            WriteLine(dadosInfo+"                                  "+PalavraMorse);

        }



        static void SeletorOpcoes()
        {
            string opcao = "";
            do
            {
                Menu();
                Write("Qual Exercicios Deseje Realizar?: ");
                opcao = ReadLine().ToUpper();
                switch (opcao)
                {
                    case ("A"):
                        ExercicioA();
                        EsperarEnter();
                        break;
                }
            } while (opcao != "E");
        }
        static void EsperarEnter()
        {
            Write("Pressione[ENTER] para Finalizar.");
            ReadLine();
        }
        static void Main(string[] args)
        {
            SeletorOpcoes();

        }
    }
}

