using CompositePattern.Composite;
using CompositePattern.Leafs;

namespace CompositePattern
{
    class Program
    {
        static void Main(string[] args)
        {

            ComplexShape shape1= new ComplexShape("Complex Shape #1"); 
            Line line1 = new Line("Blue Line #1");
            Line line2 = new Line("Blue Line #2");

            shape1.AddShape(line1);
            shape1.AddShape(line2);

            ComplexShape shape2 = new ComplexShape("Complex Shape #2");
            Circle circle1 = new Circle("Yellow Circle #1");
            shape2.AddShape(circle1);
            shape1.AddShape(shape2);

            shape1.Render(1);
            
        }
    }
}
