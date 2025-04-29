// Abstract significa que no puede instanciar la clase en absoluto
// tienes que heredar de ella
public abstract class Parent
{
    // private significa que solo tienen alcance en la clase
    protected int Age {get; set;}    
    // protected puede ser accedido a traves de herencia
    // internal no permite que otro proyecto tenga acceso en la misma solucion
    public string FirstName {get; set;} 
    public string LastName {get; set;}  

    public virtual void SetAge(int age)
    {
        this.Age = age;
    }
  
  // Con abstract en una función significa que tenemos que implementarla
    public abstract void SetFirstName(string firstName);
  
    // public Parent(string firstName)
    // {
    //     this.FirstName = firstName;
    // }
}

public class Child : Parent
{
    // public Child(int age, string firstName) : base(firstName)
    // {
    //     // No es necesario usar this. Este se refiere a la misma clase
    //     this.Age = age;
    // }
    
    public override void SetAge(int age)
    {
        base.SetAge(age);
        this.Age += 1;
    }

    public override void SetFirstName(string firstName)
    {
        this.FirstName = firstName;
    }
}

// Con sealed declaramos que no se puede heredar de la clase
// sealed class Child : Parent{
//   public void SetAge(int age)
//     {
//         this.Age = age;
//     }
// }

public class PasserBy
{
    public string GetDetails()
    {
        var somePartial =  new MyPartial
        {
            Age = 10,
            FirstName = "simon",
            LastName = "painter"

        };
        // new Parent da error por ser una clase abstracta
        // var parent = new Parent();
        // No es obligado pasar los param
        // var child = new Child(10, "simon");

        // Hay una manera rápida de agregar las propiedades en los objetos
        // es eliminando el contructor en la clase y pasando las propiedades con sus asignaciones
        //  al momento de crear el objeto
        var child = new Child{            
            FirstName = "simon",
            LastName = "painter"
        };

        child.SetAge(10);

        return child.FirstName + " " + child.LastName;
    }
}

// Con partial podemos crear clases muy grandes dividas en pedazos 
public partial class MyPartial
{
    public int Age {get; set;}
}

public partial class MyPartial
{
    public string FirstName {get; set;}
}

public partial class MyPartial
{
    public string LastName {get; set;}
}

