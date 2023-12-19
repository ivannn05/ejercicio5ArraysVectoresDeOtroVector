namespace ejercicio5ArraysVectoresDeOtroVector;
class Program
{
    public static void Main(string[] args)
    {


        Console.WriteLine("Comienza el primer vector");

        Random numero = new Random();
        int[] vector1 =new int[5];

        for (int i = 0; i < vector1.Length; i++)
        {
            vector1[i] = numero.Next(100);

            Console.WriteLine(vector1[i]);
        }


        Console.WriteLine("-----------------------------------");
        Console.WriteLine("Comienza el segundo vector");


        int[] vector2 = new int[5];

        for (int i = 0; i < vector2.Length; i++)
        {
            vector2[i] = numero.Next(100);

            Console.WriteLine(vector2[i]);
        }
        Console.WriteLine("-----------------------------------");
        Console.WriteLine("Comienza el tercer vector");

        int[] vector3 = new int[5];

        for (int i = 0; i < vector3.Length; i++)
        {

            vector3[i] = vector1[i] + vector2[i];


            Console.WriteLine(vector3[i]);
        }

    }
}
