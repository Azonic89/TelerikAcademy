namespace VisitorExample.Contracts
{
    using Entities.Abstract;

    internal interface IVisitor
    {
        void Visit(Element element);
    }
}
