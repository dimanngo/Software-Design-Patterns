using VistorPattern.VisitorBase;

namespace VistorPattern.ElementBase
{
    public interface IElementBase
    {
        void Accept(IVisitorBase visitor);
    }
}
