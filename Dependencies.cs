
public interface IDependencyA {}

public class DependencyA : IDependencyA {}

public interface IDependencyB {}
public class DependencyB : IDependencyB {}
public interface IDependentClassA {}

public class DependentClassA : IDependentClassA 
{
    private readonly IDependencyA depA;
    private readonly IDependencyB depB;

    public DependentClassA(IDependencyA depA, IDependencyB depB)
    {
        this.depA = depA;
        this.depB = depB;
        
    }
}
