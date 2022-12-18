/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
*/
/*
using System;
using System.Collections.Generic;

namespace CompositePatternDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Composite Pattern Demo mit einem Einkaufswagen:");

            // Erstelle eine Liste von Waren im Einkaufswagen
            CompositeElement warenkorb = new CompositeElement("Warenkorb");
            warenkorb.Add(new SingleElement("Gurke", 2.99));
            warenkorb.Add(new SingleElement("Apfel", 1.99));

            // Erstelle eine Liste von Gemüse in der Einkaufskiste
            CompositeElement einkaufskiste = new CompositeElement("Einkaufskiste");
            einkaufskiste.Add(new SingleElement("Tomate", 3.99));
            einkaufskiste.Add(new SingleElement("Zwiebel", 4.99));

            // Füge die Einkaufskiste zur Liste der Waren hinzu
            warenkorb.Add(einkaufskiste);

            // Zeige den Preis des Einkaufs an
            Console.WriteLine("Der gesamte Einkaufswagen kostet: {0}", warenkorb.TotalPrice());

            Console.ReadKey();
        }
    }

    /// <summary>
    /// Die 'Component' Klasse
    /// </summary>
    abstract class Element
    {
        protected string _name;

        public Element(string name)
        {
            this._name = name;
        }

        public abstract double TotalPrice();
    }


    /// <summary>
    /// Die 'Leaf' Klasse
    /// </summary>
    class SingleElement : Element
    {
        private double _price;

        public SingleElement(string name, double price)
            : base(name)
        {
            this._price = price;
        }

        public override double TotalPrice()
        {
            return _price;
        }
    }


    /// <summary>
    /// Die 'Composite' Klasse
    /// </summary>
    class CompositeElement : Element
    {
        private List<Element> _elements = new List<Element>();

        public CompositeElement(string name)
            : base(name)
        {
        }

        public void Add(Element element)
        {
            _elements.Add(element);
        }

        public void Remove(Element element)
        {
            _elements.Remove(element);
        }

        public override double TotalPrice()
        {
            double total = 0.0;

            Console.WriteLine("{0} enthält:", _name);

            foreach (Element e in _elements)
            {
                total += e.TotalPrice();
            }

            return total;
        }
    }
}*/


/*
using System;
using System.Collections.Generic;

// "Component"
abstract class Employee
{
    protected string name;

    // Constructor
    public Employee(string name)
    {
        this.name = name;
    }

    public abstract void Add(Employee e);
    public abstract void Remove(Employee e);
    public abstract void Display(int depth);
}

// "Composite" 
class Manager : Employee
{
    private List<Employee> _employees = new List<Employee>();

    // Constructor
    public Manager(string name) : base(name)
    {
    }

    public override void Add(Employee employee)
    {
        _employees.Add(employee);
    }

    public override void Remove(Employee employee)
    {
        _employees.Remove(employee);
    }

    public override void Display(int depth)
    {
        Console.WriteLine(new String('-', depth) + name);

        // Recursively display child employees
        foreach (Employee employee in _employees)
        {
            employee.Display(depth + 2);
        }
    }
}

// "Leaf"
class Developer : Employee
{
    // Constructor
    public Developer(string name) : base(name)
    {
    }

    public override void Add(Employee employee)
    {
        Console.WriteLine("Cannot add to a leaf");
    }

    public override void Remove(Employee employee)
    {
        Console.WriteLine("Cannot remove from a leaf");
    }

    public override void Display(int depth)
    {
        Console.WriteLine(new String('-', depth) + name);
    }
}

// "Client" 
class Program
{
    static void Main(string[] args)
    {
        // Create the root
        Manager root = new Manager("CEO");
        root.Add(new Developer("Developer A"));
        root.Add(new Developer("Developer B"));

        // Create the first level
        Manager firstLevel = new Manager("VP");
        firstLevel.Add(new Developer("Developer C"));
        firstLevel.Add(new Developer("Developer D"));

        // Create the second level
        Manager secondLevel = new Manager("Manager A");
        secondLevel.Add(new Developer("Developer E"));
        secondLevel.Add(new Developer("Developer F"));
        firstLevel.Add(secondLevel);

        root.Add(firstLevel);

        // Display the hierarchy
        root.Display(1);

        Console.ReadKey();
    }
}*/




using System;
using System.Collections.Generic;

// composite class – represents a part of the 		
// composite hierarchy 
public abstract class Organigramm
{
    protected string position;
    public Organigramm(string Position)
    {
        this.position = Position;
    }

    public abstract void AddParent(Organigramm parent);
    public abstract void AddChild(Organigramm child);
    public abstract void Display(int depth);
}

// "Leaf" class – leaf nodes have no children 
public class GroupLead : Organigramm
{
    // Constructor 
    public GroupLead(string position) : base(position)
    {
    }

    public override void AddParent(Organigramm parent)
    {
        Console.WriteLine("Cannot add to a leaf node");
    }

    public override void AddChild(Organigramm child)
    {
        Console.WriteLine("Cannot add to a leaf node");
    }

    public override void Display(int depth)
    {
        Console.WriteLine(new String('\t', depth) + position);
    }
}

// "Composite" class – contains i.e. parent-child relationships 
public class DepartmentLead : Organigramm
{
    List<Organigramm> children = new List<Organigramm>();

    // Constructor 
    public DepartmentLead(string position) : base(position)
    {
    }

    public override void AddParent(Organigramm parent)
    {
        Console.WriteLine("Cannot add parent to a department lead");
    }

    public override void AddChild(Organigramm child)
    {
        children.Add(child);
    }

    public override void Display(int depth)
    {
        Console.WriteLine(new String('\t', depth) + position);

        // Display each child element on this node 
        foreach (Organigramm child in children)
            child.Display(depth + 2);
    }
}

public class CompositePattern
{
    public static void Main(string[] args)
    {

        // Creating first tier of Composite 
        Organigramm ceo = new DepartmentLead("Melloni Farina - CEO");

        // Adding second tier of composite 
        ceo.AddChild(new GroupLead("Gianni Costantini - EVP of Product"));
        ceo.AddChild(new GroupLead("Giovanni Costantini - EVP of HR"));

        // Creating third tier of Composite 
        Organigramm productLead = new DepartmentLead("Bob Cresta - Product Leadership ");
        ceo.AddChild(productLead);

        // Adding fourth tier of composite 
        productLead.AddChild(new GroupLead("Aldo Cresta - Product Manager of Development"));
        productLead.AddChild(new GroupLead("Paolo Gianni - Product Manager of Testing"));

        //Display the entire hierarchy 
        ceo.Display(1);

        Console.ReadKey();
    }
}