namespace VisitorExample.Entities.Abstract
{
    using Contracts;

    internal abstract class Element
    {
        public abstract void Accept(IVisitor visitor);
    }
}
