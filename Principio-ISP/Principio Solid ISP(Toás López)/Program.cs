using Principio_Solid_ISP_Toás_López_;

class Program
{
    static void Main(string[] args)
    {
        Humano humano = new Humano();

        humano.Trabajar();
        humano.Comer();

        Console.WriteLine();

        Robot robot = new Robot();

        robot.Trabajar();
    }
}