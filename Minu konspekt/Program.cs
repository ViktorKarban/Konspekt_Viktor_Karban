using System.ComponentModel.Design;

namespace Minu_konspekt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello, World!");

            // Muutujad, Matematilised tehted, IF, ELSE IF ja ELSE
            Console.WriteLine("Tere kasutaja, mis on sinu nimi");
            string nimi = Console.ReadLine();

            if (nimi != "") 
            {
                Console.WriteLine("Kasutaja ei sisetanud oma nime");
            }
            else if (nimi != "")
            {
                Console.WriteLine("Tere" + nimi + "!");
            }

            else
            {
                Console.WriteLine("Kadutada ei sisestanud oma nime");
            }
            Console.WriteLine(nimi + ", mis on sinu vanus?: ");
            int kasutajavanus = int.Parse(Console.ReadLine());
            //if (kasutajavanus > 0)
            //{
            //    if (kasutajavanus < 18)
            //    { 
            //        Console.WriteLine("Kahjuks energiajookisulle ei müüda, oled Monsterist ilma") ;
            //     }
            //    else
            //    {
            //        Console.WriteLine("Saad monsteri, yippie");
            //    }
            if (kasutajavanus > 0 && kasutajavanus < 18)
            {
                Console.WriteLine("Kahjuks energiajooki sulle ei müüda, oled monsteri ilma");
            }
                else
            {
                Console.WriteLine("saad osta Monsteri YIPPIE");
            }
            Console.WriteLine("Sisesta oma pikkus ka palun" + nimi + ":");
            double pikkus = double.Parse(Console.ReadLine());
            if (pikkus < 1.00d )
            {
                Console.WriteLine("oled jutun");
            }
            else if (pikkus < 1.25d && pikkus > 1.00d)
                {
                Console.WriteLine("Oled praegu allameetrimees");
                }
            else if (pikkus < 1.50d && pikkus > 1.25)
            {
                Console.WriteLine("Otsi paka pikk enae e olegi");
            }
            else if (pikkus < 1.75d && pikkus >1.50)
            {
                Console.WriteLine("Oled enamasti standart pikkuses, kui mitte just natuke lühike");
            }
            else if (pikkus < 2.00d && pikkus > 1.75)
            {
                Console.WriteLine("Pikk koge vaata et sa pead vastu uksewpita ara ei töö");
            }
            else if (pikkus < 2.00d)
            {
                Console.WriteLine("you so tall");
            }
            else
            {
                Console.WriteLine("pikkust ei tunta");
            }





























        }
        

















        
        
           
    }
}
      