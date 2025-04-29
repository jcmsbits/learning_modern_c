public class MyArrays
{
    // Cuando se retorna un array se debe poner que retorna un IEnumerable
    // ya que es el nivel más alto de abstracción
    public IEnumerable<int> SomeArrayStuff()
    {
        var myArray = new[]
        {
            1,2,4,8,16,32, 54, 128
        };
        // Para obtener un elemento tenemos que forzar que se haga un array porque no sabe
        // cuanto elementos hay
        var myArrArr = myArray.ToArray();
        var third = myArrArr[2];
        var third_other = myArrArr.Skip(2).Take(1).Single();

        // Lo otro es una lista que es similar a un IEnumerable o un Array
        // la diferencia radica que podemos extender, agregar o remover elementos de el
        var lista = myArray.ToList();
        lista.Add(256);
        lista.Remove(2);
        lista.RemoveAt(1);
        
        // Para crear un diccionario desde una lista se pasa el primer argumento la llave y el
        // segundo el valor
        // La llave puede ser cualquier cosa, string,etc
        // var myDict = myArray.ToDictionary(x => x + 1, x => x);
        var myDict = myArray.ToDictionary(x => (x + 1).ToString(), x => x);
        // var five = myDict[5];
        var five = myDict["5"];
        
        // Otra manera de obtener un valor de un diccionario\
        var four = myDict.TryGetValue("hello", out var result) ? result : 0;

        return myArray;
    }
}