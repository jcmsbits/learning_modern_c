public class MyFunctions
{
    // De esta manera declaramos la función, el último tipo es el que retorna la función
    private Func<int, int, int> MyPrivateAdd = (x, y) => x + y;

    // Action es un tipo de función que retorna nada, es como escribir void, pero declara los
    // tipos de datos de entrada
    private Action<int> MyPrivateNumber = x => Console.WriteLine(x);

    public int Add(int a, int b)
    {
        int LocalAdd(int x, int y)
        {
            return x + y;
        }

        return LocalAdd(a, b);
    }
}