public class HaloGeneric
{
    public void SapaUser(string x)
    {
        Console.WriteLine("Hallo User "+x);
    }

}
public class Program
{
    public static void Main(string[] args)
    {
        HaloGeneric halo = new HaloGeneric();
        string nama = Console.ReadLine();
        halo.SapaUser(nama);
    }
}

