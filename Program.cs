using System;
using System.Text.RegularExpressions;

namespace ReduzString
{
    internal class Program
    {
        private static string InitialInput { get; set; }

        private static string FinalResult { get; set; }

        private static string MidResult { get; set; }


        private static List<char> AllowedInputs = new List<char> { 'a', 'b', 'c' };

        static void GetInputs()
        {
            Console.Clear();
            Console.WriteLine("Entre com a string a ser reduzida");

            string input = Console.ReadLine();

            if (input is not null)
                InitialInput = input.Trim().ToLower();
            else
                throw new Exception("Input não pode ser nulo.");
        }

        static void ValidateInputs()
        {
            // Validar se existem caracteres não aceitos na string 
            for (int i = 0; i < InitialInput.Length; i++)
            {
                if (InitialInput[i] == 'a' || InitialInput[i] == 'b' || InitialInput[i] == 'c')
                {
                    MidResult = InitialInput;
                }
                else
                {
                    throw new Exception("Existem caracteres não aceitos na string");
                }
            }
        }

        static bool IsStringReducible(string reducibleString)
        {
            for (int i = 1; i < MidResult.Length; i++)
                if (MidResult[i] != MidResult[0])
                    return true;

            return false;
        }


        static void StringReduce(string reducibleString)
        {
            // AABC -> ACC -> BC -> A
            // Checar se a string pode ser reduzida
            if (IsStringReducible(reducibleString) == false)
            {
                FinalResult = reducibleString;
                return;
            }
            // Iterar na string procurando um par que possa ser reduzido
            else
            {

            }
            // Reduzir o par ao caractere desejado
            // Reiterar a string procurando outro par que possa ser reduzido
            // Armazenar em final result a string reduzida 
        }

        static void DisplayResults()
        {
            // Exibir string original
            Console.WriteLine($"Original: {InitialInput}");
            // Exibir string final
            Console.WriteLine($"Final: {FinalResult}");
            // Exibir quantidade de caracteres presentes na string final
            Console.WriteLine($"Tamanho: {FinalResult.Length}");
        }

        static void Main(string[] args)
        {
            // Testar se inputs geram o resultado esperado

            // Receber input
            GetInputs();
            // Validar input
            ValidateInputs();
            // Pode ser reduzida?
            IsStringReducible(MidResult);
            // Reduzir a string
            StringReduce(MidResult);
            // Exibir os resultados
            DisplayResults();
        }
    }
}