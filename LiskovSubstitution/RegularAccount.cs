namespace LiskovSubstitution
{
    abstract internal class RegularAccount : Account
    {
        protected RegularAccount(string? name, decimal balance) : base(name, balance)
        {
        }

        public abstract void WithDraw(decimal amount);
    }
}
