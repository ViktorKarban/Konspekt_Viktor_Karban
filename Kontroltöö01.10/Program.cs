using System.ComponentModel.Design;

Console.WriteLine("Tere kasutaja, mis on sinu nimi?");
string nimi  = Console.ReadLine();
Console.WriteLine(nimi + ", mis on sinu śünniaasta?: ");
int kasutajavanus = int.Parse(Console.ReadLine());
Console.WriteLine("Mis temperatuur komakohaga arvuna?");
double temp  = double.Parse(Console.ReadLine());
if (temp < 0)
{
    Console.WriteLine("põrgu jäätis");
}
else if (temp < 0 && temp > 10) 
{
    Console.WriteLine("päris külm on");
}
else if (temp < 11  && temp > 20 )
{
    Console.WriteLine("noormalne ilm");
}
else if (temp < 21 && temp > 30)
{
    Console.WriteLine("kas läheb grilimiseks?");
}
else if (temp < 31 && temp > 40)
{
    Console.WriteLine("APPI, GLOBAALNE SOOJEMINE");
}
Console.WriteLine("Kas sa tahad vaariska, maasikat või apelsini?");
string vastus  = Console.ReadLine();
if (vastus == "vaarikat")
{

    Console.WriteLine("näe, vaarikas!");
}
else if (vastus ==  "maasikat")
{
   
    Console.WriteLine("maasikaski on ");
}
else if (vastus == "apelsini")
{
    Console.WriteLine("apelsini mul on kahjuks ei ole  :C");
}