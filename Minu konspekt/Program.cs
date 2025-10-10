/*using System.ComponentModel.Design;

namespace MINUKONSPEKT_NK
{
internal class Program
    {
        static void Main(string[] args)


        {


            //Console.WriteLine("Hello, World!");

            //Muutujad, Matemaakilised tehted, IF, ELSE IF ja ELSE:

            //1. tusun njo921 2088wg

            Console.WriteLine("Tere kasutaja, mis on sunu nimi");

            string nimi = Console.ReadLine();

            if (nimi == "")

            {

                Console.WriteLine("Kasutaja ei sisestanud oma nime");

            }
            else if (nimi != "")

            {

                Console.WriteLine("Tere " + nimi + "!");

            }

            else

            {

                Console.WriteLine("Kasutaja ei sisestanud oma nime");


            }





            //2. tuvasta jsiugjs salam salam slama ///double/floart andmememrut


            Console.WriteLine(nimi + ", mis on sinu vanus?: ");


            int kasutajavanus = int.Parse(Console.ReadLine());


            //2.1 831246328HFDWUSI


            //if (kasutajavanus > 0 )


            //{


            //    if (kasutajavanus < 18)


            //    {


            //        Console.WriteLine("Kahjuks emergijoki sulle ei muuda. oled pivasik ilma 🤣👍😂🧐");


            //    }


            //    else


            //    {


            //        Console.WriteLine("saad osta pivasik salam💎💎💎🛠️🛠️🛠️🛠️");


            //    }


            if (kasutajavanus > 0 && kasutajavanus < 18)


            {


                Console.WriteLine("Kahjuks emergijoki sulle ei muuda. oled pivasik ilma 🤣👍😂🧐");


            }


            else


            {


                Console.WriteLine("saad osta pivasik salam💎💎💎🛠️🛠️🛠️🛠️");


            }


            Console.WriteLine("Sisesta oma pikkus ka, palun, " + nimi + ":");


            double pikkus = double.Parse(Console.ReadLine());


            if (pikkus < 1.00d)


            {


                Console.WriteLine("Oldes juntsu");


            }


            else if (pikkus < 1.25d && pikkus > 1.00d)


            {


                Console.WriteLine("Oled peaaegu allameetrimees");


            }


            else if (pikkus < 1.50d && pikkus > 1.25d)


            {


                Console.WriteLine("Oiosi pakapikk enam e olegi " + nimi + "!");


            }


            else if (pikkus < 1.75d && pikkus > 1.5d)


            {


                Console.WriteLine("Mne len pisat etu huynu");


            }


            else if (pikkus < 2.00d && pikkus > 1.75d)


            {


                Console.WriteLine("Pikk kolge vaata et sa pead vastu uksewpita ara ei löö.");


            }


            else if (pikkus > 2.00d)


            {


                Console.WriteLine("yu so tall hello");


            }


            else


            {


                Console.WriteLine("pikkust ei tunta");





            }


            Console.WriteLine("Tere. Sisesta esimene arv");


            int arv1 = int.Parse(Console.ReadLine());


            Console.WriteLine("Tere. Sisesta teine arv");


            int arv2 = int.Parse(Console.ReadLine());


            Console.WriteLine("sisesta tehtemärk: / * + - ");


            string tehtetyyp = Console.ReadLine();





            int tulemus = 0;


            if (tehtetyyp == "+")


            {


                tulemus = arv1 + arv2;


            }


            else if (tehtetyyp == "-")


            {


                tulemus = arv1 - arv2;


            }


            else if (tehtetyyp == "/")


            {


                tulemus = arv1 / arv2;


            }


            else if (tehtetyyp == "*")


            {


                tulemus = arv1 * arv2;


            }


            else if (tehtetyyp == "^")


            {


                tulemus = (int)Math.Pow(arv1, arv2);


            }


            else


            {


                Console.WriteLine("Palun sisesta tehe, mida kalkulaator tuvastada oskab");


            }





            if (tulemus != 0)


            {


                Console.WriteLine(tulemus);


            }


            else


            {


                Console.WriteLine("Tulemus on 0, või üritasid teha tehet, mida kalkulaator ei tunne");


            }





            Console.WriteLine("Kas sa tahad õuna või banaani?");


            string vastus = Console.ReadLine();


            if (vastus == "õuna")


            {


                Console.WriteLine("õuna panul: 🍏🍎");


            }


            else if (vastus == "banaani")


            {


                Console.WriteLine("banaan palun: 🍌🍌🍌🍌🍌🍌");


            }


            else


            {

                Console.WriteLine("Sellist puuvilja ma ei tunne");


            }
            //4 parool, if ja string admetüüp
            Console.WriteLine("Programi edasiseks tööks sisesta palun parool:");
            string password = Console.ReadLine();
            if (password == "simsalabin")
            {
                Console.WriteLine("Parool on õige, aarete laegas avaneb");
            }
            else if (password == "qwerty" || password == "6778")
                    {
                Console.WriteLine("Pasword palun");
                    }
            else
            {
                Console.WriteLine("Eror parol");
                    // värvituvas 
                    Console.WriteLine("Milline värv sulle kõige rohkem meldib?:");
                string favouriteColour = Console.ReadLine(); 
                if(favouriteColour == "punane")
                { }
            }
            }
            

        }


    }


}
*/
using System.Net.NetworkInformation;

