public class ParentA
{
    public int ParentAProp{ get; set; }
}

public class ChildA : ParentA
{
    public int ChildAProp{ get; set; }
}

public class ChildB : ParentA
{
    public int ChildBProp{ get; set; }
}

