namespace Product;


    internal class Program
    {
        private static void Main(string[] args)
        {
           var p1 = new Product(1,"tv", "tv 23polegada", 4,DateTime.Now);

            Console.WriteLine(p1.id);
            Console.WriteLine(p1.name);
            Console.WriteLine(p1.description);
            Console.WriteLine(p1.last_Delivery_date);

             Console.WriteLine("---------------");

            Console.WriteLine(p1.UpdateDescription("atualizando a descrição")); 
            Console.WriteLine(p1.isIncreaseAmount(3));
            Console.WriteLine(p1.isDecreaseAmount(2));
            Console.WriteLine(p1.UpdateName("teste"));

            Console.WriteLine($"data de saida {p1.get_last_Departure_date(new DateTime(2023,07,02,09,30,09))},");

            Console.WriteLine(p1);
        }
    }

