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


}*/



//Console.WriteLine("hapukapsas");
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
//int muutuja = 3;
// int       -> on muutuja nime ees olev andetüübi kirjeldus mis näitab ära, millist tüüpi andmed selle mutuja sees on.
//           -> sõnaga, ja mille abil saab neid addresirida koodi sees
// =         -> üksuk võrdusmärk omistab muutuja sisse vastava väärtuse mis asub teisepool võrdusmärki
// 3         -> muutujale omistatav väärtus.
// Võimalikud andmetübid mida vaja võib minna 
//int a = 1; // int on täisarv
//decimal b = 2.1M; // decimal on kümebdsüstemis olev komakohaga arv
//float c = 3.9f; // float on 32-bittine komakohaga arv
//double d = 5.6d; //double on 64-bitine komakohaga arv
//char c1 = 'a'; // üksainus täht või tähemark
//var y = 123; //ta võib omada endas teisti admetüüpe 
//const int z = 9; // konstant tüüpi mujutad ei saa parandada 

//// mutuja nimed 
//int arv = 0; //sobib
//string sõne = "abc"; //sobib 
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
using System;
using System.Net.NetworkInformation;

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

if (true) { }
//kaitstud sõna "if" kutsub esile tingimuslause, mille tingimus on sulgude vahel, ning millele järgneb
//koodiplokk tingimuse täitumisel teostatava koodiga
else if (true) { }
//kaitstud sõnad "else" ja "if" (else if) kutsuvad esile sekundaarse tingimuslause, mille tingimus 
//on samamoodi sulgude vahel, ning millele pepab eelnema alat kas "If" või teine "else if". Tingimuse täitumisel
//ja eelneva tingimuse mittetäitumisel, teostatakse koodiploki sees olev kood.
else { } //kaitstud sõna else kutsub esile järeltingimuse, millele peab eelnema kas "if" või "else if", ning mille koodiploki sisu
         //täidetakse kõikide teiste "if" ja "else if" tingimuste Läbikulumisel.
int option = 3; // -----
switch (option)//"swith" on kaitstud sõna alternatiivse tingimuskontrolli jaoks mida saab ef else-if asemel kasutada.
//Sulgude vahele käib muutuja nimi, mille põhjal tingimuslik ümberlülitus toimub. Siin sulgude vahel
//ei ole tingimus ise, vaid kõigest kontrollitav muutuja, või omakorda sulgude vahel muu tingimus.
//pärast lülitusvalikut tuleb koodiplokk.


{
    case 1:           //koodiploki sees on erinevad juhtumid, juhtumit sätestatakse kaitsud sõna "case" abil. antud juhul kontrollitakse,
                      //kas muutujas "option" on väärtus 1, millele järgned koolon ":" väljendades tingimuse täitumisel tehtava
                      //kooditegevuse algust
                      //Kui tegevis on tehtud, väljutakse mitte ainult juhtumist vaid kogu käesoleva case-tingimustikust kaitstud
        break;        //sõnaga "break". Peale breaki on läuselõpumärk ";
        case 2:       //Juhtumeid võib mitmeid, antud juhul on neid kolm kindlat.
           break;
    case 3:
        Console.WriteLine(option); //tehtav kooditegevus.
        break;
    default:         //Default juhtumit täidetakse siis, kui ülejäänud juhtumid ei kirjelda muutujas "option" olevat seisu.
        break;       //Ka default lõppeb sõnaga break.


        /* sõne tööristad ja muud teksiga seotut */
        string alfa = "a\nb";        // \n -> tekitab ühe sõne sisse reamurde, sõne kus on sees üks "\n", omab kahte rida.
        string beta = $"a {alfa} b"; // $-> lubab kasutada muutjaid loogeliste sulgudega otse teksti sees. On variant
                                     //     formateeritud stringist.



}

/* Logilised tehtd  */

