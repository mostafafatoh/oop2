namespace oop2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car c1 = new Car();
            Car c2 = new Car();
            c1.SetPrice(6000);//c1.price = 6000;
                              //c2.price = 1000;
            double p = c1.GetPrice();
            Console.WriteLine(p);
        }
    }
}
