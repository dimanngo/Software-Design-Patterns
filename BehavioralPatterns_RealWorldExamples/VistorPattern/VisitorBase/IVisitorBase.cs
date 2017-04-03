using VistorPattern.ConcreteElements;

namespace VistorPattern.VisitorBase
{
    public interface IVisitorBase
    {
        void Visit(Wheel wheel);
        void Visit(Body wheel);
        void Visit(Engine wheel);
        void Visit(Transmission wheel);
    }
}
