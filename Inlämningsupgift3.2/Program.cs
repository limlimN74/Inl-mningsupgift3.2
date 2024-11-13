using System;
namespace InlämningsUpgift_3._2
{
    class program
    {
        static void Main(string[] args)
        {
            Console.Write("Har du gått ut gymnasiet? (j/n): ");
            char Gåttut = Console.ReadKey().KeyChar;
            Console.WriteLine();

            if (Gåttut == 'j' || Gåttut == 'J')
            {
                Console.Write("Hur gammal är du? ");
                int år = int.Parse(Console.ReadLine());

                if (år < 22)
                {
                    Console.WriteLine("Vi vill gärna anställa dig");
                }
                else
                {
                    Console.WriteLine("Vi letar tyvärr efter annan personal just nu");
                }
            }
            else
            {
                Console.WriteLine("Vi letar tyvärr efter annan personal just nu");
            }
        }
    }
}