//&& -> "and" loogiline tehe, mida kasutatakse tingimuste kirjeldamisel, ning mis annab positiivse vastuse /(true) juhul lui
//mõlemal poll "&&" märki olevad tingimused on täidetud. Kui üks neist ei ole, siis annab negatiivse vastuse (false).
// || "or"! loogiline tege, mida kasutatakse tingimuste kirjeldamisel, ning mis annab positiivse vastuse (true) siis kui
// vähemalt üks tingimus on täidetud. Negatiivne vastus (false) tagastatakse siis, kui kõik tingimused on täitmata.
//->"not" loogiline tehe, mida kasutatakse tingimuse tulemuse inverteerimiseks. Tulemus, mis muidu tagastaks (true),
//hüüumärgi abil tagastab (false), ja vastupidi tulemus mis muidu tagastaks (false), hüüumärgi abil tagastab (true)

/*  Võrdluseoperaatorid   */
//  ==>   "on võrdne".Võrdusmärkide ühel pool olev objekt peab vastama täpselt oma olemuselt võrdusmärkide teise pool oleva
//        objektiga. ei ole sama nagu üks võrdusmärk, üks võrdusmärk omistab, kaks võrdleb.
// != -> "ei ole võrdne". Võrdusmärgi ühel pool olev objekt EI TOHI olla samal kujul nagu võrdusmärgi teisel pool olev objekt.
//        Ta võib olla ükskõik mis muul kujul, aga mitte võrreldava objektiga samal kujul.
//        "on võrdne operaatorist, ja loogilisest tehtest "not".
//   > -> "on suuren kui". Märgist vasakul pool olev objekt peaks olema suuren, kui paremal pool olev objekt.
//   < -> "on väiksem kui". Märgist vasakul pool olev objekt peaks olema väiksem, kui paremal pool olev objekt.
//   >= -> "suurenvõrdne". Märgist vasakul pool olev objekt peaks olema vähemalt võrdne või suurem kui parempoolne objekt.
//         Võrluseoperator on kombinatsion  " on võrdne" ja "on suurem, kui " operatoriesr
//   <= -> "väiksemvõrdne".Märgist vasakul pool olev objekt peaks olema vähemalt võrdne või väiksem kuiparempoolne objekt.
//          Võrdlusoperaator on kombinatsioon "on võrdane" ja "on väiksem kui operatoritest"

int thing = 1;     //üksik võrdusmärk omistab muutuja sisse väärtuse, mida saab kasutada läbi muutuja nime.
thing += 1;       //+->võrdusmärk mille ees on pluss, automaatselt liidab muutujale otsa võrdusmärgi teisel pool oleva arvu.
                 //-->asendab tehet "thing = thing + 1". on kombinatsioon matemaatilisest tehtest "+" ja omistamisest "=".
thing = 1;      //võrdusmärk mille ees on miinus, automaatselt lauhtab muutujast maha võrdusmärgi teisel pool oleva arvu.
                //asendab tehet "thing = thing 1". on kombinatsioon matemaatilisest tehtest "-" ja omistamisest "="
thing *= 2;     // =->võrdusmärk mille ees on korrutusmärk "", automaatselt korrutab muutuja sisu, võrdusmärgi teisel pool oleva arvu kordi. asendab tehet "thing thing 2". on kombinatsioon matemaatilisest tehtest "*" ja
                //omistamisest "=".
thing /= 2;      // /= -> võrdusmärk mille ees on jagamismärk "/", automaatselt jagab muutuja sisu võrdusmärgi teisel pool oleva
                 // arvu osadeks. asendab tehet "thing = thing / 2" on kombinatsioon matemaatilisest tehtest "/" ja
                 //omistamisest "=".
thing++;         // ++ -> on spetsifiliselt ühe juurde liitmiseks kiitehe.
thing--;         // -- -> on spetsiifiliselt ühe maha lahutamiseks kiirtehe.

