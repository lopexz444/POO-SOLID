using Principio_solid_LSP_Tomás_López_;

class Program
{
    static void Main(string[] args)
    {
        Perro perro1 = new PastorAleman();
        Perro perro2 = new PerroMudo();

        perro1.Comer();
        perro2.Comer();

        PastorAleman pastor = new PastorAleman();
        pastor.Ladrar();
    }
}