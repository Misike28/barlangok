using System.Text;
List<Barlang> list = new List<Barlang>();

using StreamReader sr = new("..\\..\\..\\src\\barlangok.txt", Encoding.UTF8);
sr.ReadLine();
while (!sr.EndOfStream)
{
    list.Add(new(sr.ReadLine()));
}

Console.WriteLine($"4. feladat: {list.Count}");


var f5 = list.Where(b => b.Telepules.Contains("Miskolc"))
          .Average(b => b.Melyseg);

Console.WriteLine($"5. feladat: A miskolci barlangok átlagos mélysége: {f5:0.000} m");

string vedett = "";
Console.Write("Kérem adjon meg egy védettségi szintet:");
vedett=Console.ReadLine();

var f6 = list.Where(b=>b.Vedettseg==vedett)
    .MaxBy(b => b.Hossz);

if (f6 == null)
{
    Console.WriteLine("Nincs ilyen védettségi szinttel barlang az adatok között");
}
else
{
    Console.WriteLine($"6. feladat: \n{f6}");
}


var f7 = list.GroupBy(b => b.Vedettseg);
Console.WriteLine("7. feladat: Barlangok védettség alapján rendezve: ");
foreach (var f in f7)
{
    Console.WriteLine($"\t{f.Key+":" + new string('-', 30 - f.Key.Length),-30}> {f.Count()} db");
}

