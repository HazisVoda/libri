using System;
class Vlerat
{
    public static void Main()
    {
        int vlera1;
        int vlera2;
        int opsioni;

        while (true)
        {
            Console.WriteLine("Ju lutem shkruani veprimin qe deshironi te kryeni.\n");
            Console.WriteLine("[1] Kontrollo nese eshte tek apo cift\n[2] Krahaso dy numra\n[3] Mblidh 2 numra\n[4] Zbrit dy numra\n[5] Shumezo dy numra\n[6] Pjeseto dy numra\n[7] Dil nga programi");

            opsioni = Int32.Parse(Console.ReadLine());

            switch (opsioni)
            {
                case 1:
                    Console.WriteLine("Shkruani dy numrat\n");
                    vlera1 = Int32.Parse(Console.ReadLine());

                    if (vlera1 % 2 == 0)
                    {
                        Console.WriteLine("Numri eshte cift.");
                    }
                    else Console.WriteLine("Numri eshte tek.");
                    break;
                case 2:
                    Console.WriteLine("Shkruani 2 numrat qe doni te krahasoni\n");
                    vlera1 = Int32.Parse(Console.ReadLine());
                    vlera2 = Int32.Parse(Console.ReadLine());

                    if (vlera1 == vlera2)
                    {
                        Console.WriteLine("Numrat jane te barabarte.");
                    }
                    else if (vlera1 > vlera2)
                    {
                        Console.WriteLine("Numri {0} eshte me i vogel sesa numri {1}", vlera1, vlera2);
                    }
                    else
                        Console.WriteLine("Numri {0} eshte me i madh sesa numri {1}", vlera1, vlera2);
                    break;
                case 3:
                    Console.WriteLine("Shkruani 2 numrat qe doni te mblidhni\n");
                    vlera1 = Int32.Parse(Console.ReadLine());
                    vlera2 = Int32.Parse(Console.ReadLine());

                    Console.WriteLine(vlera1 + vlera2);
                    break;
                case 4:
                    Console.WriteLine("Shkruani 2 numrat qe doni te zbrisni\n");
                    vlera1 = Int32.Parse(Console.ReadLine());
                    vlera2 = Int32.Parse(Console.ReadLine());

                    Console.WriteLine(vlera1 - vlera2);
                    break;
                case 5:
                    Console.WriteLine("Shkruani 2 numrat qe doni te shumezoni\n");
                    vlera1 = Int32.Parse(Console.ReadLine());
                    vlera2 = Int32.Parse(Console.ReadLine());

                    Console.WriteLine(vlera1 * vlera2);
                    break;
                case 6:
                    Console.WriteLine("Shkruani 2 numrat qe doni te pjestoni\n");
                    vlera1 = Int32.Parse(Console.ReadLine());
                    vlera2 = Int32.Parse(Console.ReadLine());

                    Console.WriteLine(vlera1 / vlera2);
                    break;
                case 7:
                    return;
                default:
                    Console.WriteLine("Opsion i gabuar! Provoni perseri!");
                    break;
            }
        }
    }
}
