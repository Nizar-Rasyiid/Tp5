public class HaloGeneric
{
    public void SapaUser(string x)
    {
        Console.WriteLine("Hallo User "+x);
    }

}

public class DataGeneric<T>
{
    private T data;
    public DataGeneric(T inputData) {
        data = inputData;
    }

    public void PrintData()
    {
        Console.WriteLine(data);
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Masukkan NIM: ");
        string classGen = Console.ReadLine();
        DataGeneric<string> data = new DataGeneric<string>(classGen);
        data.PrintData();
        HaloGeneric halo = new HaloGeneric();
        Console.WriteLine("Input Nama Anda: ");
        string nama = Console.ReadLine();
        halo.SapaUser(nama);
    }
}

