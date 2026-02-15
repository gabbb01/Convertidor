using EjercicioGit;

Longitudes longitud1 = new Longitudes(45);
Console.WriteLine("Longitud 1");
longitud1.ConversionCm();
longitud1.ConversionKm();

Console.WriteLine("");
Console.WriteLine("Masa 1");
Masa masa1 = new Masa(5);
masa1.ConversionGramos();
masa1.ConversionLibras();

Console.WriteLine("");
Console.WriteLine("Dolares a Lempiras");
Moneda dolar1 = new Moneda(15);
dolar1.Convertir_A_Lempiras();
dolar1.Convertir_A_Euros();