/* Tsüklid */
// 1. do-while
do // "do" on kaitstud sõna, mis alustab do-while tsüklit. Pärst seda on koodiplokk {} ning ütleb et tee seda koodi
{
}
while (true); //niikaua kuni while järel olevate sulgude vahel tingimus ei täitu, käivitatakse eelnev kood uuesti.
//2. while
int i = 1;   // tsüklimutuja mis aitab järge pidada while tsükli toitmisel
while (i < 5) // "while" on kaitsud sõna mis alustab while tsükli varianti, ilma "do"- ta, ning vajab alati välist
{
}
//tsüklimuutujat. antud juhul on selleks i. Tsükli tingimus, mis peale "while" sõna on, asub sulgude vahel,
//siin kontrollitaksegi tsükli tööd, läbi kindla tingimuse kasutades tsüklimuutujat.
// antud juhul tsükkel töötab niikaua,kion jäiksem kui 5. kui i on sama suur nagu 5, siis tsükkel
//katkeb.

//koodiplokk kus midagi tehakse
i++; // ning seejärel muudetakse tsüklimuutuja "i" olekut. antud juhul liidetakse 1 juurde kiirtehtega "++".


Console.WriteLine("Sisesta osumma");
double ostusumma = double.Parse(Console.ReadLine());
if (ostusumma > 100) 
{
    Console.WriteLine("SAAD 20% ALLAHINDLUST!!!!!!!!!OMG!!!");
}
else if (ostusumma < 101 && ostusumma > 50)
{
    Console.WriteLine("Saad 10% allahindlust. c: yay");
}
else if (ostusumma < 51 && ostusumma > 20)
{
    Console.WriteLine("5% allahindlust.");
}
else if (ostusumma < 21 && ostusumma > 0)
{
    Console.WriteLine("allahindlust ei saa");
}
else
{
    Console.WriteLine("sisestatud on vigane arv");
}

//string kasutajaNimi = "";
//do
//{
//    Console.WriteLine("Palun sisesta oma kasutajanimi");
//    kasutajaNimi = Console.ReadLine();
//} while (kasutajaNimi != "user1");
//if (kasutajaNimi == "user1")
//{
//    int ruuduSuurus = 0;

//    do
//    {
//        Console.WriteLine("Kui suut ruutu saada tahad?");
//        ruuduSuurus = int.Parse(Console.ReadLine());
//    } while (ruuduSuurus < 0 || ruuduSuurus > 20);


//    char reaKujund = '▓';
//    string üksRida = "";
//    int tsükliMuutuja = ruuduSuurus;

//    do
//    {
//        üksRida = üksRida + "_" + reaKujund;
//        tsükliMuutuja = tsükliMuutuja - 1;
//    } while (tsükliMuutuja != 0);

//    tsükliMuutuja = ruuduSuurus;

//    do
//    {
//        Console.WriteLine(üksRida);
//        tsükliMuutuja -= 1;
//    } while (tsükliMuutuja != 0);
//    Console.WriteLine($"Palun, siin on sinu ruut, suurusega {ruuduSuurus}x{ruuduSuurus}");
//}

/* Võimalikud andmetüübid mida vaja võib minna: */
int  a = 1;             // int on täisarv
decimal b = 2.1M;       // decimal on kümnendsüsteemis olev komakohaga arv
float c = 3.9f;         // float on 32-bitine komakohaga arv
double d = 5.6d;        // double on 64-bitine komakohaga arv
char c1= 'a';           // üksainus täht või tähemärk mis tähistatakse ülakomadga
string s = "tekst";     //tähtedest koosnev sõna või tekst, tähistatakse jutumärkidega
var x = "abc";          //var on ebamäärase andmetüübiga kohalik muutuja
var y = 123;            //ta võib omada endas teisi andmetüüpe
const int z = 9;        // konstant-tüüpi muutujaid ei saa muuta, nende sisu on read-only


