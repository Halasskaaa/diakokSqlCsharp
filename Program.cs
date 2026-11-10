namespace diakokSqlC_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Database db = new Database();

            List<Diak> diakok = db.DiakokBetoltese();

            //var eredmeny = diakok
            //    .GroupBy(d => d.Osztaly)
            //    .Select(csoport => new
            //    {
            //        Osztaly = csoport.Key,
            //        Atlag = csoport.Average(d => d.Atlag)
            //    });

            //foreach (var adat in eredmeny)
            //{
            //    Console.WriteLine($"{adat.Osztaly}: {adat.Atlag:F2}");
            //}


            //var eredmeny = diakok
            //    .GroupBy(d => d.Osztaly)
            //    .Select(csoport => new
            //    {
            //        Osztaly = csoport.Key,
            //        Atlag = csoport.Average(d => d.Atlag)
            //    })
            //    .OrderByDescending(adat => adat.Atlag);


            //foreach (var adat in eredmeny)
            //{
            //    Console.WriteLine($"{adat.Osztaly}: {adat.Atlag:F2}");
            //}


            //var eredmeny = diakok
            //    .GroupBy(d => d.Osztaly)
            //    .Select(csoport =>
            //    {
            //        double legjobbAtlag = csoport.Max(d => d.Atlag);

            //        return csoport
            //        .Where(d => d.Atlag == legjobbAtlag)
            //        .Select(d => new
            //        {
            //            d.Osztaly,
            //            d.Nev,
            //            d.Atlag
            //        });
            //    });

            //foreach (var diak in eredmeny)
            //{
            //    foreach(var adat in diak)
            //    {
            //        Console.WriteLine($"{adat.Osztaly} - {adat.Nev} - {adat.Atlag}");
            //    }
            //}


            var eredmeny = diakok
                .GroupBy(d => d.Eletkor)
                .Select(csoport => new
                {
                    Eletkor = csoport.Key,
                    Letszam = csoport.Count()
                });

            foreach(var adat in eredmeny)
            {
                Console.WriteLine($"{adat.Eletkor} éves: {adat.Letszam} fő");
            }







        }
    }
}
