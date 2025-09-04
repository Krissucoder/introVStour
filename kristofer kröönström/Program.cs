namespace kristofer_kröönström
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int käimasolevAasta = 2025;
            int olenNiiVana = 560;
            int tehteTulemus = käimasolevAasta + olenNiiVana;
            //float pikkus = 2.5f;

            string sõnum = "Tere vanus on: ";


            //bool miskion = false;

            //Console.WriteLine(sõnum+tehteTulemus);
            //Console.WriteLine(sõnum+tehteTulemus);
            //Console.WriteLine(sõnum+tehteTulemus);
            //Console.WriteLine(sõnum+tehteTulemus);
            //Console.WriteLine(sõnum+tehteTulemus);
            //Console.WriteLine(sõnum+tehteTulemus);
            //Console.WriteLine(sõnum+tehteTulemus);
            //Console.WriteLine(sõnum+tehteTulemus);
            //Console.WriteLine(sõnum+tehteTulemus);

            int arv1 = 0;
            int arv2 = 0;
            Console.WriteLine("Tere, palun sisesta esimene liidetav: ");
            arv1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Tere, palun sisesta esimene liidetav: ");
            arv2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Missugust tehet soovid teha? Kirjuta kas: + - / *");
            string tehtetüüp = Console.ReadLine();
            int tehe = 0;




            if (tehtetüüp == "+"  /*tingimus siia:*/)
            {
                tehe = arv1 + arv2;
            }

            if (tehtetüüp == "*" /*tingimus siia:*/)
            {
                tehe = arv1 + arv2;
            }


            if (tehtetüüp == "/" /*tingimus siia*/)
            {
                tehe = arv1 + arv2;
            }





            if (tehtetüüp == "-"  /*tingimus siia */)
            {
                tehe = arv1 + arv2;
            }

            
            Console.WriteLine($"{tehtetüüp} Tehte tulemus: {tehe}");





















            //    int lahutatav1 = 0;
            //    int lahutatav2 = 0;
            //    Console.WriteLine("Tere, palun sisesta esimene lahutamine: ");
            //    lahutatav1 = int.Parse(Console.ReadLine());
            //    Console.WriteLine("Tere, palun sisesta esimene lahutamine: ");
            //    lahutatav2 = int.Parse(Console.ReadLine());
            //    int lahutamine = lahutatav1 - lahutatav2;
            //Console.WriteLine($"Tehte tulemus:  {lahutamine}");
            //    Console.WriteLine("Tehte tulemus: " + lahutamine);

            //    int korrutatav = 0;
            //    int korrutaja = 0;
            //    Console.WriteLine("Tere, palun sisesta esimene lahutamine: ");
            //    korrutatav = int.Parse(Console.ReadLine());
            //    Console.WriteLine("Tere, palun sisesta esimene lahutamine: ");
            //    korrutaja = int.Parse(Console.ReadLine());
            //    int korrutamine = korrutatav * korrutaja;
            //Console.WriteLine($"Tehte tulemus:  {korrutamine}");
            //    Console.WriteLine("Tehte tulemus: " + korrutamine);

            //    int jagatatav = 0;
            //    int jagaja  = 0;
            //    Console.WriteLine("Tere, palun sisesta esimene lahutamine: ");
            //    jagatatav = int.Parse(Console.ReadLine());
            //    Console.WriteLine("Tere, palun sisesta esimene lahutamine: ");
            //    jagaja = int.Parse(Console.ReadLine());
            //    int jagamine = jagatatav / jagaja;
            //Console.WriteLine($"Tehte tulemus:  {jagamine}");
            //    Console.WriteLine("Tehte tulemus: " + jagamine);








        }

    }

}