/*Võimalikud komposiitandmetüübid */
//1. massiiv:
//[]  Massiiv on komposiitandmetüüp, mille sees saab olla mitmeid samat tüüpi lihtandmeid. Massiivi tähistatakse kant.sulgudega.
//    Massive saab olla ükskõik millist lihtandmetüüpi massiive.
//    Massiivi tekitamisel tuleb ära õelda kui pikk või kui suur see massiiv on.
//    Massiiv ei pea olema koostatud ainult Lihtandmetüüpidest, vaid massiive saab olla ka tehtud teistest komposiitandmetüüpidest
//    Sealhulgas massiiv ise.
// Esimene tekitusviis:
int[] arvuMassiiv = new int[3]; // andmetüüp int väljendab et tegu on täisarvutüüpi andmega ja kantsulud väljendavad et ühtlasi on 
                                // tegu ka massiiviga. muutuja nimeks on "arvulassiiv" ja võrdusmärgi abil on omistatud muutujasse
                                //uus tühi massiiv kasutades kaitstud sõna "new", millele järgneb selle massiivi andmetüübi ja
                                // pikkuse sätestus "int[3]". See tähendab et siin massiivis on 3 elementi, mis on täisarvud.
                                //teine tekitusviisint
int[] arvuMassive2 = [1, 2, 3];// teine massiivi tekitusviis kus järjendi pikkuse sätestamise asemel, pannakse elemendid kohe
                               // järjendit omava muutuja sisse, järjendi pikkust sätestama ei pea, kuna pikkuse tuletab kompilaator
                               // sinna sisse pandud elementide koguse järgi.
                               //------massivi sisemised meetodi tehted 
int hasThisMany = arvuMassiiv.Length; // massiivi meetod "Length" mille me saame kasutusele võtta punkti abil, loendab kokku 
                                      // mitu elementi, adresseeritav massiiv omab, omistatakse ainult järjendi pikkus, mitte 
                                      // järjendi sees olevaid elemente.
                                      //3. For 
int kogus = 6; // muutja mida tsükel kasutab oma töö tegemiseks - tesisõnu, töödelvad materjal
for (int k = 0; k < kogus; k++);   // kaitstud sõnaa "for" alustab for-tsüklit, pärast mida on sulud, mille vahel on kõik tsükli
                                   // töö jaoks vajalik olemas. Esimene parameeter, tekitab tsükli töö jaoks kohaliku muutuja
                                   //"int k = 0; mida tsükli ENDA töö juhtimiseks. Teine parameeter on tingimuslause, mis kontrollib
                                   // tingimuse täitumist "k < kogus; ning mille täitumisel tsükli töö jätkub, aga mille
                                   // mitte-täitumisel tsükkel katkeb. Kolmas parameeter on
                                   // "k++", Pane tähele, et iga sulgude vahel oleva osa järel (välja arvatud viimase) on 
                                   // lauselõpumärk. Tsükli tööd kontrolliv tingimuslause koosneb kolmest reast, mitte ühest 
                                   // nagu "while" või "do-while puhul.
Console.WriteLine(0);               // sulgudele järgneb, loogeliste sulgude vahel ole koodiplokk ()
                                   // töötlustegevus tsükli sees, on muutuja "k" hetkearvu väljakuvamine.
//using System.Runtime.ExceptionServices;

//Console.WriteLine("For tsükle");
//int kogus = 666;

//for (int i = 0; i < kogus; i++)
//{
//    Console.WriteLine("o((>u< )) o");
//    Console.Beep();
//}

//string[] objectArray  = new string[5]; //array, massiv mitmest elemendist
//int objectCount  = 0; // loend kuyi palju kordi küsida 
//string temp = "no name"; //muutuja mis hetkel on "tühi"
//while (objectCount < 5)
//{ 
//    Console.WriteLine("Sisesta järgmine lemmiklooma nimi");
//temp=Console.ReadLine();
//    objectArray[objectCount] = temp;
//    objectCount++;
//}
//Console.WriteLine("Oled sisestanud järgnevad loomanimed");
//for (int i = 0; i < objectArray.Length; i++)
//{
//    Console.WriteLine($"{i+1}. loomani on: {objectArray[i]}");
//}


string[] monster = { "MrSketelt", "Frankenstein", "i mayk vozovski" };
Console.WriteLine(monster[0]);
