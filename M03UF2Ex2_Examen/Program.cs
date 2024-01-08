using System;
using M03UF2Ex2_Examen;
namespace M03UF2EX1
{
    class MyProgram
    {
        static void Main()
        {
            const string MsgMenu = "MENU: \na. Validar si un nombre es senar \nb. Calcular la potència d'un nombre \nc. Retornar un valor aleatori \nd. Comptar el nombre de vocals o consonants en un text \ne. Sortir";
            const string AskValue = "Enter a number:";
            const string AskBaseAndExpo = "Enter a base and a Exponent:";
            const string AskMinAndMax = "Enter the min and the max for the random rang:";
            const string AskText = "Enter a text:";
            const string MsgResult = "RESULT: ";

            char selection;
            bool exit = false, boolResult;
            int input, intResult,bas, exp, min, max;
            string inputText;

            while (!exit)
            {
                Console.WriteLine(MsgMenu);

                selection = Convert.ToChar(Console.ReadLine());

                switch (selection)
                {
                    case 'a':
                    case 'A':
                        Console.WriteLine(AskValue);
                        input = Convert.ToInt32(Console.ReadLine());
                        boolResult = ExMenu.OddNumber(input);
                        Console.WriteLine(MsgResult + boolResult);
                        break;
                }
            }
        }
    }
}

