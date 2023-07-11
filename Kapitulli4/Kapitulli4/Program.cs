using System;

public class Blackjack
{

    public void FilloLojen()
    {

        int sum = 0;
        string pergjigje = "";

        while (sum <= 21 || pergjigje == "Mbaro")
        {

            Console.WriteLine("A deshironi te terhiqni leter apo doni te perfundoni lojen? (Pergjigjuni me 'Vazhdo' nese doni te vazhdoni dhe 'Mbaro' nese jo)");

            pergjigje = Console.ReadLine();

            if (pergjigje == "Vazhdo")
            {

                Random random = new Random();
                int num = random.Next(2, 10);
                Console.WriteLine("Letra juaj eshte {0}.", num);
                sum = num + sum;
                Console.WriteLine("Shuma e pikeve eshte {0}.", sum);

            }
            else
            {
                Console.WriteLine("Le te shohim doren e kundershtarit tuaj!");
                break;
            }
        }

        if (sum > 21)
        {
            Console.WriteLine("Ju humbet lojen. Shuma e pikeve kaloi numrin 21. Ju humbet {0} pike.", sum - 21);
        }
        else
        {
            Random random = new Random();
            int num2 = random.Next(2, 21);
            Console.WriteLine("Shuma e pikeve te kundershtarit eshte {0}.", num2);

            if (sum > num2)
            {
                Console.WriteLine("Urime, ju mundet kundershtarin tuaj! Ju keni fituar {0} pike.", sum - num2);
            }
            else if (num2 > sum)
            {
                Console.WriteLine("Fatkeqsisht, ju nuk e mundet kundershtarin tuaj! Ju keni humbur {0} pike.", num2 - sum);
            }
            else Console.WriteLine("Urime, ju dhe kundershtari juaj dolet barazim!");
        }
    }
}

public class Loja
{

    static void Main()
    {

        Blackjack loja = new Blackjack();

        Console.WriteLine("Ju lutem shkruani emrin tuaj:");
        string emri = Console.ReadLine();
        Console.WriteLine("Pershendetje {0}. Shpresojme t'ju pelqeje loja Blackjack!", emri);

        loja.FilloLojen();

    }
}