Console.WriteLine("hapukapsas");
//Console    -> on modul (C# mida me adressime, Console aitab teha teguvusi käserual
// .         -> näitab, et meil on vaja adressida mingisugust  funktsiooni või metodit
//              moduli "Console" sest
//WrieLine   -> Funktsioon mida me kasutame,
//()         -> sulupaar mis omab funktsioni tööks vajaliku infot
//[]         -> tähistab massive
//{}         -> koodiplokk, tavalisrlt kas pärast (if, else if) tingimust, namespscei või fumktsioni kirjeldus 
//"hapukapsas" parameet mis antakse funktsionile WriteLine töölmiseks kassa,
//            -> Taane aitab arendaja aru saab , kuskkohas millise koodiploki sees kood asub, see on vajalik ka kampilatorile smal eesmärgil
//            -> kõik kodilaused lõppevad komakooloniga, mis tähistavad lause lõppu 
//            ->tähistab üheralis kommentari
// /**/       ->tähistab mimeralist materialit kommentari või kommentariregioni
int muutuja = 3;
// int       -> on muutuja nime ees olev andetüübi kirjeldus mis näitab ära, millist tüüpi andmed selle mutuja sees on.
//           -> sõnaga, ja mille abil saab neid addresirida koodi sees
// =         -> üksuk võrdusmärk omistab muutuja sisse vastava väärtuse mis asub teisepool võrdusmärki
// 3         -> muutujale omistatav väärtus.
// Võimalikud andmetübid mida vaja võib minna 
int a = 1; // int on täisarv
decimal b = 2.1M; // decimal on kümebdsüstemis olev komakohaga arv
float c = 3.9f; // float on 32-bittine komakohaga arv
double d = 5.6d; //double on 64-bitine komakohaga arv
char c1 = 'a'; // üksainus täht või tähemark
var y = 123; //ta võib omada endas teisti admetüüpe 
const int z = 9; // konstant tüüpi mujutad ei saa parandada 

// mutuja nimed 
int arv = 0; //sobib
string sõne = "abc"; //sobib 
                     //string string = "abc"; // kaitsud sõna kasutada ei saa

// muutuja nieks ei sobi järgnevad sõnad:
// abstract, as, base, bool, break, byte,case,
//catch, char, checked, class, count, continue, decimal,
//default, delegate, do, double, else, enum, event,
//explicit, extern, false, finally, fixed, float, for
//foreach, goto, if, implicit, in, int, interface, internal
//is, lock, long, namespace, new, null, object, operator,
//out, override, params, private, protected, public, readonl
//ref, return, sbyte, sealed, short, sizeof, stackalloc,
//static, string, struct, switch, this, throw, try, typeof,
//uint, ulong, unchecked, unsafe, ushort, using, virtual,
//void, volatile, while.


//3 kalkulaator ifi ja elsifidega
Console.WriteLine("Tere. Sisesta esimene arv");
//Adresserime moodulit "Console", punkti abil ütleme, et kasutame funktsiooni WriteLine
//selle jaoks et öelda kasutajale sõnum mis asub funktsiooni nime järel sulgude vahel
//ümbritsetuna jutumärkidega.

