
Console.WriteLine("Hello, World!");
//double default 64, decimal tu i tamo 128
double theDouble = 9.99;
int theInt = (int)theDouble;
int theOtherInt = Convert.ToInt32(theDouble);
//implicit vs explicit casting
//DateTime, today, now
//substring,interpolacija stringovi, StringSplitOptions, Split
//switch case
//params kao argumenti funkcije na kraju
//tasks

//async Task<string> JednaAsinkrona()
//{
//    await Task.Delay(5000);
//    return "Uspjeh";
//}

//Console.WriteLine("Upisi run za pocetak asinkronog taska");

//while (true)
//{
//    var string? upisi = Console.ReadLine();
//    if(upisi == "run")
//    {
//        var Task? taskic = Task.Run(async () =>
//        {
//            string? ispis = await JednaAsinkrona();
//        Console.WriteLine(ispis);
//        }
//    }
//

//double d;

//while (true)
//{
//    d = Double.Parse(Console.ReadLine());

//    if(d <= 0)
//    {
//        d = d * d;
//    }

//    else
//    {
//        d = Double.Sqrt(d);
//    }

//    Console.WriteLine(Double.Round(d,2));
//}

//2) 
//Program koji kao input dobije niz stringova odvojenih razmakom i ispiše string koji se sastoji od prvih znakova unesenih stringova.
//Koristiti for ili foreach petlju.
//Npr. ako je input “test   jedan dva pet , tri”, treba ispisati “tjdp,”.

String s = Console.ReadLine();

foreach (string ss in s.Split(" ", StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries))
{
    Console.Write(ss[0]);

}

    //3)
    //Program koji stalno dobiva input. Ukoliko input nije broj, program treba ispisati “Molimo unesite broj”.
    //Ukoliko je uneseni broj veći ili jednak 0, program ispiše “Dobar broj”, a ukoliko nije, program baca ArgumentException kojem je poruka “Loš broj”.
    //Odluku o tome je li broj loš ili dobar staviti u metodu “HandleNumber”.

//    while (true)
//{
//    bool flag;
//    flag = Int32.TryParse(Console.ReadLine(), out int broj);
//    if (flag)
//    {
//        try
//        {
//            HandleNumber(broj);
//        }
//        catch (ArgumentException ex)
//        {
//            Console.WriteLine(ex.Message);
//        }

//    }
//    else
//    {
//        Console.WriteLine("Molimo unesite broj");
//    }
  
//}

//static void HandleNumber(int br)
//{
//    if (br >= 0)
//        Console.WriteLine("Dobar broj");
//    else
//        throw new ArgumentException("Loš broj");
//}