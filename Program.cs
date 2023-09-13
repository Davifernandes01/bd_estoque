using Sales;
using Product;


    internal class Program
    {
        private static void Main(string[] args)
        {
           

        try
        {
           Console.WriteLine("antes da venda: ");
           var p1 = new product(1,"tv", "tv 23polegada", 1,DateTime.Now);
           Console.WriteLine(p1);
           var v1 = new sales(1,p1,3,7000.00m,DateTime.Now.AddDays(3));
           Console.WriteLine("------------------");
           Console.WriteLine("depois da venda: ");
           Console.WriteLine(p1);
           v1.UpdateAmount(8000.00m);
           v1.UpdateQuantity(1);
           v1.UpdateDateOfSales(DateTime.Now.AddDays(4));
           Console.WriteLine("depois da atualização: ");
           Console.WriteLine(p1);

        }
        catch (Exception ex)
        {
                 Console.WriteLine($"{ex.Message}");
        }
        
           
        }
    }