int arv1 = int.Parse(Console.ReadLine());
//instantsieerime muutuja nimega "arvl", ning selle ette anname andmetüübiks "int", see
//ütleb ära, et siin muutujas on täisarvudees Omitame muutujale võrdusmärgi abil
///väärtuse, mille saame kasutajalt. Selle jaoks, adresseerime uuesti "Console"modul
////Aga seekord on funktsiooni nimi "ReadLine". Selleks, et käsureapealt tulev arv programmile
//tekstina ei näe välja, küsime int mooduli seest omakorda funktsiooni "Parse", ning paneme
//ReadLine funktsiooni Parse() sulqude vahele.
Console.WriteLine("Tere. Sisesta teine arv");
//Adresserime moodulit "Console", punkti abil ütleme, et kasutame funktsiooni WriteLine
//selle jaoks et õelda kasutajale sõnum mis asub funktsiooni nime järel sulgude vahel
//ümbritsetuna jutumärkidega. Kasutajale esitatav sõnum on "Tere. Sisesta teine arv".
int arv2 = int.Parse(Console.ReadLine());
//instantsieerime muutuja nimega "arv2", ning selle ette anname andmetüübiks "int", see
//ütleb ära, et siin muutujas on täisarvud sees. Omistame muutujale võrdusmärgi abil
//väärtuse, mille saame kasutajalt. Selle jaoks, adresseerime uuesti "Console" moodulit
//Aga seekord on funktsiooni nimi "ReadLine". Selleks, et käsureapealt tulev arv programmile
//tekstina ei näe välja, küsime int mooduli seest omakorda funktsiooni "Parse", ning paneme
//ReadLine funktsiooni Parse() sulgude vahele.
Console.WriteLine("Sisesta tehtemärk: /* + -");
//Adresseerime moodulit "Console" koos "WriteLine" funktsiooniga, et esitada kasutajale 
//küsimuse "Sisesta tehtemärk:/+". Punkti abil saame moodulist Console, funktsiooni 
//WriteLine, ning sulgude vahel ongi kasutajale esitatav tekst. Tekst ise on ka ümbritsetud
//jutumärkidega. Lause lõppeb lauselõpumärgiga ";".

