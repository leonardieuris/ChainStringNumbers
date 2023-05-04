namespace ChainStringNumbersLibrary
{
    public abstract class Validator : IValidator
    {
        protected IValidator _successor;

        public void SetSuccessor(IValidator successor)
        {
            _successor = successor;
        }

        public abstract (bool,string) IsValid(List<string> myList);
    }
}