string tehtetyyp = Console.ReadLine();
//instantsieerime muutuja nimega "tehtetyyp", mille ette kirjutame andmetüübiks "string".
//Omistame võrdusmärgi abil, sellesse muutujasse kasutajalt sisendi mille saame kasutade
//"Console" moodulis oleva ReadLine() funktsiooni abil. Lause lõppeb lauselõpumärgiga ";".
int tulemus = 0;
//instantsieerime muutuja nimega "tulemus", andmetüübiga int, ning omistame talle algse 
//väärtuse võrdusmärgi abil, milleks on 0. Lause lõppeb lauselõpumärgiga ";".
if (tehtetyyp == "+")
//teeme tingimuslause if, ning selle tingimuse määrame ära sulgudega, mille vahel on 
//võrdsuskontroll. Kontrollime kas muutuja "tehtetyyp" omab andmeid samal kujul 
//nagu võrdusmärkidest teisel pool olev tekst "+". Siin lause ei lõppe, kuna tegu ei
///ole koodiga mis midagi kindlalt veel ära teeb.
{
    tulemus = arv1 + arv2;
    //peale tingimust on koodiplokk {} sulgude vahel, mis sialdab endas ühte koodirida.
    //selles lauses omistame muutujale "tulemus" võrdusmärgi abil liitmistehte tulemuse,
    //kus liidame kokku muutuja "arv1" ja muutuja "arv2" sisu. Lause lõppeb lauselõpumärgiga ";".
}
else if (tehtetyyp == "-")
//teeme sekundaarse tingimuslause "else if", ning määrame tema tingimuse ära sulgudega.
//Sulgude vahel on võrdsuskontroll. Kontrollime kas muutuja "tehtetyyp" omab andmeid 
//samal kujul nagu võrdusmärkidest teisel pool olev tekst "-" kui eelnev tingimus ei 
//täitunud. Lause siin ei lõppe, vaid tingimusele järgneb koodiplokk.
{
    tulemus = arv1 - arv2;
    //peale tingimust on koodiplokk {} loogeliste sulgude vahel, mis sisaldab endas ühte 
    //koodirida. selles lauses omistame muutujale "tulemus" võrdusmärgi abil lahutustehter 
    //tulemuse, kus lahutame muutuja "arv" sees olevast väärtusest maha "arv2" muutujas 
    //oleva väärtuse. Lause lõppeb lauselõpumärgiga ";".
}
else if (tehtetyyp == "/")
// teeme sekundaarse titingimuslase "esse if", ning määrassme tema tigimuse ära sulgudega. 
//Sulgude vahel on võrdsuskontroll. Kontrollime kas muutuja "tehtetyyp" omab andmeid
//samal kujul nagu võrdusmärkidest teisel pool olev tekst "/" kui eelnev tingimus e'i
//täitunud. Lause siin ei lõppe, vaid tingimusele järgneb koodiplokk.
{
    tulemus = (arv1 / arv2);
}
//peale tingimust on koodiplokk {} loogeliste sulgude vahel, mis sisaldab endas ühte
//koodirida. selles lauses omistame muutujale "tulemus" võrdusmärgi abil korrutustehte
//tulemuse, kus jagame muutujas "arv1" oleva väärtuse, muutujas "arv2" oleva jagajaga
//Lause lõppeb lauselõpumärgiga ";".
else if (tehtetyyp == "*")
//teeme sekundaarse tingimuslause "else if", ning määrame tema tingimuse ära sulgudega.
//Sulgude vahel on võrdsuskontroll. Kontrollime kas muutuja "tehtetyyp" omab andmeid
//samal kujul nagu võrdusmärkidest teisel pool olev tekst "*" kui eelnev tingimus ei
//täitunud. Lause siin ei lõppe, vaid tingimusele järgneb koodiplokk.
{
    tulemus = arv1 * arv2;
    //peale tingimust on koodiplokk {} loogeliste sulgude vahel, mis sisaldab endas ühte 
    //koodirida. selles lauses omistame muutujale "tulemus" võrdusmärgi abil korrutustehte
    //tulemuse, kus korrutame muutujas "arv2" oleva väärtuse muutujas "arvi" oleva väärtuse
    //kordi. Lause lõppeb lauselõpumärgia
}
else if (tehtetyyp == "^")
//teeme sekundaarse tingimuslause "else if", ning määrame tema tingimuse ära sulgudega.
//Sulgude vahel on võrdsuskontroll, kontrollime kas muutuja "tehtetyyp" omab andmeid
//samal kujul nagu võrdusmärkidest teisel pool olev tekst """ kui eelnev tingimus ei
//täitunud. Lause siin ei lõppe, vaid tingimusele järgneb koodiplokk.
{
    tulemus = (int)Math.Pow(arv1, arv2);
    //peale tingimust on koodiplokk {} loogeliste sulgude vahel, mis sisaldab endas ühte
    //koodirida. Selles lauses omistatakse võrdusmärgi abil muutujasse "tulemus" mille saame
    //"Math moodulist pärineva funktsiooni "Pow()" abil. Math.Pow() võtab parameetritena
    //sisse muutjad "arvl" ja "arv2". Esimene parameeter on astendatav, teine parameeter
    //on astendaja. Funktsiooni Math.Pow() ees on kiirteisendus (int), kuna muutuja
    //"tulemus" andmetüüp on täisarv. Math.Pow() väljund teisendatakse nii täisarvuks
    //Lause lõppeb lauselõmärgiga ";"
}
else
//peale kõiki järeltingimusi on meil tingimuslause osa "else" mida täidetakse kõikide
//muude tingimuslause osade mittetäitumisel. Siin eraldi tingimust välja ei kirjutada
//ning sellest tulenevalt ei ole ka sulge. Järgneb ainult koodiplokk.
{
    Console.WriteLine("Palun sisesta tehe, mida kalkulaator tuvastada oskab");
    //peale "else" on koodiplokk {} loogeliste sulgude vahel, mis sisaldab endas ühte 
    //koodirida. Selles koodireas kasutame moodulist "Console" punkti abil funktsiooni 
    //"WriteLine" et öelda kasutajale "Palun sisesta tehe, mida kalkulaator tuvastada
    //oskab. Koodirida Lõppeb lauselõpumärgiga ";".
}
Console.WriteLine(tulemus);
//Kasutame moodulist "Console" punkti abil funktsiooni "WriteLine" et kuvada kasutajale
//tehte tulemus. Selle jaoks on WriteLine funktsioonis parameetrina pandud muutuja
//"tulemus" ilma tekstiks teisendamata. Lause lõppeb lauselõpumärgiga "".


